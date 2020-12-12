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
            {EFieldName.Numero_Fila, new FieldType("id", "INT", "NumeroFila", ECategory.Basico, EBCategory.Basico, EBFieldType.id, "1\n\r2\n\r3")},
            //Date
            {EFieldName.Fecha, new FieldType("fecha", "DATE", "Fecha", ECategory.Fecha, EBCategory.Date, EBFieldType.Between, "7.1.2011\n\r15-feb-1996\n\r1 Enero 1492") },
            {EFieldName.Hora, new FieldType("hora", "TIME", "Hora", ECategory.Fecha, EBCategory.Date, EBFieldType.Time, "8:50AM\n\r23:00\n\r12:03PM") },
            //Name
            {EFieldName.Nombre, new FieldType("nombre", "VARCHAR(50)", "Nombre", ECategory.Nombre, EBCategory.Name, EBFieldType.FirstName, "Shamil\n\rAdonis\n\rTiatira")},
            {EFieldName.Nombre_Completo, new FieldType("nombre_completo", "VARCHAR(50)", "Nombre Completo", ECategory.Nombre, EBCategory.Name, EBFieldType.FullName, "Shamil Carela\n\rAdonis Castillo\n\rAngelica María Rijo")},
            {EFieldName.Apellido, new FieldType("apellido", "VARCHAR(50)", "Apellido", ECategory.Nombre, EBCategory.Name, EBFieldType.LastName, "Carela\n\rCastillo\n\rRijo")},
            //Address
            //{EFieldName.Ciudad, new FieldType("Apellido", "VARCHAR(50)", "Apellido", ECategory.Nombre, EBCategory.Name, EBFieldType.LastName, "Carela\n\rCastillo\n\rRijo")},
            //
        };
    }

    public class FieldType
    {
        /// <summary>
        /// Texto del nombre de campo. (TextBox.Text)
        /// </summary>
        public string ColumName;
        /// <summary>
        /// Nombre del campo para busqueda.
        /// </summary>
        public string SearchName;
        /// <summary>
        /// Nombre de Categoria para busqueda.
        /// </summary>
        public ECategory SearchCategoryName;
        /// <summary>
        /// Tipo de campo para Bogus.
        /// </summary>
        public EBFieldType BName;
        /// <summary>
        /// Categoria de campo en Bogus.
        /// </summary>
        public EBCategory BCategoryName;
        /// <summary>
        /// Ejemplo para mostrar en lista.
        /// </summary>
        public string Example;
        /// <summary>
        /// Tipo de columna para mostrar en creacion de tabla.
        /// </summary>
        public string ColumnType;

        /// <summary>
        /// Tipo de dato del campo.
        /// </summary>
        /// <param name="name">Nombre del campo por defecto.(En textbox)</param>
        /// <param name="searchName">Nombre del campo para busqueda.</param>
        /// <param name="searchCategoryName">Nombre de categoria del campo para busqueda.</param>
        /// <param name="bName">Nombre del campo para Bogus.</param>
        /// <param name="bCategoryName">Categoria del campo para Bogus.</param>
        /// <param name="example">Ejemplo para mostrar en la lista de seleccion.</param>
        /// <param name="columnType">Ejemplo para mostrar en la lista de seleccion.</param>
        public FieldType(
            string name,
            string columnType,
            string searchName = "",
            ECategory searchCategoryName = ECategory.Basico,
            EBCategory bCategoryName = EBCategory.Basico,
            EBFieldType bName = EBFieldType.id,
            string example = "Null")
        {
            ColumName = name;
            ColumnType = columnType;
            SearchName = searchName;
            SearchCategoryName = searchCategoryName;
            BName = bName;
            BCategoryName = bCategoryName;
            Example = example;
        }
    }
}
