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
        private readonly TextBox TBFieldName;
        private readonly Button SelectType;
        private readonly Panel OptionsPanel;
        private readonly PictureBox RemoveSelf;

        public FieldPanel(FlowLayoutPanel parent, string FieldName, string TypeName)
        {
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
                Text = TypeName,
                TextAlign = ContentAlignment.MiddleLeft,
                Image = (Bitmap)resources.GetObject("Open Folder_50px"),
                ImageAlign = ContentAlignment.MiddleRight,
                Size = new Size(120, 23),
            };

            //Panel de opciones del campo.
            OptionsPanel = new Panel
            {
                Location = new Point(385, 0),
                Size = new Size(339, 50),
                BorderStyle = BorderStyle.FixedSingle,
            };
            //OptionsPanel.Controls.Add(otions);

            //Boton de elimiar el campo.
            RemoveSelf = new PictureBox
            {
                Cursor = Cursors.Hand,
                Width = 40,
                Height = 40,
                Anchor = (AnchorStyles.Top | AnchorStyles.Right),
                BackgroundImageLayout = ImageLayout.Zoom,
                BackgroundImage = (Bitmap)resources.GetObject("Cancel_48px"),
                Margin = new Padding(5),
                Location = new Point(732, 5)
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
