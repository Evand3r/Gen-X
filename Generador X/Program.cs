using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using Generador_X.Model.Categories;

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
            //var text = new Faker("es").Parse("Nombre: {{Name.FullName}}");
        }
    }
}
