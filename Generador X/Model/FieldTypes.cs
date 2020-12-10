using Generador_X.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Generador_X.Model
{
    public class FieldTypes
    {
        public static Dictionary<EFieldName, FieldType> Types = new Dictionary<EFieldName, FieldType>
        {
            //Interno
            {EFieldName.Numero_Fila, new FieldType("id", "NumeroFila", ECategory.Basico, EBCategory.Basico, EBFieldType.id, "1\n\r2\n\r3")},
            //Date
            {EFieldName.Fecha, new FieldType("fecha", "Fecha", ECategory.Fecha, EBCategory.Date, EBFieldType.Between, "7.1.2011\n\r15-feb-1996\n\r1 Enero 1492") },
            {EFieldName.Hora, new FieldType("hora", "Hora", ECategory.Fecha, EBCategory.Date, EBFieldType.Time, "8:50AM\n\r23:00\n\r12:03PM") },
            //Name
            {EFieldName.Primer_Nombre, new FieldType("primer_nombre", "Primer Nombre", ECategory.Nombre, EBCategory.Name, EBFieldType.FirstName, "Shamil\n\rAdonis\n\rTiatira")},
            {EFieldName.Nombre_Completo, new FieldType("nombre_completo", "Nombre Completo", ECategory.Nombre, EBCategory.Name, EBFieldType.FullName, "Shamil Carela\n\rAdonis Castillo\n\rAngelica María Rijo")},
            //
        };
    }

    //TODO: Cambiar el esquema Field a Column (ya que tecnicamente cada paneltype es una 'columna' no un 'campo'.
    public class FieldType
    {
        public string ColumName;
        public string SearchName;
        public ECategory SearchCategoryName;
        public EBFieldType BName;
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
        public FieldType(
            string name,
            string searchName = "",
            ECategory searchCategoryName = ECategory.Basico,
            EBCategory bCategoryName = EBCategory.Basico,
            EBFieldType bName = EBFieldType.id,
            string example = "Null")
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
