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
        public string ReturnValue1 { get; set; }
        public string ReturnValue2 { get; set; }

        public FieldsTypeSelect()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Filter fields
        }

        private void panel2_Paint(object sender, EventArgs e)
        {
            ReturnValue1 = (sender as Panel).Tag.ToString();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
