using Bogus;
using Generador_X.Controls.ModifiedControls;
using Generador_X.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Generador_X.Model
{
    class OptionsPanel : FlowLayoutPanel
    {
        public FieldType ftype;
        public BaseOptionsType Options;
        public string Nulls;

        public OptionsPanel(FieldType fieldType)
        {
            Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Location = new Point(384, 5);
            Size = new Size(339, 38);
            //BorderStyle = BorderStyle.FixedSingle;
            Padding = new Padding(4);

            ftype = fieldType;

            SuspendLayout();
            Options = CreateOptions(ftype.SearchName);
            Nulls = Options.NullsCount.Text;
            Controls.AddRange(Options.panelControls.ToArray());

            ResumeLayout(false);
        }

        private BaseOptionsType CreateOptions(string type)
        {
            if (type == "Fecha")
            {
                return new OptionsDateType();
            }
            //if (type == "")

            return new BaseOptionsType();
        }

    }

    class BaseOptionsType : IOptions<string>
    {
        public Faker fkr = new Faker();
        public Label lblBlanks = new Label_("Nulos");
        public TextBox NullsCount = new TextBox
        {
            Width = 50,
            Anchor = AnchorStyles.Right,
            Text = "0",
            RightToLeft = RightToLeft.Yes,
        };
        public List<Control> panelControls = new List<Control>();

        public BaseOptionsType()
        {
            panelControls.AddRange(new Control[] { lblBlanks, NullsCount });
        }

        public virtual string Generate()
        {
            MessageBox.Show("aaa");
            return "";
        }
    }

    class OptionsDateType : BaseOptionsType, IOptions<string>
    {
        DateTimePick_ DTFrom = new DateTimePick_(DateTime.Now.AddYears(-1));
        DateTimePick_ DTTo = new DateTimePick_(DateTime.Now);
        Label lblto = new Label_("hasta");

        public OptionsDateType()
        {
            panelControls.InsertRange(0, new Control[] { DTFrom, lblto, DTTo });
        }

        public override string Generate()
        {
            MessageBox.Show("bbb");
            return fkr.Date.Between(DTFrom.Value, DTTo.Value).ToString();
        }

        public string[] Generate(int d)
        {
            string[] aa = Enumerable.Range(1, d)
                .Select(_ => fkr.Date.Between(DTFrom.Value, DTTo.Value).ToString())
                .ToArray();
            return aa;
        }
    }

    public interface IOptions<T>
    {
        public T Generate();
    }
}
