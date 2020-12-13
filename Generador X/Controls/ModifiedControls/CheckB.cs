using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Generador_X.Controls.ModifiedControls
{
    class CheckB_ : CheckBox
    {
        public CheckB_(string name, string text, bool checkedState = false, bool autosize = true)
        {
            Name = name;
            Text = text;
            AutoSize = autosize;
            Margin = new Padding(0, 5, 0, 5);
            Checked = checkedState;
        }
    }
}
