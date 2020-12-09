using Generador_X.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Generador_X.Model
{
    public class FieldTypes
    {
        public static Dictionary<EFieldType, FieldType> Types = new Dictionary<EFieldType, FieldType>
        {
            //Interno
            {EFieldType.id, new FieldType("id", "NumeroFila", ECategory.Basico, EBCategory.Basico, "", "1\n\r2\n\r3")},
            //Date
            {EFieldType.Date, new FieldType("fecha", "Fecha", ECategory.Fecha, EBCategory.Date, "Between", "7.1.2011\n\r15-feb-1996\n\r1 Enero 1492") },
            //Name
            {EFieldType.FirstName, new FieldType("primer nombre", "Primer Nombre", ECategory.Nombre, EBCategory.Name, "FirstName", "Shamil\n\rAdonis\n\rTiatira")},
            {EFieldType.FullName, new FieldType("nombre completo", "Nombre Completo", ECategory.Nombre, EBCategory.Name, "FullName", "Shamil Carela\n\rAdonis Castillo\n\rAngelica María Rijo")},
            //
        };
    }

    //TODO: Cambiar el esquema Field a Column (ya que tecnicamente cada paneltype es una 'columna' no un 'campo'.
    public class FieldType
    {
        public string ColumName;
        public string SearchName;
        public ECategory SearchCategoryName;
        public string BName;
        public EBCategory BCategoryName;
        public string Example;

        /// <summary>
        /// Tipo de dato del campo.
        /// </summary>
        /// <param name="name">Nombre del campo por defecto.(En textbox)</param>
        /// <param name="searchName">Nombre del campo para busqueda.</param>
        /// <param name="searchCategoryName">Nombre de categoria del campo para busqueda.</param>
        /// <param name="bName">Nombre del campo para Bogus.</param>
        /// <param name="bCategoryName">Categoria del campo para Bogus.</param>
        /// <param name="example">Ejemplo para mostrar en la lista de seleccion.</param>
        public FieldType(string name, string searchName = "", ECategory searchCategoryName = ECategory.Basico, EBCategory bCategoryName = EBCategory.Basico, string bName = "", string example = "Null")
        {
            ColumName = name;
            SearchName = searchName;
            SearchCategoryName = searchCategoryName;
            BName = bName;
            BCategoryName = bCategoryName;
            Example = example;
        }
    }
}
