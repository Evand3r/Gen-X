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
using Generador_X.Model.Enums;

namespace Generador_X
{
    public partial class MainView : Form
    {
        /// <summary>
        /// Campo seleccionado actuallmente.
        /// </summary>
        private Control FocusedControl = null;
        /// <summary>
        /// Lista de campos.
        /// </summary>
        private List<FieldPanel> FieldPanels = new List<FieldPanel>();
        private uint NumFilas;

        /// <summary>
        /// Tamaño de los campos
        /// </summary>
        readonly int WidthOffSet = 20;

        public MainView()
        {
            InitializeComponent();

            //Seleccionar formato SQL
            CreateDefaultFields();

            CBFormatoSalida.DataSource = Enum.GetValues(typeof(EOutputFormat));
            CBFormatoSalida.SelectedIndex = 0;
        }

        /// <summary>
        /// Subir campo seleccionado una posicion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Bajar campo seleccionado una posicion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Añadir estilos al campo seleccionado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Style_Selected(object sender, PaintEventArgs e)
        {
            //Marcar control como seleccionado.
            if (sender == FocusedControl)
            {
                Color col = Color.DarkBlue;
                ButtonBorderStyle bbs = ButtonBorderStyle.Solid;
                int ancho = 4;

                ControlPaint.DrawBorder(e.Graphics, FocusedControl.ClientRectangle, col, ancho, bbs,
                                                                                col, ancho, bbs,
                                                                                col, ancho, bbs,
                                                                                col, ancho, bbs);
            }
        }

        /// <summary>
        /// Adaptar el ancho de los campos al del flowlayout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Añadir nuevo campo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Cambiar tipo de campo del campo seleccionado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ChangeField(object sender, EventArgs e)
        {
            int indx;
            FieldPanel prevField = ((sender as Button).Parent as Panel).Parent as FieldPanel;

            FieldsTypeSelect fts = new FieldsTypeSelect();
            var result = fts.ShowDialog();

            if (result == DialogResult.OK && prevField.FieldType.BName != fts.Type.BName)
            {
                StackedPanel.SuspendLayout();

                indx = StackedPanel.Controls.IndexOf(prevField);

                FieldPanel p = CreateField(fts.Type, prevField.TBFieldName.Text);

                StackedPanel.Controls.RemoveAt(indx);
                StackedPanel.Controls.Add(p);
                StackedPanel.Controls.SetChildIndex(p, indx);
                StackedPanel.ResumeLayout();
            }
        }

        /// <summary>
        /// Generar datos de las columnas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTNGenerar_Click(object sender, EventArgs e)
        {

            if (ValidateFields())
            {
                Generador Gen = new Generador(FieldPanels.ToArray(), (EOutputFormat)CBFormatoSalida.SelectedIndex, NumFilas, PanelFormatoOpciones);
                Gen.Generate();
            }
        }

        private void BTNPreview_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                Generador Gen = new Generador(FieldPanels.ToArray(), (EOutputFormat)CBFormatoSalida.SelectedIndex, NumFilas, PanelFormatoOpciones);
                Gen.Generate(true);
            }
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
                    TextBox tbxTableName = new TextBox { Name = "TableName", Width = 120, Text = "GEN_X" };
                    CheckBox ckbxCreateTable = new CheckBox { Name = "CreateTableCkBx", Text = "Incluir crear tabla", AutoSize = true };
                    opciones.AddRange(new Control[] { lbl, tbxTableName, ckbxCreateTable });
                    break;
                default:
                    break;
            }

            PanelFormatoOpciones.Controls.AddRange(opciones.ToArray());
            PanelFormatoOpciones.ResumeLayout();
        }

        /// <summary>
        /// Crear los campos por defecto al iniciar el programa.
        /// </summary>
        private void CreateDefaultFields()
        {
            StackedPanel.SuspendLayout();

            StackedPanel.Controls.AddRange(new Control[] {
                CreateField(FieldTypes.Types[EFieldName.Numero_Fila]),
                CreateField(FieldTypes.Types[EFieldName.Primer_Nombre]),
                CreateField(FieldTypes.Types[EFieldName.Fecha]),
                CreateField(FieldTypes.Types[EFieldName.Nombre_Completo]),
            });
            StackedPanel.ResumeLayout();
        }

        /// <summary>
        /// Crear campo con el texto de nombre.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        private FieldPanel CreateField(FieldType type, string name = "")
        {
            FieldPanel p = new FieldPanel(StackedPanel, type, name);

            p.Paint += new PaintEventHandler(Style_Selected);
            p.Click += new EventHandler(Panel_Click);
            //Añadir evento para boton de eliminar.
            p.MouseDoubleClick += new MouseEventHandler((object o, MouseEventArgs e) => { FocusedControl = null; p.Dispose(); });

            return p;
        }

        /// <summary>
        /// Validar campos listados.
        /// </summary>
        /// <returns></returns>
        private bool ValidateFields()
        {
            HashSet<string> columnNames = new HashSet<string>();
            FieldPanels.Clear();
            //TODO: pasar de 2 a 1 una vez terminado la fase de diseño de la interfaz.
            if(StackedPanel.Controls.Count < 2)
            {
                return false;
            }

            foreach (Control fp in StackedPanel.Controls)
            {
                if (fp is FieldPanel)
                {
                    FieldPanel p = fp as FieldPanel;
                    //Añadir el panel a la lista
                    FieldPanels.Add(p);

                    columnNames.Add(p.TBFieldName.Text);

                    //Verificar valores nulos
                    if (!uint.TryParse(p.OptionsPanel.Nulls, out NumFilas))
                    {
                        ErrorHandler.ShowMessage($"El campo 'Nulos' es inválido en la columna '{p.TBFieldName.Text}'", MessageType.error);
                        return false;
                    }
                }
            }

            //Validar que los nombres de las columnas no sean iguales.
            if (StackedPanel.Controls.Count - 1 > columnNames.Count)
            {
                ErrorHandler.ShowMessage("Los nombres de las columnas deben ser unicos.", MessageType.error);
                return false;
            }

            //Validar que el numero de fila es un entero.
            if (!uint.TryParse(TBNumFilas.Text, out NumFilas) && NumFilas >= 1)
            {
                ErrorHandler.ShowMessage("El numero de filas no es válido.", MessageType.error);
                return false;
            }

            return true;
        }
    }
}
