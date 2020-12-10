using Generador_X.Model.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Generador_X.Controls.ModifiedControls
{
    class DateTimePick_: DateTimePicker
    {

        public DateTimePick_(DateTime valor)
        {
            Size = new Size(85,23);
            Value = valor;
            Format = DateTimePickerFormat.Short;
        }
    }
}
