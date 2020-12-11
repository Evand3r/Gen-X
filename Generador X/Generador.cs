using Generador_X.Controls;
using Generador_X.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Generador_X
{
    class Generador
    {
        private uint Lines;
        private string Result;
        private string SQLLine = "INSERT INTO __ (+) VALUES (-)";
        private EOutputFormat OutputFormat;
        private List<FieldPanel> Fields = new List<FieldPanel>();
        private FlowLayoutPanel Options;
        private readonly string nl = Environment.NewLine;

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

            if (preview)
            {
                Lines = Lines > 10 ? 10 : Lines;
            }

            if (OutputFormat == EOutputFormat.SQL)
            {
                string createTableStr = "";
                string tableName = (Options.Controls.Find("TableName", true)[0] as TextBox).Text;
                string columns = "";
                string values = "";
                string valuesChanged = "";
                List<string[]> valuesArr = new List<string[]>();

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

                valuesArr.AddRange(Fields.ConvertAll(p => p.OptionsPanel.Options.Generate(Convert.ToInt32(Lines))).ToArray());
                for (int i = 0; i < Lines; i++)
                {
                    //Sustituir {i} por sus correspondientes valores
                    valuesChanged = string.Format(values, valuesArr.ConvertAll(p => p[i]).ToArray());
                    Result += $"{SQLLine.Replace("-", valuesChanged)}{nl}";
                }

                Result = createTableStr + Result;
            }

            if (preview)
            {
                PreviewForm PreviewFrm = new PreviewForm(Result);
                PreviewFrm.Show();
            }
            else
            {
                //Guardar archivo, esto va en MainView
            }
        }
    }
}
