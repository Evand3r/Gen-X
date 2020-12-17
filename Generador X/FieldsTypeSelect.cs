using Generador_X.Controls;
using Generador_X.Model;
using Generador_X.Model.Enums;
using Generador_X.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Generador_X
{
    public partial class FieldsTypeSelect : Form
    {
        public FieldType Type { get; set; }

        private Label SelectedLabel = null;

        public FieldsTypeSelect()
        {
            InitializeComponent();
            SuspendLayout();

            //Listar los tipos de campos.
            foreach (KeyValuePair<EFieldName, FieldType> aFieldType in FieldTypes.Types)
            {
                FlowPanelFieldSelect.Controls.Add(new FieldSelect(aFieldType.Value, FieldSelect_Click));
            };

            foreach (string aCategory in Enum.GetNames(typeof(ECategory)))
            {
                Label lbl = new Label
                {
                    AutoSize = true,
                    BorderStyle = BorderStyle.FixedSingle,
                    Cursor = Cursors.Hand,
                    Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point),
                    Padding = new Padding(10, 3, 10, 3),
                    Margin = new Padding(2, 0, 2, 2),
                    Size = new Size(62, 23),
                    Text = aCategory.ToString().Replace("_", " "),
                    Tag = aCategory,
                };

                //Evento
                lbl.Click += CategorySelect_Click;
                lbl.Paint += ChangeCategoryStyle;

                FlowCategoriesPanel.Controls.Add(lbl);
            }

            if(Settings.Default.SelectedCategory != null)
            {
                SelectedLabel = Settings.Default.SelectedCategory;
                FilterFields();
            }

            ResumeLayout();
        }

        private void SearchTB_TextChanged(object sender, EventArgs e)
        {
            FilterFields();
        }

        /// <summary>
        /// Evento clic al elegir el tipo de campo a instanciar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FieldSelect_Click(object sender, EventArgs e)
        {
            Type = ((sender as FieldSelect).Tag as FieldType);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ChangeCategoryStyle(object sender, PaintEventArgs e)
        {
            Label label = sender as Label;

            if (SelectedLabel?.Text == label.Text)
            {
                SelectedLabel = label;
                SelectedLabel.BackColor = SystemColors.Highlight;
                SelectedLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
                SelectedLabel.ForeColor = SystemColors.HighlightText;
            }
            else
            {
                label.BackColor = SystemColors.Control;
                label.ForeColor = SystemColors.ControlText;
            }
        }

        private void CategorySelect_Click(object sender, EventArgs e)
        {
            Label label = (sender as Label);

            //Deseleccionar el label
            if (SelectedLabel?.Text == label.Text)
            {
                label.Invalidate();
                SelectedLabel = null;
                Settings.Default.SelectedCategory = null;
            }
            //seleccionar el label
            else
            {
                //En caso de hacer click a otro label
                if (SelectedLabel != null)
                {
                    SelectedLabel.Invalidate();
                }

                SelectedLabel = label;
                Settings.Default.SelectedCategory = SelectedLabel;
                SelectedLabel.Invalidate();
            }

            FilterFields();
        }

        private void FilterFields()
        {
            FlowPanelFieldSelect.SuspendLayout();

            foreach (FieldSelect fsl in FlowPanelFieldSelect.Controls)
            {
                if (!fsl.FName.Contains(TBSearchFieldType.Text.ToLower()))
                {
                    fsl.Visible = false;
                }
                else if(SelectedLabel != null && SelectedLabel?.Tag.ToString().Replace("_", " ") != fsl.CName)
                {
                    fsl.Visible = false;
                }
                else
                {
                    fsl.Visible = true;
                }
            }

            FlowPanelFieldSelect.ResumeLayout();
        }
    }
}
