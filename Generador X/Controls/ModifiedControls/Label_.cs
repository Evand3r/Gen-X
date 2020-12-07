using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Generador_X.Controls.ModifiedControls
{
    class Label_ : Label
    {
        public Label_(string text)
        {
            Text = text;
            AutoSize = true;
            Margin = new Padding(Margin.Left, 5, Margin.Right, Margin.Bottom);
        }
    }
}
