using Generador_X.Controls;
using Generador_X.Model;
using Generador_X.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Generador_X
{
    public partial class FieldsTypeSelect : Form
    {
        public FieldType Type { get; set; }

        public FieldsTypeSelect()
        {
            InitializeComponent();

            //Listar los tipos de campos.
            foreach(KeyValuePair<EFieldType, FieldType> aFieldType in FieldTypes.Types)
            {
                FlowPanelFieldSelect.Controls.Add(new FieldSelect(aFieldType.Value, FieldSelect_Click));
            };

        }

        private void SearchTB_TextChanged(object sender, EventArgs e)
        {
            //Filter fields
        }

        private void FieldSelect_Click(object sender, EventArgs e)
        {
            Type = ((sender as FieldSelect).Tag as FieldType);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
