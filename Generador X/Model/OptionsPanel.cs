using Generador_X.Controls.ModifiedControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Generador_X.Model
{
    class OptionsPanel : FlowLayoutPanel
    {
        public OptionsPanel(FieldType fieldType)
        {
            Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Location = new Point(384, 3);
            Size = new Size(339, 43);
            //BorderStyle = BorderStyle.FixedSingle;
            Padding = new Padding(6);
            List<Control> panelControls = new List<Control>();

            SuspendLayout();

            switch (fieldType.fName)
            {
                case "Fecha":
                    DateTimePick_ DTFrom = new DateTimePick_(DateTime.Now.AddYears(-1));
                    DateTimePick_ DTTo = new DateTimePick_(DateTime.Now);
                    Label lblto = new Label_("hasta");
                    //ComboBox dateFormat = new ComboBox { Items = {""}}
                    //Añadir controles
                    panelControls.AddRange(new Control[] { DTFrom, lblto, DTTo });
                    break;
                default:
                    Label lblBlanks = new Label_("Nulos");
                    NumericUpDown NullsCount = new NumericUpDown
                    {
                        Width = 50,
                        DecimalPlaces = 0,
                        Anchor = AnchorStyles.Right,
                    };
                    NullsCount.Controls.RemoveAt(0);
                    panelControls.AddRange(new Control[] { lblBlanks, NullsCount });
                    break;
            }

            if (panelControls.Count != 0)
            {
                Controls.AddRange(panelControls.ToArray());
            }

            ResumeLayout(false);
        }
    }
}
