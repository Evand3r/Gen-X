using Generador_X.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Generador_X.Controls
{
    class FieldSelect : Panel
    {
        /// <summary>
        /// Componente para seleccionar un tipo de campo de la lista de tipos de campos.
        /// </summary>
        /// <param name="field">El objeto de tipo de campo.</param>
        /// <param name="fn">La funcion para el evento Clic.</param>
        public FieldSelect(FieldType field, EventHandler fn)
        {
            Label labelExmples = new Label
            {
                AutoSize = true,
                Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                Location = new System.Drawing.Point(-1, 38),
                Text = field.Example,
            };

            Label labelTitle = new Label
            {
                Text = field.fName,
                AutoSize = true,
                Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point),
                Location = new System.Drawing.Point(-1, -1),
            };

            BorderStyle = BorderStyle.FixedSingle;
            Cursor = Cursors.Hand;
            Location = new System.Drawing.Point(5, 5);
            Margin = new Padding(5);
            Size = new System.Drawing.Size(200, 134);
            Tag = field;
            Controls.AddRange(new Control[] { labelTitle, labelExmples });
            Click += new EventHandler(fn);
        }
    }
}
