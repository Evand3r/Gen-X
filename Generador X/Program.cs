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

            //Faker fkr = new Faker();

            //var a = fkr.Parse("{{finance.currency}}");
            //var b = fkr.Finance.Currency();
            //var c = new Bogus.DataSets.Finance();
            //var d = c.Currency();
        }
    }
}
