using Bogus;
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
        private uint Lines;
        /// <summary>
        /// Instancia de faker.
        /// </summary>
        private readonly Faker fkr = new Faker(Settings1.Default.Idioma);
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
        private string DefaultNullValue = Settings1.Default.NullValue;
        /// <summary>
        /// Resultado de la generacion de datos.
        /// </summary>
        private string Result;
        private bool Preview;
        private string identation = "    ";

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

        private void GenerateJSON()
        {
            //Get options
            bool asArray = (Options.Controls.Find("JsonAsArray", true)[0] as CheckBox).Checked;
            bool includeNull = (Options.Controls.Find("IncludeNull", true)[0] as CheckBox).Checked;

            string baseJsonStr = "\"+\": -";
            string JsonLine = "{_}" + (asArray ? "," : "");
            string tmp = "";
            List<string[]> valuesArr = new List<string[]>();
            valuesArr.AddRange(Fields.ConvertAll(p => p.OptionsPanel.Options.Generate(fkr, Convert.ToInt32(Lines), "\'", DefaultNullValue)).ToArray());

            //Si es array, añadir bracket inicial
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

                tmp = !tmp.Equals(string.Empty) ? (asArray ? nl : "") + tmp.TrimEnd(',') + (tmp.EndsWith(nl) ? "" : nl) : nl;

                Result += JsonLine.Replace("_", tmp)/* + nl*/;
            }

            Result = Result.TrimEnd(',') + (asArray ? "]" : "");

            if (Preview)
            {
                PreviewForm PreviewFrm = new PreviewForm(Result);
                PreviewFrm.ShowDialog();
            }
        }

        private void GenerateSQL()
        {
            SaveFileDialog Save = new SaveFileDialog();
            StreamWriter writer = null;

            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();

            try
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
                    Save.Title = "Save an Image File";
                    //Nombre del archivo por defecto.
                    Save.FileName = tableName == "" ? "GEN_X.sql" : tableName + ".sql";
                    Save.ShowDialog();
                    writer = new StreamWriter(Save.OpenFile());
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
                    columns += " {" + i + "},";
                    values += " {" + i + "},";
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
                    writer.Write(createTableStr);

                    for (int i = 0; i < Lines; i++)
                    {
                        valuesChanged = string.Format(values, valuesArr.ConvertAll(p => p[i]).ToArray());
                        writer.WriteLine($"{SQLLine.Replace("-", valuesChanged)}");
                    }
                    writer.Dispose();
                    writer.Close();
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
            catch (Exception e)
            {
                ErrorHandler.ShowMessage(e.ToString());
            }
            finally
            {
                Cursor.Current = Cursors.Default;
                if (writer != null)
                {
                    writer.Dispose();
                    writer.Close();
                }
            }
        }
    }
}
