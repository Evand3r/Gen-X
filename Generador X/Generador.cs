﻿using Bogus;
using Generador_X.Controls;
using Generador_X.Model.Enums;
using Generador_X.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Generador_X
{
    class Generador
    {
        /// <summary>
        /// Numero de lineas a generar.
        /// </summary>
        private readonly uint Lines;
        /// <summary>
        /// Instancia de faker.
        /// </summary>
        private readonly Faker fkr = new Faker(Settings.Default.Idioma);
        /// <summary>
        /// Formatos de salida.
        /// </summary>
        private readonly EOutputFormat OutputFormat;
        /// <summary>
        /// Lista de campos.
        /// </summary>
        private readonly List<FieldPanel> Fields = new List<FieldPanel>();
        private readonly FlowLayoutPanel Options;
        /// <summary>
        /// Caracter de nueva linea.
        /// </summary>
        private readonly string nl = Environment.NewLine;
        /// <summary>
        /// Valorn nulo por defecto.
        /// </summary>
        private readonly string DefaultNullValue = Settings.Default.NullValue;
        /// <summary>
        /// Resultado de la generacion de datos.
        /// </summary>
        private string Result;
        private readonly bool Preview;
        private readonly string identation = "    ";
        private SaveFileDialog Save;
        private StreamWriter Writer = null;

        public Generador(FieldPanel[] fields, EOutputFormat format, uint lines, FlowLayoutPanel options, bool preview = false)
        {
            OutputFormat = format;
            Lines = lines;
            Options = options;
            Fields.AddRange(fields);
            Preview = preview;

            if (Preview)
            {
                //Tamaño limite de lineas en modo vista previa
                Lines = Lines > 100 ? 100 : Lines;
            }
        }

        public void Generate()
        {
            if (Lines == 0)
            {
                return;
            }

            Save = new SaveFileDialog();

            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();

            try
            {
                switch (OutputFormat)
                {
                    case EOutputFormat.SQL:
                        GenerateSQL();
                        break;
                    case EOutputFormat.JSON:
                        GenerateJSON();
                        break;
                    case EOutputFormat.CSV:
                    case EOutputFormat.TSV:
                        GenerateCSVTSV();
                        break;
                    case EOutputFormat.Excel:
                        break;
                    case EOutputFormat.XML:
                        break;
                    case EOutputFormat.Personalizado:
                        break;
                    default:
                        break;
                }

            }
            catch (Exception e)
            {
                ErrorHandler.ShowMessage($"Ha ocurrido un error inesperado: {e}");
            }
            finally
            {
                Cursor.Current = Cursors.Default;
                if (Writer != null)
                {
                    Writer.Dispose();
                    Writer.Close();
                }
            }
        }

        private void GenerateCSVTSV()
        {
            //Get options
            bool includeHeader = (Options.Controls.Find("IncludeHeader", true)[0] as CheckBox).Checked;
            string outputExt = OutputFormat.ToString();
            string delimiter = OutputFormat == EOutputFormat.CSV ? "," : "\t";
            string columns = "";
            string values = "";
            string valuesLine = "";
            List<string[]> valuesArr = new List<string[]>();
            valuesArr.AddRange(Fields.ConvertAll(p => p.OptionsPanel.Options.Generate(fkr, Convert.ToInt32(Lines), "", "")).ToArray());

            if (!Preview)
            {
                Save.Filter = $"Archivo {OutputFormat}(*.{outputExt.ToLower()})|*.{outputExt.ToLower()}";
                Save.Title = $"Guardar archivo {OutputFormat}";
                //Nombre del archivo por defecto.
                Save.FileName = $"GEN_X.{outputExt.ToLower()}";
                Save.ShowDialog();
                Writer = new StreamWriter(Save.OpenFile());
            }

            for (int i = 0; i < Fields.Count; i++)
            {
                string fName = Fields.ElementAt(i).FieldName;

                if (fName.Contains('"'))
                {
                    fName = fName.Replace("\"", "\"\"");

                    fName = !fName.Contains(",") ? '"' + fName + '"' : fName;
                }

                if (delimiter == ",")
                {
                    if (fName.Contains(","))
                    {
                        fName = '"' + fName + '"';
                    }
                }

                columns += (i != 0 ? delimiter : "") + fName;
                values += (i != 0 ? delimiter : "") + "{" + i + "}";
            }

            if (!Preview && Save.FileName != "")
            {
                if (includeHeader)
                {
                    Writer.WriteLine(columns);
                }

                for (int i = 0; i < Lines; i++)
                {
                    valuesLine = string.Format(values, valuesArr.ConvertAll(p => p[i]).ToArray());
                    Writer.WriteLine(valuesLine);
                }
                Writer.Dispose();
                Writer.Close();
            }
            else
            {
                if (includeHeader)
                {
                    Result += columns + nl;
                }

                for (int i = 0; i < Lines; i++)
                {
                    valuesLine = string.Format(values, valuesArr.ConvertAll(p => p[i]).ToArray());
                    Result += valuesLine + nl;
                }

                PreviewForm PreviewFrm = new PreviewForm(Result);
                PreviewFrm.ShowDialog();
            }
        }

        private void GenerateJSON()
        {
            //Get options
            bool asArray = (Options.Controls.Find("JsonAsArray", true)[0] as CheckBox).Checked;
            bool includeNull = (Options.Controls.Find("IncludeNull", true)[0] as CheckBox).Checked;

            string baseJsonStr = "\"+\": -";
            string JsonLine = "{_}" + (asArray ? "," : "");
            string tmp = "";
            List<string[]> valuesArr = new List<string[]>();
            valuesArr.AddRange(Fields.ConvertAll(p => p.OptionsPanel.Options.Generate(fkr, Convert.ToInt32(Lines), "\"", DefaultNullValue)).ToArray());

            if (!Preview)
            {
                Save.Filter = "Json files (*.json)|*.json";
                Save.Title = "Guardar archivo JSON";
                //Nombre del archivo por defecto.
                Save.FileName = "GEN_X.json";
                Save.ShowDialog();
                Writer = new StreamWriter(Save.OpenFile());
            }

            Result = (asArray ? "[" : "");

            for (int i = 0; i < Lines; i++)
            {
                tmp = "";
                for (int j = 0; j < Fields.Count; j++)
                {
                    FieldPanel p = Fields.ElementAt(j);

                    if (includeNull || valuesArr[j][i] != DefaultNullValue)
                    {
                        tmp += (asArray ? identation : "") +
                            baseJsonStr.Replace("+", p.FieldName).Replace("-", valuesArr[j][i] + ",") +
                            (asArray && j + 1 != Fields.Count ? nl : "");
                    }
                }

                tmp = !tmp.Equals(string.Empty) || !asArray ? (asArray ? nl : "") + tmp.TrimEnd(',') + (!asArray ? "" : nl) : nl;

                if (!Preview)
                {
                    string line = (asArray && i == 0 ? "[" : "") + JsonLine.Replace("_", tmp);

                    if (asArray && i + 1 == Lines)
                    {
                        //Elimiar ultima coma del array
                        line = line.TrimEnd(',') + (asArray ? "]" : "");
                    }

                    Writer.WriteLine(line);
                }
                else
                {
                    Result += JsonLine.Replace("_", tmp) + (!asArray ? nl : "");
                }
            }

            if (Preview)
            {
                Result = Result.TrimEnd(',') + (asArray ? "]" : "");
                PreviewForm PreviewFrm = new PreviewForm(Result);
                PreviewFrm.ShowDialog();
            }
        }

        private void GenerateSQL()
        {
            string SQLLine = "INSERT INTO __ (+) VALUES (-)";
            string createTableStr = "";
            string tableName = (Options.Controls.Find("TableName", true)[0] as TextBox).Text;
            string columns = "";
            string values = "";
            string valuesChanged = "";
            List<string[]> valuesArr = new List<string[]>();

            if (!Preview)
            {
                Save.Filter = "SQL Script|*.sql";
                Save.Title = "Guardar script SQL";
                //Nombre del archivo por defecto.
                Save.FileName = tableName == "" ? "GEN_X.sql" : tableName + ".sql";
                Save.ShowDialog();
                Writer = new StreamWriter(Save.OpenFile());
            }

            //Añadir el create table
            if ((Options.Controls.Find("CreateTableCkBx", true)[0] as CheckBox).Checked)
            {
                createTableStr = $"CREATE TABLE {tableName} ({nl}";
                Fields.ForEach(f => createTableStr += '\t' + $"{f.TBFieldName.Text} {f.FieldType.ColumnType},{nl}");
                createTableStr += ");" + nl;
            }

            for (var i = 0; i <= Fields.Count - 1; i++)
            {
                columns += (i != 0 ? " " : "") + "{" + i + "},";
                values += (i != 0 ? " " : "") + "{" + i + "},";
            }

            //Remover la ultima coma.
            columns = columns.TrimEnd(',');
            values = values.TrimEnd(',');

            //Tomar los nombres de las columnas
            columns = string.Format(columns, Fields.ConvertAll(p => p.FieldName).ToArray());

            //Insertar Nombre de fila
            SQLLine = SQLLine.Replace("+", columns);
            SQLLine = SQLLine.Replace("__", tableName);

            valuesArr.AddRange(Fields.ConvertAll(p => p.OptionsPanel.Options.Generate(fkr, Convert.ToInt32(Lines), "\'", DefaultNullValue)).ToArray());

            if (!Preview && Save.FileName != "")
            {
                Writer.Write(createTableStr);

                for (int i = 0; i < Lines; i++)
                {
                    valuesChanged = string.Format(values, valuesArr.ConvertAll(p => p[i]).ToArray());
                    Writer.WriteLine($"{SQLLine.Replace("-", valuesChanged)}");
                }
                Writer.Dispose();
                Writer.Close();
            }
            else
            {
                for (int i = 0; i < Lines; i++)
                {
                    //Sustituir {i} por sus correspondientes valores
                    valuesChanged = string.Format(values, valuesArr.ConvertAll(p => p[i]).ToArray());
                    Result += $"{SQLLine.Replace("-", valuesChanged)}{nl}";
                }
            }

            Result = createTableStr + Result;

            if (Preview)
            {
                PreviewForm PreviewFrm = new PreviewForm(Result);
                PreviewFrm.ShowDialog();
            }
        }
    }
}
