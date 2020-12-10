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
    class BaseOptionsType : IOptions<string[]>
    {
        public string value;
        public Faker fkr = new Faker();
        public Label lblBlanks = new Label_("Nulos");
        public readonly TextBox NullsCount = new TextBox
        {
            Width = 50,
            Anchor = AnchorStyles.Right,
            Text = "0",
            RightToLeft = RightToLeft.Yes,
            MaxLength = 2,
        };
        public List<Control> panelControls = new List<Control>();

        //Cantidad de campos nulos, tomar de NullsCount TextBox
        public float Nulls
        {
            get
            {
                _ = int.TryParse(NullsCount.Text, out int tmp);
                NullsCount.Text = tmp.ToString();
                return (tmp % 99) / 100f;
            }

        }

        public BaseOptionsType()
        {
            panelControls.AddRange(new Control[] { lblBlanks, NullsCount });
        }

        public virtual string[] Generate(int d)
        {
            return Enumerable.Repeat(string.Empty, d).ToArray();
        }
    }

    class RowNumberOptionsType : BaseOptionsType
    {
        int Value = 1;

        public override string[] Generate(int d)
        {
            int?[] a = new int?[d];

            if (Nulls == 0)
            {
                var arr = Enumerable.Range(1, d).ToArray();
                a = Array.ConvertAll(arr, b => (int?)b);
            }
            else
            {

                for (int b = 0; b < a.Length; b++)
                {
                    if (fkr.PickRandom(true, false).OrDefault(fkr, Nulls / 100, false))
                    {
                        a[b] = Value;
                    }

                    Value++;
                }
            }

            return Array.ConvertAll(a, b => b.ToString());
        }
    }

    class OptionsName : BaseOptionsType
    {
        readonly EBFieldType FieldType;

        public OptionsName(EBFieldType fld)
        {
            FieldType = fld;
        }

        public override string?[] Generate(int d)
        {
            return Enumerable.Range(1, d)
                .Select(_ => fkr.Parse("{{Name." + $"{(EBFieldType)FieldType}" + "}}").OrNull(fkr, Nulls))
                .ToArray();
        }

    }

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

        public override string[] Generate(int d)
        {
            return Enumerable.Range(1, d)
                .Select(_ => fkr.Date.Between(DTFrom.Value, DTTo.Value).ToString(SelectedFormat).OrNull(fkr, Nulls))
                .ToArray();
        }
    }

    public interface IOptions<T>
    {
        public T Generate(int d);
    }
}
