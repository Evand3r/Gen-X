﻿using System;
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
            {"NumeroFila", new FieldType("NumeroFila", "", "", "", "1\n\r2\n\r3")},
            //Date
            {"Fecha", new FieldType("Fecha", "Fecha", "Date", "Between", "7.1.2011\n\r15-feb-1996\n\r1 Enero 1492") },
            //Name
            {"Nombre", new FieldType("Nombre", "Nombre", "Name", "FirstName")},
            {"Nombre Completo", new FieldType("Nombre Completo", "Nombre", "Name", "FullName", "Shamil\n\rAdonis\n\rTiatira")},
            //
        };
    }

    public class FieldType
    {
        public string fName;
        public string SearchCategoryName;
        public string BName;
        public string BCategoryName;
        public string Example;

        /// <summary>
        /// Tipo de dato del campo.
        /// </summary>
        /// <param name="name">Nombre del campo por defecto.</param>
        /// <param name="searchCategoryName">Nombre de categoria para busqueda.</param>
        /// <param name="BName">Nombre del campo para Bogus.</param>
        /// <param name="BCategoryName">Categoria del campo para Bogus.</param>
        /// <param name="example">Ejemplo para mostrar en la lista de seleccion.</param>
        public FieldType(string name, string searchCategoryName = "", string BCategoryName = "", string BName = "", string example = "Null")
        {
            this.fName = name;
            this.SearchCategoryName = searchCategoryName;
            this.BName = BName;
            this.BCategoryName = BCategoryName;
            this.Example = example;
        }
    }
}