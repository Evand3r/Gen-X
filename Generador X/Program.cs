using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace Generador_X
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainView());

            //var text = new Ubicacion("es").CodigoPostal();
            //string Daito1 = $".Between({DateTime.Now},{DateTime.Now.AddYears(-1)})";
            //var text = new Faker("es").Parse("Nombre: {{Date" + Daito1 + "}}");
        }
    }
}
