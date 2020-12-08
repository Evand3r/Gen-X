using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Generador_X.Model
{
    public class FieldTypes
    {
        public static Dictionary<string, FieldType> Types = new Dictionary<string, FieldType>
        {
            //Interno
            {"Nombre Fila", new FieldType("id", "NumeroFila", Categories.Basico, "", "", "1\n\r2\n\r3")},
            //Date
            {"Fecha", new FieldType("fecha", "Fecha", Categories.Fecha, "Date", "Between", "7.1.2011\n\r15-feb-1996\n\r1 Enero 1492") },
            //Name
            {"Nombre", new FieldType("primer nombre", "Primer Nombre", Categories.Nombre, "Name", "FirstName", "Shamil\n\rAdonis\n\rTiatira")},
            {"Nombre Completo", new FieldType("nombre completo", "Nombre Completo", Categories.Nombre, "Name", "FullName", "Shamil Carela\n\rAdonis Castillo\n\rAngelica María Rijo")},
            //
        };
    }

    public class FieldType
    {
        public string columnName;
        public string SearchName;
        public Categories SearchCategoryName;
        public string BName;
        public string BCategoryName;
        public string Example;

        /// <summary>
        /// Tipo de dato del campo.
        /// </summary>
        /// <param name="name">Nombre del campo por defecto.(En textbox)</param>
        /// <param name="searchName">Nombre del campo para busqueda.</param>
        /// <param name="searchCategoryName">Nombre de categoria del campo para busqueda.</param>
        /// <param name="BName">Nombre del campo para Bogus.</param>
        /// <param name="BCategoryName">Categoria del campo para Bogus.</param>
        /// <param name="example">Ejemplo para mostrar en la lista de seleccion.</param>
        public FieldType(string name, string searchName = "", Categories searchCategoryName = Categories.Basico, string BCategoryName = "", string BName = "", string example = "Null")
        {
            this.columnName = name;
            this.SearchName = searchName;
            this.SearchCategoryName = searchCategoryName;
            this.BName = BName;
            this.BCategoryName = BCategoryName;
            this.Example = example;
        }
    }
}
