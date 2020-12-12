using Generador_X.Model;
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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            CBLanguages.DataSource = new BindingSource(Languages.list, null);
            CBLanguages.DisplayMember = "key";
            CBLanguages.ValueMember = "Value";

            CBLanguages.SelectedItem = Languages.list.FirstOrDefault(x => x.Value == Settings1.Default.Idioma);
            CBLanguages.SelectedIndexChanged += CBLanguages_SelectedValueChanged;
        }

        public SettingsForm(string WName)
        {
            Text = WName;
        }

        private void CBLanguages_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CBLanguages.SelectedValue.ToString() != Settings1.Default.Idioma)
            {
                Settings1.Default.Idioma = CBLanguages.SelectedValue.ToString();
            }
        }
    }
}
