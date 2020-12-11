using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Generador_X.Controls.ModifiedControls
{
    class Label_ : Label
    {
        /// <summary>
        /// Clase simple para crear labels que se adapten
        /// al tamaño del texto.
        /// </summary>
        /// <param name="text"></param>
        public Label_(string text)
        {
            Text = text;
            AutoSize = true;
            Margin = new Padding(Margin.Left, 5, Margin.Right, Margin.Bottom);
        }
    }
}
