using Bogus;
using Generador_X.Controls;
using Generador_X.Model.Enums;
using Generador_X.Properties;
using System;
using System.Collections.Generic;
using System.IO;
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
        private Faker fkr = new Faker(Settings1.Default.Idioma);
        /// <summary>
        /// Formatos de salida.
        /// </summary>
        private EOutputFormat OutputFormat;
        /// <summary>
        /// Lista de campos.
        /// </summary>
        private List<FieldPanel> Fields = new List<FieldPanel>();
        private FlowLayoutPanel Options;
        /// <summary>
        /// Caracter de nueva linea.
        /// </summary>
        private readonly string nl = Environment.NewLine;
        /// <summary>
        /// Resultado de la generacion de datos.
        /// </summary>
        private string Result;

        public Generador(FieldPanel[] fields, EOutputFormat format, uint lines, FlowLayoutPanel options)
        {
            OutputFormat = format;
            Lines = lines;
            Options = options;
            Fields.AddRange(fields);
        }

        public void Generate(bool preview = false)
        {
            if (Lines == 0)
            {
                return;
            }

            switch (OutputFormat)
            {
                case EOutputFormat.SQL:
                    GenerateSQL(preview);
                    break;
                case EOutputFormat.JSON:
                    break;
                case EOutputFormat.CSV:
                    break;
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

        private void GenerateSQL(bool preview)
        {
            try
            {
                if (preview)
                {
                    //Tamaño limite de lineas en modo vista previa
                    Lines = Lines > 100 ? 100 : Lines;
                }

                string SQLLine = "INSERT INTO __ (+) VALUES (-)";
                string createTableStr = "";
                string tableName = (Options.Controls.Find("TableName", true)[0] as TextBox).Text;
                string columns = "";
                string values = "";
                string valuesChanged = "";
                List<string[]> valuesArr = new List<string[]>();
                SaveFileDialog Save = new SaveFileDialog();
                StreamWriter writer = null;

                if (!preview)
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

                valuesArr.AddRange(Fields.ConvertAll(p => p.OptionsPanel.Options.Generate(fkr, Convert.ToInt32(Lines), "\'")).ToArray());

                if (!preview && Save.FileName != "")
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

                if (preview)
                {
                    PreviewForm PreviewFrm = new PreviewForm(Result);
                    PreviewFrm.ShowDialog();
                }
            }
            catch (Exception e)
            {
                ErrorHandler.ShowMessage(e.ToString());
            }
        }
    }
}
