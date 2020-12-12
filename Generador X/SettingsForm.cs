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
            CBLanguages.SelectedIndexChanged += ValueChanged;

            TBNullValue.Text = Settings1.Default.NullValue;
            TBNullValue.TextChanged += ValueChanged;
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
            Settings1.Default.Idioma = CBLanguages.SelectedValue.ToString();
            Settings1.Default.NullValue = TBNullValue.Text.Trim();

            //Guardar configuracion entre sesiones.
            Settings1.Default.Save();
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
