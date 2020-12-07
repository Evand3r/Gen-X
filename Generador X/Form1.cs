using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Generador_X.Controls;

namespace Generador_X
{
    public partial class MainView : Form
    {
        /// <summary>
        /// Campo seleccionado actuallmente.
        /// </summary>
        Control FocusedControl = null;
        private readonly Random rand = new Random();
        /// <summary>
        /// Tamaño de los campos
        /// </summary>
        int WidthOffSet = 20;

        public MainView()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (FocusedControl != null)
                {
                    StackedPanel.Controls.SetChildIndex(
                        FocusedControl,
                        StackedPanel.Controls.GetChildIndex(FocusedControl) - 1);
                    StackedPanel.ScrollControlIntoView(FocusedControl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (FocusedControl != null)
                {
                    StackedPanel.Controls.SetChildIndex(
                        FocusedControl,
                        StackedPanel.Controls.GetChildIndex(FocusedControl) + 1
                        );
                    StackedPanel.ScrollControlIntoView(FocusedControl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void Panel_Click(object sender, EventArgs e)
        {
            if (FocusedControl == sender)
            {
                //Deseleccionar el control.
                FocusedControl = null;
                (sender as Control).Invalidate();
            }
            else
            {
                //Seleccionar el control.
                if (FocusedControl != null)
                {
                    FocusedControl.Invalidate();
                }

                FocusedControl = sender as Control;
                FocusedControl.Invalidate();
            }
        }

        private void Style_Selected(object sender, PaintEventArgs e)
        {
            //Marcar control como seleccionado.
            if (sender == FocusedControl)
            {
                Color col = Color.DarkBlue;
                ButtonBorderStyle bbs = ButtonBorderStyle.Solid;
                int ancho = 4;

                ControlPaint.DrawBorder(e.Graphics, this.FocusedControl.ClientRectangle, col, ancho, bbs,
                                                                                col, ancho, bbs,
                                                                                col, ancho, bbs,
                                                                                col, ancho, bbs);
            }
        }

        private void BttnAddField_Click(object sender, EventArgs e)
        {
            int indx;

            FieldsTypeSelect fts = new FieldsTypeSelect();
            var result = fts.ShowDialog();

            if(result == DialogResult.OK)
            {
                FieldPanel p = new FieldPanel(StackedPanel, fts.Type);

                p.Paint += new PaintEventHandler(Style_Selected);
                p.Click += new EventHandler(Panel_Click);
                //Añadir evento para boton de eliminar.
                p.MouseDoubleClick += new MouseEventHandler((object o, MouseEventArgs e) => { FocusedControl = null; p.Dispose(); });

                StackedPanel.Controls.Add(p);

                if (FocusedControl != null)
                {
                    indx = StackedPanel.Controls.IndexOf(FocusedControl);
                    StackedPanel.Controls.SetChildIndex(p, indx + 1);
                }

                StackedPanel.ScrollControlIntoView(p);
            }
        }

        private void StackedPanel_Resize(object sender, EventArgs e)
        {
            //Mantener el diseño en caso de cambio de tamaño del formulario.
            if (StackedPanel.Controls.Count > 0)
            {
                foreach (Control c in StackedPanel.Controls)
                {
                    c.Width = StackedPanel.Width - WidthOffSet;
                }

                if (FocusedControl != null)
                {
                    FocusedControl.Invalidate();
                }
            }
        }

        private void RoundedButton1_Click(object sender, EventArgs e)
        {
            foreach(FieldPanel fp in StackedPanel.Controls)
            {
                if(fp is FieldPanel)
                {
                    
                }
            }
        }
    }
}
