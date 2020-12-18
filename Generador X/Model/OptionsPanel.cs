using Bogus;
using Bogus.Extensions;
using Generador_X.Controls.ModifiedControls;
using Generador_X.Model;
using Generador_X.Model.Enums;
using Generador_X.Properties;
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
    class BaseOptionsType : IOptions<string>
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
        public int Value = 1;
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

        //public virtual string[] Generate(Faker fkr, int n, string q = "", string NullValue = "Null")
        //{
        //    IEnumerable<string>? value = null;
        //    try
        //    {

        //        if (EBFld == EBFieldType.Hash)
        //        {
        //            value = Enumerable.Range(1, n)
        //                .Select(_ => (q + fkr.Random.Hash(40).ToString() + q).OrDefault(fkr, Nulls, NullValue));
        //        }
        //        else if (EBFld == EBFieldType.BoolDB)
        //        {
        //            value = Enumerable.Range(1, n)
        //                .Select(_ => fkr.PickRandom(1, 0).ToString().OrDefault(fkr, Nulls, NullValue));
        //        }
        //        else if (EBFld == EBFieldType.Bool)
        //        {
        //            value = Enumerable.Range(1, n)
        //                .Select(_ => fkr.Random.Bool().ToString().OrDefault(fkr, Nulls, NullValue));
        //        }
        //        else if (EBCat != null && EBFld != null)
        //        {
        //            string parseStr = q + "{{" + $"{EBCat?.ToString().ToLower()}.{EBFld?.ToString().ToLower()}" + "}}" + q;

        //            value = Enumerable.Range(1, n)
        //                .Select(_ => fkr.Parse(parseStr).OrDefault(fkr, Nulls, NullValue).ToString());
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        if (e.Message.StartsWith("Unknown method"))
        //        {
        //            ErrorHandler.ShowMessage($"El idioma actualmente seleccionado no soporta el tipo de dato {FieldTypes.Types.FirstOrDefault(p => p.Value.BName == EBFld).Value.SearchName}");
        //        }
        //        else
        //        {
        //            ErrorHandler.ShowMessage("Ha ocurrido un error inesperado.", MessageType.error);
        //        }
        //    }

        //    Si el array esta vacio llenarlo de null value o string
        //    if (value?.Count() == 0 || value == null)
        //    {
        //        value = Enumerable.Repeat(NullValue.Length > 0 ? NullValue : string.Empty, n).ToArray();
        //    }

        //    return value.ToArray();
        //}

        public virtual string Generate(Faker fkr, int n, string q = "", string NullValue = "Null")
        {
            string? value = null;
            try
            {

                if (EBFld == EBFieldType.Hash)
                {
                    value = (q + fkr.Random.Hash(40).ToString() + q).OrDefault(fkr, Nulls, NullValue);
                }
                else if (EBFld == EBFieldType.BoolDB)
                {
                    value = fkr.PickRandom(1, 0).ToString().OrDefault(fkr, Nulls, NullValue);
                }
                else if (EBFld == EBFieldType.Bool)
                {
                    value = fkr.Random.Bool().ToString().OrDefault(fkr, Nulls, NullValue);
                }
                else if (EBCat != null && EBFld != null)
                {
                    string parseStr = q + "{{" + $"{EBCat?.ToString().ToLower()}.{EBFld?.ToString().ToLower()}" + "}}" + q;

                    value = fkr.Parse(parseStr).OrDefault(fkr, Nulls, NullValue).ToString();
                }
            }
            catch (Exception e)
            {
                if (e.Message.StartsWith("Unknown method"))
                {
                    ErrorHandler.ShowMessage($"El idioma actualmente seleccionado no soporta el tipo de dato {FieldTypes.Types.FirstOrDefault(p => p.Value.BName == EBFld).Value.SearchName}");
                }
                else
                {
                    ErrorHandler.ShowMessage("Ha ocurrido un error inesperado.", MessageType.error);
                }
            }

            if (value == null)
            {
                value = "";
            }

            return value;
        }

        public void ResetCount()
        {
            Value = 1;
        }
    }

    /// <summary>
    /// Opciones para tipo de campo numero de linea.
    /// </summary>
    class RowNumberOptionsType : BaseOptionsType
    {
        //public override string[] Generate(Faker fkr, int n, string q = "", string NullValue = "Null")
        //{
        //    int Value = 1;
        //    string[] a = new string[n];

        //    if (Nulls == 0)
        //    {
        //        var arr = Enumerable.Range(1, n).ToArray();
        //        a = Array.ConvertAll(arr, b => b.ToString());
        //    }
        //    else
        //    {
        //        for (int b = 0; b < a.Length; b++)
        //        {
        //            if (fkr.PickRandom(true, false).OrDefault(fkr, Nulls, false))
        //            {
        //                a[b] = Value.ToString();
        //            }
        //            else
        //            {
        //                a[b] = NullValue;
        //            }

        //            Value++;
        //        }
        //    }

        //    return a;
        //}
        public override string Generate(Faker fkr, int n, string q = "", string NullValue = "Null")
        {
            //int Value = 1;

            string a = "";

            if (Nulls == 0)
            {
                a = Value.ToString();
            }
            else
            {
                if (fkr.PickRandom(true, false).OrDefault(fkr, Nulls, false))
                {
                    a = Value.ToString();
                }
                else
                {
                    a = NullValue;
                }

            }

            Value++;

            return a;
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

        //public override string[] Generate(Faker fkr, int n, string q = "", string NullValue = "Null")
        //{
        //    List<string> result = Enumerable.Range(1, n)
        //        .Select(_ => q + fkr.Date.Between(DTFrom.Value, DTTo.Value).ToString(SelectedFormat).OrDefault(fkr, Nulls, NullValue) + q)
        //        .ToList();

        //    if (Nulls > 0)
        //    {
        //        //Quitar las comillas de los valore nulos.
        //        if (q != "")
        //        {
        //            result = result.ConvertAll(p => p == $"{q}{NullValue}{q}" ? "Null" : p);
        //        }
        //    }

        //    return result.ToArray();
        //}

        public override string Generate(Faker fkr, int n, string q = "", string NullValue = "Null")
        {
            string result = (q + fkr.Date.Between(DTFrom.Value, DTTo.Value).ToString(SelectedFormat) + q).OrDefault(fkr, Nulls, NullValue);

            if (Nulls > 0)
            {
                //Quitar las comillas de los valore nulos.
                if (q != "")
                {
                    result = result == $"{q}{NullValue}{q}" ? "Null" : result;
                }
            }

            return result;
        }
    }

    class OptionsNumberType : BaseOptionsType
    {
        TextBox? TBMin;
        TextBox? TBMax;
        TextBox? TBDec;
        private int Min
        {
            get
            {
                int tmp = 1;
                _ = int.TryParse(TBMin?.Text, out tmp);
                if (TBMin != null)
                {
                    TBMin.Text = tmp.ToString();
                }
                return tmp;
            }
        }
        private int Max
        {
            get
            {
                int tmp = 100;
                _ = int.TryParse(TBMax?.Text, out tmp);
                if (TBMax != null)
                {
                    TBMax.Text = tmp.ToString();
                }
                return tmp;
            }
        }
        private int Dec
        {
            get
            {
                _ = int.TryParse(TBDec?.Text, out int tmp);
                if (TBDec != null)
                {
                    TBDec.Text = tmp.ToString();
                }
                return tmp;
            }
        }

        private EBCategory EBCat;
        private EBFieldType EBFld;

        public OptionsNumberType(EBCategory ebcat, EBFieldType ebfld)
        {
            EBCat = ebcat;
            EBFld = ebfld;

            if (EBFld == EBFieldType.Number)
            {
                Label lblMin = new Label_("Min");
                TBMin = new TextBox { Width = 70, Text = "1", MaxLength = 20 };
                Label lblMax = new Label_("Max");
                TBMax = new TextBox { Width = 70, Text = "100", MaxLength = 20 };
                Label lblDec = new Label_("Decimales");
                TBDec = new TextBox { Width = 20, Text = "0", MaxLength = 1 };

                panelControls.InsertRange(0, new Control[] { lblMin, TBMin, lblMax, TBMax, lblDec, TBDec });
            }
        }

        //public override string[] Generate(Faker fkr, int n, string q = "", string NullValue = "Null")
        //{
        //    string q_ = q;

        //    if (!Settings.Default.QuotesInNumbers)
        //    {
        //        q_ = "";
        //    }

        //    IEnumerable<string> values;

        //    if (EBFld == EBFieldType.Number)
        //    {
        //        values = Enumerable.Range(1, n)
        //            .Select(_ => (q_ + Math.Round(fkr.Random.Float(Min, Max), Dec).ToString() + q_).OrDefault(fkr, Nulls, NullValue));
        //    }
        //    else
        //    {
        //        values = Enumerable.Range(1, n)
        //            .Select(_ => fkr.Parse(q_ + "{{" + $"{EBCat}.{EBFld}" + "}}" + q_).ToString().OrDefault(fkr, Nulls, NullValue));
        //    }

        //    return values.ToArray();
        //}

        public override string Generate(Faker fkr, int n, string q = "", string NullValue = "Null")
        {
            string q_ = q;

            if (!Settings.Default.QuotesInNumbers)
            {
                q_ = "";
            }

            string values;

            if (EBFld == EBFieldType.Number)
            {
                values = (q_ + Math.Round(fkr.Random.Float(Min, Max), Dec).ToString() + q_).OrDefault(fkr, Nulls, NullValue);
            }
            else
            {
                values = fkr.Parse(q_ + "{{" + $"{EBCat}.{EBFld}" + "}}" + q_).ToString().OrDefault(fkr, Nulls, NullValue);
            }

            return values;
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
        public void ResetCount();
    }
}
