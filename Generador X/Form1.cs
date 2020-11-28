using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generador_X
{
    public partial class Form1 : Form
    {
        Control focus = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (focus != null)
                {
                    flowLayoutPanel2.Controls.SetChildIndex(
                        focus,
                        flowLayoutPanel2.Controls.GetChildIndex(focus) - 1
                        );
                }
            }
            catch (Exception ex)
            {
                //lol
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (focus != null)
                {
                    flowLayoutPanel2.Controls.SetChildIndex(
                        focus,
                        flowLayoutPanel2.Controls.GetChildIndex(focus) + 1
                        );
                }
            }
            catch (Exception ex)
            {
                //lol
            }
        }

        private void panel_Click(object sender, EventArgs e)
        {
            if (focus != null)
            {
                focus.Invalidate();
            }

            focus = sender as Control;
            focus.Invalidate();
        }

        private void style_Selected(object sender, PaintEventArgs e)
        {
            if (sender == focus)
            {
                Color col = Color.DarkBlue;
                ButtonBorderStyle bbs = ButtonBorderStyle.Solid;
                int ancho = 4;

                ControlPaint.DrawBorder(e.Graphics, this.focus.ClientRectangle, col, ancho, bbs,
                                                                                col, ancho, bbs,
                                                                                col, ancho, bbs,
                                                                                col, ancho, bbs);
            }
        }

        private void BttnAddField_Click(object sender, EventArgs e)
        {
            // Mostrar modal con los diferentes tipos de campos.
            // Al elegir, scroll layoutpanel2 hasta el fondo
        }
    }
}
