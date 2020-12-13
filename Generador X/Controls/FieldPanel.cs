using System;
using System.Collections.Generic;
using System.Drawing;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using Generador_X.Model;
using Generador_X.Model.Enums;
using Generador_X.Properties;

namespace Generador_X.Controls
{
    class FieldPanel : Panel
    {
        public string FieldName
        {
            get { return TBFieldName.Text.Trim(); }
            set { TBFieldName.Text = value; }
        }
        public FieldType FieldType;
        public EBCategory FieldCategory;
        public readonly TextBox TBFieldName;
        public readonly OptionsPanel OptionsPanel;

        private readonly Button SelectType;
        private readonly PictureBox RemoveSelf;

        public FieldPanel(FlowLayoutPanel parent, FieldType fType, string fName = "")
        {
            MainView mainview = parent.Parent as MainView;
            Size = new Size(parent.Width - 10, 50);
            BorderStyle = BorderStyle.FixedSingle;
            Padding = new Padding(4);
            BackColor = Color.Gainsboro;
            Cursor = Cursors.Hand;

            Panel ConstantPanel = new Panel
            {
                MaximumSize = new Size(370, 42),
                MinimumSize = new Size(370, 0),
                Dock = DockStyle.Left,
                Padding = new Padding(0),
                Cursor = Cursors.Hand,
            };

            FieldType = fType;
            FieldCategory = fType.BCategoryName;


            ResourceManager resources = Resources.ResourceManager;

            //Texbox de nombre del campo.
            TBFieldName = new TextBox
            {
                Width = 170,
                Location = new Point(10, 9),
            };

            //En caso de que se modifique el tipo de campo, conservar el
            //nombre que tenia anteriormente.
            if (fName != "")
            {
                FieldName = fName;
            }
            else
            {
                FieldName = fType.ColumName.ToLower();
            }

            //Boton para seleccionar el tipo de campo.
            SelectType = new Button
            {
                Cursor = Cursors.Hand,
                Location = new Point(211, 8),
                Text = fType.SearchName.ToString(),
                TextAlign = ContentAlignment.MiddleLeft,
                Image = (Bitmap)resources.GetObject("Open Folder_50px"),
                ImageAlign = ContentAlignment.MiddleRight,
                Size = new Size(140, 23),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.White,
            };

            //Añadir evento de cambiar tipo de campo.
            SelectType.Click += new EventHandler(mainview.ChangeField);
            ConstantPanel.Controls.AddRange(new Control[] { TBFieldName, SelectType });

            //Panel de opciones del campo.
            OptionsPanel = new OptionsPanel(FieldType);

            //Añadir evento para que se seleccione el campo
            ConstantPanel.Click += new EventHandler((object o, EventArgs e) => OnClick(e));
            OptionsPanel.Click += new EventHandler((object o, EventArgs e) => OnClick(e));

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
                Location = new Point(parent.Width - 53, 5),
                Dock = DockStyle.Right,
            };

            RemoveSelf.Click += new EventHandler((object o, EventArgs e) => { (parent.Parent as MainView).RemoveField(this, e); });

            Controls.AddRange(new Control[] { OptionsPanel, RemoveSelf, ConstantPanel, });
        }
    }
}
