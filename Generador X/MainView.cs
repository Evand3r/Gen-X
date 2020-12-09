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
using Generador_X.Controls.ModifiedControls;
using Generador_X.Model;

namespace Generador_X
{
    public partial class MainView : Form
    {
        /// <summary>
        /// Campo seleccionado actuallmente.
        /// </summary>
        Control FocusedControl = null;

        /// <summary>
        /// Tamaño de los campos
        /// </summary>
        readonly int WidthOffSet = 20;

        public MainView()
        {
            InitializeComponent();

            //Seleccionar formato SQL
            CBFormatoSalida.SelectedIndex = 0;
            CreateDefaultFields();
        }

        private void BtnSubir_Click(object sender, EventArgs e)
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

        private void BtnBajar_Click(object sender, EventArgs e)
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

            if (result == DialogResult.OK)
            {
                StackedPanel.SuspendLayout();

                FieldPanel p = CreateField(fts.Type);

                StackedPanel.Controls.Add(p);

                if (FocusedControl != null)
                {
                    indx = StackedPanel.Controls.IndexOf(FocusedControl);
                    StackedPanel.Controls.SetChildIndex(p, indx + 1);
                }

                StackedPanel.ScrollControlIntoView(p);
                StackedPanel.ResumeLayout();
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

        public void ChangeField(object sender, EventArgs e)
        {
            int indx;
            FieldPanel prevField = (sender as Button).Parent as FieldPanel;

            FieldsTypeSelect fts = new FieldsTypeSelect();
            var result = fts.ShowDialog();

            if (result == DialogResult.OK && prevField.FieldType.BName != fts.Type.BName)
            {
                StackedPanel.SuspendLayout();

                indx = StackedPanel.Controls.IndexOf((sender as Button).Parent);

                FieldPanel p = CreateField(fts.Type, prevField.TBFieldName.Text);

                StackedPanel.Controls.RemoveAt(indx);
                StackedPanel.Controls.Add(p);
                StackedPanel.Controls.SetChildIndex(p, indx);
                StackedPanel.ResumeLayout();
            }
        }

        private void BTNGenerar_Click(object sender, EventArgs e)
        {
            HashSet<string> columnNames = new HashSet<string>();
            uint numFilas;

            foreach (Control fp in StackedPanel.Controls)
            {
                if (fp is FieldPanel)
                {
                    FieldPanel p = fp as FieldPanel;

                    columnNames.Add(p.TBFieldName.Text);

                    //Verificar valores nulos
                    if(!uint.TryParse(p.OptionsPanel.NullsCount.Text, out numFilas))
                    {
                        ErrorHandler.ShowMessage($"El campo 'Nulos' es inválido en la columna '{p.TBFieldName.Text}'", MessageType.error);
                        return;
                    }
                }
            }

            //Validar que las columnas no sean iguales.
            if (StackedPanel.Controls.Count - 1 > columnNames.Count)
            {
                ErrorHandler.ShowMessage("Los nombres de las columnas no pueden repetirse.", MessageType.error);
                return;
            }

            //Validar que el numero de fila es integer.
            if (!uint.TryParse(TBNumFilas.Text, out numFilas))
            {
                ErrorHandler.ShowMessage("El numero de filas no es válido.", MessageType.error);
                return;
            }



        }

        private void BTNPreview_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Estoy Aqui");
        }

        private void CBFormatoSalida_SelectedIndexChanged(object sender, EventArgs e)
        {
            PanelFormatoOpciones.SuspendLayout();
            PanelFormatoOpciones.Controls.Clear();

            List<Control> opciones = new List<Control>();

            switch (CBFormatoSalida.SelectedIndex)
            {
                case 0: //SQL
                    Label lbl = new Label_("Nombre de la Tabla");
                    TextBox tbxTableName = new TextBox { Width = 120, Text = "GEN_X" };
                    CheckBox ckbxCreateTable = new CheckBox { Text = "Incluir crear tabla", AutoSize = true };
                    opciones.AddRange(new Control[] { lbl, tbxTableName, ckbxCreateTable });
                    break;
                default:
                    break;
            }

            PanelFormatoOpciones.Controls.AddRange(opciones.ToArray());
            PanelFormatoOpciones.ResumeLayout();
        }

        private void CreateDefaultFields()
        {
            StackedPanel.SuspendLayout();

            StackedPanel.Controls.AddRange(new Control[] {
                CreateField(FieldTypes.Types[EFieldTypes.id]),
                CreateField(FieldTypes.Types[EFieldTypes.FirstName]),
                CreateField(FieldTypes.Types[EFieldTypes.Date]),
                CreateField(FieldTypes.Types[EFieldTypes.FullName]),
            });
            StackedPanel.ResumeLayout();
        }

        private FieldPanel CreateField(FieldType type, string name = "")
        {
            FieldPanel p = new FieldPanel(StackedPanel, type, name);

            p.Paint += new PaintEventHandler(Style_Selected);
            p.Click += new EventHandler(Panel_Click);
            //Añadir evento para boton de eliminar.
            p.MouseDoubleClick += new MouseEventHandler((object o, MouseEventArgs e) => { FocusedControl = null; p.Dispose(); });

            return p;
        }
    }
}
