using Bogus;
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
        public Faker Fkr = new Faker();
        public List<FieldPanel> Fields = new List<FieldPanel>();
        public EOutputFormat OutputFormat;
        public uint Lines;
        //public string Result;
        public string SQLLine = "INSERT INTO __ (+) VALUES (-)";
        public FlowLayoutPanel Options;


        public Generador(FieldPanel[] fields, EOutputFormat format, uint lines, FlowLayoutPanel options)
        {
            OutputFormat = format;
            Lines = lines;
            Options = options;
            Fields.AddRange(fields);
        }

        public void Generate()
        {
            if (Lines == 0)
            {
                return;
            }

            if (OutputFormat == EOutputFormat.SQL)
            {
                string tableName = (Options.Controls.Find("TableName", true)[0] as TextBox).Text;
                string columns = "";
                string values = "";
                string valuesChanged = "";
                List<string[]> valuesArr = new List<string[]>();
                string result = "";

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
                    valuesChanged = string.Format(values, valuesArr.ConvertAll(p => p[i]).ToArray());
                    result += $"{SQLLine.Replace("-", valuesChanged)}{Environment.NewLine}";
                }

                MessageBox.Show(result);
            }


            Fields.ForEach(delegate (FieldPanel Field)
            {
                switch (Field.FieldType.BCategoryName)
                {
                    case EBCategory.Date:
                        //Field.OptionsPanel.Controls;
                        break;
                    default:
                        break;
                }
            });
        }
    }
}
