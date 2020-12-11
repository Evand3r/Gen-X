using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Generador_X
{
    public partial class PreviewForm : Form
    {
        public PreviewForm()
        {
            InitializeComponent();
        }

        public PreviewForm(string Result)
        {
            InitializeComponent();
            TBExampleText.Text = Result;
        }
    }
}
