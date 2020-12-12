using Bogus;
using Bogus.Extensions;
using Generador_X.Controls.ModifiedControls;
using Generador_X.Model;
using Generador_X.Model.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Generador_X.Model
{
#nullable enable
    /// <summary>
    /// Tipo base de panel de opciones.
    /// </summary>
    class BaseOptionsType : IOptions<string?[]>
    {
        public Label lblBlanks = new Label_("Nulos") { Margin = new Padding(0, 6, 0, 6) };
        /// <summary>
        /// Campo para el porcentaje de nulos de una columna.
        /// </summary>
        public readonly TextBox NullsCount = new TextBox
        {
            Width = 23,
            Anchor = AnchorStyles.Right,
            Text = "0",
            RightToLeft = RightToLeft.Yes,
            MaxLength = 2,
        };
        public Label lblPrcnt = new Label_("%") { Margin = new Padding(0, 6, 0, 6) };
        public List<Control> panelControls = new List<Control>();
        private EBCategory? EBCat;
        private EBFieldType? EBFld;

        //Cantidad de campos nulos, tomar de NullsCount TextBox
        public float Nulls
        {
            get
            {
                _ = int.TryParse(NullsCount.Text, out int tmp);
                NullsCount.Text = tmp.ToString();
                return (tmp % 100) / 100f;
            }

        }

        public BaseOptionsType()
        {
            panelControls.AddRange(new Control[] { lblBlanks, NullsCount, lblPrcnt });
        }

        public BaseOptionsType(EBCategory ebcat, EBFieldType ebfld)
        {
            panelControls.AddRange(new Control[] { lblBlanks, NullsCount, lblPrcnt });
            EBCat = ebcat;
            EBFld = ebfld;
        }

        public virtual string[] Generate(Faker fkr, int d, string q = "", string NullValue = "Null")
        {
            string[] value = new string[] { };
            try
            {
                if (EBCat != null && EBFld != null)
                {
                    value = Enumerable.Range(1, d)
                        .Select(_ => fkr.Parse("{{" + q + $"{(EBCategory)EBCat }.{(EBFieldType)EBFld}" + q + "'}}").OrDefault(fkr, Nulls, NullValue).ToString())
                        .ToArray();
                }
            }
            catch (Exception e)
            {
                ErrorHandler.ShowMessage("Ha ocurrido un error inesperado", MessageType.error);
            }

            //Si el array esta vacio llenarlo de null value o string
            if (value.Length == 0)
            {
                value = Enumerable.Repeat(NullValue.Length > 0 ? NullValue : string.Empty, d).ToArray();
            }

            return value;
        }
    }

    /// <summary>
    /// Opciones para tipo de campo numero de linea.
    /// </summary>
    class RowNumberOptionsType : BaseOptionsType
    {
        public override string[] Generate(Faker fkr, int d, string q = "", string NullValue = "Null")
        {
            int Value = 1;
            string[] a = new string[d];

            if (Nulls == 0)
            {
                var arr = Enumerable.Range(1, d).ToArray();
                a = Array.ConvertAll(arr, b => b.ToString());
            }
            else
            {
                for (int b = 0; b < a.Length; b++)
                {
                    if (fkr.PickRandom(true, false).OrDefault(fkr, Nulls, false))
                    {
                        a[b] = Value.ToString();
                    }
                    else
                    {
                        a[b] = NullValue;
                    }

                    Value++;
                }
            }

            return a;
        }
    }

    /// <summary>
    /// Opciones de Nombre que pueden variar con el 
    /// parametro de tipo de campo en el constructor.
    /// </summary>
    class OptionsName : BaseOptionsType
    {
        readonly EBFieldType FieldType;

        public OptionsName(EBFieldType fld)
        {
            FieldType = fld;
        }

        public override string[] Generate(Faker fkr, int d, string q = "", string NullValue = "Null")
        {
            return Enumerable.Range(1, d)
                .Select(_ => fkr.Parse(q + "{{Name." + FieldType + "}}" + q).OrDefault(fkr, Nulls, NullValue))
                .ToArray();
        }

    }

    /// <summary>
    /// Opciones de fecha u hora.
    /// </summary>
    class OptionsDateType : BaseOptionsType
    {
        DateTimePick_ DTFrom;
        DateTimePick_ DTTo;
        Label lblto = new Label_("hasta");
        Label lblfmt = new Label_("Formato");
        ComboBox CBDateFormats = new ComboBox { Width = 80, DropDownStyle = ComboBoxStyle.DropDownList };
        string SelectedFormat
        {
            get { return CBDateFormats.GetItemText(CBDateFormats.SelectedItem); }
        }

        public OptionsDateType(EBFieldType type = EBFieldType.Between)
        {
            DTFrom = new DateTimePick_(DateTime.Now.AddYears(-1));
            DTTo = new DateTimePick_(DateTime.Now);

            if (type == EBFieldType.Time)
            {
                DTFrom.Format = DTTo.Format = DateTimePickerFormat.Custom;
                DTFrom.CustomFormat = DTTo.CustomFormat = "H:mm";
                DTFrom.Value = DateTime.Today;
                DTTo.Value = DateTime.Today.AddHours(7);

                CBDateFormats.DataSource = new string[]
                {
                    "H:mm",
                    "HH",
                    "HH:mm",
                    "h:m",
                    "hh:mm",
                    "hh:mm:ss",
                };
            }
            else
            {
                CBDateFormats.DataSource = new string[] {
                        "dd/MM/yyyy",
                        "MM/dd/yyyy",
                        "yyyy-MM-dd",
                        "d/M/yyyy",
                        "d.M.yyyy",
                        "dd.MM.yyyy",
                        "dd-MMM-yyyy",
                        "yyyy/MM/dd",
                };
            }

            panelControls.InsertRange(0, new Control[] { DTFrom, lblto, DTTo, lblfmt, CBDateFormats });
        }

        public override string[] Generate(Faker fkr, int d, string q = "", string NullValue = "Null")
        {
            List<string> result = Enumerable.Range(1, d)
                .Select(_ => q + fkr.Date.Between(DTFrom.Value, DTTo.Value).ToString(SelectedFormat).OrDefault(fkr, Nulls, NullValue) + q)
                .ToList();

            if (Nulls > 0)
            {
                //Quitar las comillas de los valore nulos.
                result = result.ConvertAll(p => p == $"'{NullValue}'" ? "Null" : p);
            }

            return result.ToArray();
        }
    }
#nullable disable

    public interface IOptions<T>
    {
        /// <summary>
        /// Generar datos tipo T.
        /// </summary>
        /// <param name="fkr"></param>
        /// <param name="d"></param>
        /// <param name="q"></param>
        /// <param name="NullValue"></param>
        /// <returns></returns>
        public T Generate(Faker fkr, int d, string q, string NullValue = "Null");
    }
}
