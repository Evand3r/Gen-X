using Generador_X.Model;
using Generador_X.Model.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Generador_X.Controls
{
    class FieldSelect : Panel
    {
        public string FName;
        public string CName;

        /// <summary>
        /// Componente para seleccionar un tipo de campo de la lista de tipos de campos.
        /// </summary>
        /// <param name="field">El objeto de tipo de campo.</param>
        /// <param name="fn">La funcion para el evento Clic.</param>
        public FieldSelect(FieldType field, EventHandler fn)
        {
            Label labelExmples = new Label
            {
                Text = field.Example,
                AutoSize = true,
                Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point),
                Location = new Point(-1, 38),
            };

            Label labelTitle = new Label
            {
                Text = field.SearchName.ToString().Replace("_", " "),
                AutoSize = true,
                Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point),
                Location = new Point(-1, -1),
            };

            FName = field.SearchName.ToString().Replace("_", " ").ToLower();
            CName = field.SearchCategoryName.ToString().Replace("_", " ");

            BorderStyle = BorderStyle.FixedSingle;
            Cursor = Cursors.Hand;
            BackColor = Color.White;
            Location = new Point(5, 5);
            Margin = new Padding(5);
            Size = new Size(200, 134);
            Tag = field;
            Controls.AddRange(new Control[] { labelTitle, labelExmples });
            Click += new EventHandler(fn);
        }
    }
}
