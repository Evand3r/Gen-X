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

            CBLanguages.SelectedItem = Languages.list.FirstOrDefault(x => x.Value == Settings.Default.Idioma);
            CBLanguages.SelectedIndexChanged += ValueChanged;

            TBNullValue.Text = Settings.Default.NullValue;
            TBNullValue.TextChanged += ValueChanged;

            CkBxQuotesInNumbers.Checked = Settings.Default.QuotesInNumbers;
        }

        private void BTNAplicar_Click(object sender, EventArgs e)
        {
            SaveChanges();
            BTNAplicar.Enabled = false;
        }

        private void BTNOK_Click(object sender, EventArgs e)
        {
            SaveChanges();
            Close();
        }

        private void SaveChanges()
        {
            Settings.Default.Idioma = CBLanguages.SelectedValue.ToString();
            Settings.Default.NullValue = TBNullValue.Text.Trim();
            Settings.Default.QuotesInNumbers = CkBxQuotesInNumbers.Checked;

            //Guardar configuracion entre sesiones.
            Settings.Default.Save();
        }

        private void ValueChanged(object sender, EventArgs e)
        {
            BTNAplicar.Enabled = true;
        }

        private void BTNCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
