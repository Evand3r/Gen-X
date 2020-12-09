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
        public int Counter = 0;
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

            if(OutputFormat == EOutputFormat.SQL)
            {
                string tableName = (Options.Controls.Find("TableName", true)[0] as TextBox).Text;
                string columns = "";
                string values = "";

                for(var i = 0; i <= Fields.Count - 1; i++)
                {
                    columns += " {" + i + "} ,";
                    values += "{" + i  + "},";
                }

                //Remover la ultima coma.
                columns = columns.TrimEnd(',');
                values = values.TrimEnd(',');

                //Tomar los nombres de las columnas
                columns = string.Format(columns, Fields.ConvertAll(p => p.FieldName).ToArray());
                values = string.Format(values, Fields.ConvertAll(p => p.OptionsPanel.Options.Generate()).ToArray());

                //Insertar en el string original
                SQLLine = SQLLine.Replace("+", columns);
                SQLLine = SQLLine.Replace("-", values);
                SQLLine = SQLLine.Replace("__", tableName);
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
