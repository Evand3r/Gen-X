using System;
using System.Collections.Generic;
using System.Drawing;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using Generador_X.Model;
using Generador_X.Properties;

namespace Generador_X.Controls
{
    class FieldPanel : Panel, IFieldBase
    {
        public string FieldName;
        public FieldType FieldType;
        public string FieldCategory;
        public readonly TextBox TBFieldName;
        public readonly OptionsPanel OptionsPanel;

        private readonly Button SelectType;
        private readonly PictureBox RemoveSelf;

        public FieldPanel(FlowLayoutPanel parent, FieldType fType, string fName = "")
        {
            if (fName != "")
            {
                FieldName = fName;
            }
            else
            {
                FieldName = fType.columnName;
            }

            FieldType = fType;
            FieldCategory = fType.BCategoryName;

            Size = new Size(parent.Width - 10, 50);
            MinimumSize = new Size(775, 50);
            BorderStyle = BorderStyle.FixedSingle;

            ResourceManager resources = Resources.ResourceManager;

            //Texbox de nombre del campo.
            TBFieldName = new TextBox
            {
                Width = 170,
                Location = new Point(15, 15),
                Text = FieldName,
            };

            //Boton para seleccionar el tipo de campo.
            SelectType = new Button
            {
                Cursor = Cursors.Hand,
                Location = new Point(215, 15),
                Text = fType.SearchName,
                TextAlign = ContentAlignment.MiddleLeft,
                Image = (Bitmap)resources.GetObject("Open Folder_50px"),
                ImageAlign = ContentAlignment.MiddleRight,
                Size = new Size(120, 23),
            };

            //Añadir evento de cambiar tipo de campo.
            SelectType.Click += new EventHandler((parent.Parent as MainView).ChangeField);

            //Panel de opciones del campo.
            OptionsPanel = new OptionsPanel(FieldType);

            //Boton de elimiar el campo.
            RemoveSelf = new PictureBox
            {
                Cursor = Cursors.Hand,
                Width = 40,
                Height = 40,
                Anchor = AnchorStyles.Right,
                BackgroundImageLayout = ImageLayout.Zoom,
                BackgroundImage = (Bitmap)resources.GetObject("Cancel_48px"),
                Margin = new Padding(5),
                Location = new Point(parent.Width - 53, 5)
            };

            RemoveSelf.Click += new EventHandler(Remove);

            //Añadir en este orden.
            Controls.Add(RemoveSelf);
            Controls.Add(OptionsPanel);
            Controls.Add(SelectType);
            Controls.Add(TBFieldName);
        }

        /// <summary>
        /// Elimiar campo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Remove(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
