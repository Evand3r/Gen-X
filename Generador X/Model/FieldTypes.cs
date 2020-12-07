using System;
using System.Collections.Generic;
using System.Text;

namespace Generador_X.Model
{
    public class FieldTypes
    {
        public static Dictionary<string, FieldType> Types = new Dictionary<string, FieldType>
        {
            //Interno
            {"NumeroFila", new FieldType("NumeroFila", "", "", "1\n\r2\n\r3")},
            //Date
            {"Fecha", new FieldType("Fecha", "Fecha", "Date", "7.1.2011\n\r15-feb-1996\n\r1 Enero 1492") },
            //Name
            {"Nombre", new FieldType("Nombre", "Nombre", "Name")},
            {"Nombre Completo", new FieldType("Nombre Completo", "FullName", "Name", "Shamil\n\rAdonis\n\rTiatira")},
            //
        };
    }

    public class FieldType
    {
        public string Name;
        public string SearchCategoryName;
        public string BCategoryName;
        public string Example;

        /// <summary>
        /// Tipo de dato del campo.
        /// </summary>
        /// <param name="name">Nombre del campo como sera buscado.</param>
        /// <param name="searchCategoryName">Categoria del campo como sera buscado.</param>
        /// <param name="BCategoryName">Categoria del campo para Bogus.</param>
        public FieldType(string name, string searchCategoryName = "", string BCategoryName = "", string example = "Null")
        {
            this.Name = name;
            this.SearchCategoryName = searchCategoryName;
            this.BCategoryName = BCategoryName;
            this.Example = example;
        }
    }
}
