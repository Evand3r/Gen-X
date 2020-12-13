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
            {EFieldName.Numero_Fila, new FieldType("id", "INT", EFieldName.Numero_Fila, ECategory.Basico, EBCategory.Basico, EBFieldType.id, "1\n\r2\n\r3")},
            //Name
            {EFieldName.Nombre, new FieldType("nombre", "VARCHAR(50)", EFieldName.Nombre, ECategory.Nombre, EBCategory.Name, EBFieldType.FirstName, "Shamil\n\rAdonis\n\rTiatira")},
            {EFieldName.Nombre_Completo, new FieldType("nombre_completo", "VARCHAR(50)", EFieldName.Nombre_Completo, ECategory.Nombre, EBCategory.Name, EBFieldType.FullName, "Shamil Carela\n\rAdonis Castillo\n\rAngelica María Rijo")},
            {EFieldName.Apellido, new FieldType("apellido", "VARCHAR(50)", EFieldName.Apellido, ECategory.Nombre, EBCategory.Name, EBFieldType.LastName, "Carela\n\rCastillo\n\rRijo")},
            {EFieldName.Titulo, new FieldType("titulo", "VARCHAR(10)", EFieldName.Titulo, ECategory.Nombre, EBCategory.Name, EBFieldType.Prefix, "Mr.\n\rMs.\n\rSrta.")},
            {EFieldName.Sufijo, new FieldType("sufijo", "VARCHAR(10)", EFieldName.Sufijo, ECategory.Nombre, EBCategory.Name, EBFieldType.Suffix, "MBA\n\rPhD.\n\rBA")},
            {EFieldName.Titulo_Profesional, new FieldType("titulo_profesional", "VARCHAR(10)", EFieldName.Titulo_Profesional, ECategory.Nombre, EBCategory.Name, EBFieldType.JobTitle, " \n\r \n\r ")},
            {EFieldName.Descripcion_Trabajo, new FieldType("Descripcion_Trabajo", "VARCHAR(150)", EFieldName.Descripcion_Trabajo, ECategory.Nombre, EBCategory.Name, EBFieldType.JobDescriptor, " \n\r \n\r ")},
            {EFieldName.Area_Trabajo, new FieldType("Area_Trabajo", "VARCHAR(80)", EFieldName.Area_Trabajo, ECategory.Nombre, EBCategory.Name, EBFieldType.JobArea, " \n\r \n\r ")},
            {EFieldName.Tipo_Trabajo, new FieldType("Tipo_Trabajo", "VARCHAR(80)", EFieldName.Tipo_Trabajo, ECategory.Nombre, EBCategory.Name, EBFieldType.JobType, " \n\r \n\r ")},
            //Date
            {EFieldName.Fecha, new FieldType("fecha", "DATE", EFieldName.Fecha, ECategory.Fecha, EBCategory.Date, EBFieldType.Between, "7.1.2011\n\r15-feb-1996\n\r1 Enero 1492") },
            {EFieldName.Hora, new FieldType("hora", "TIME", EFieldName.Hora, ECategory.Fecha, EBCategory.Date, EBFieldType.Time, "8:50AM\n\r23:00\n\r12:03PM") },
            //Address
            {EFieldName.Codigo_Postal, new FieldType("Codigo_Postal", "VARCHAR(80)", EFieldName.Codigo_Postal, ECategory.Direccion, EBCategory.Address, EBFieldType.ZipCode, " \n\r \n\r ") },
            {EFieldName.Ciudad, new FieldType("Ciudad", "VARCHAR(80)", EFieldName.Ciudad, ECategory.Direccion, EBCategory.Address, EBFieldType.City, " \n\r \n\r ") },
            {EFieldName.Direccion_Calle, new FieldType("Direccion_Calle", "VARCHAR(80)", EFieldName.Direccion_Calle, ECategory.Direccion, EBCategory.Address, EBFieldType.StreetAddress, " \n\r \n\r ") },
            {EFieldName.Prefijo_Ciudad, new FieldType("Prefijo_Ciudad", "VARCHAR(80)", EFieldName.Prefijo_Ciudad, ECategory.Direccion, EBCategory.Address, EBFieldType.CityPrefix, " \n\r \n\r ") },
            {EFieldName.Sufijo_Ciudad, new FieldType("Sufijo_Ciudad", "VARCHAR(80)", EFieldName.Sufijo_Ciudad, ECategory.Direccion, EBCategory.Address, EBFieldType.CitySuffix, " \n\r \n\r ") },
            {EFieldName.Nombre_Calle, new FieldType("Nombre_Calle", "VARCHAR(80)", EFieldName.Nombre_Calle, ECategory.Direccion, EBCategory.Address, EBFieldType.StreetName, " \n\r \n\r ") },
            {EFieldName.Numero_Edificio, new FieldType("Numero_Edificio", "VARCHAR(80)", EFieldName.Numero_Edificio, ECategory.Direccion, EBCategory.Address, EBFieldType.BuildingNumber, " \n\r \n\r ") },
            {EFieldName.Sufijo_Calle, new FieldType("Prefijo_Pais", "VARCHAR(80)", EFieldName.Sufijo_Calle, ECategory.Direccion, EBCategory.Address, EBFieldType.StreetSuffix, " \n\r \n\r ") },
            {EFieldName.Direccion_Secundaria, new FieldType("Direccion_Secundaria", "VARCHAR(80)", EFieldName.Direccion_Secundaria, ECategory.Direccion, EBCategory.Address, EBFieldType.SecondaryAddress, " \n\r \n\r ") },
            {EFieldName.Condado, new FieldType("Condado", "VARCHAR(80)", EFieldName.Condado, ECategory.Direccion, EBCategory.Address, EBFieldType.County, " \n\r \n\r ") },
            {EFieldName.Pais, new FieldType("Pais", "VARCHAR(80)", EFieldName.Pais, ECategory.Direccion, EBCategory.Address, EBFieldType.Country, " \n\r \n\r ") },
            {EFieldName.Direccion_Completa, new FieldType("Direccion_Completa", "VARCHAR(80)", EFieldName.Direccion_Completa, ECategory.Direccion, EBCategory.Address, EBFieldType.FullAddress, " \n\r \n\r ") },
            {EFieldName.Codigo_Pais, new FieldType("Codigo_Pais", "VARCHAR(80)", EFieldName.Codigo_Pais, ECategory.Direccion, EBCategory.Address, EBFieldType.CountryCode, " \n\r \n\r ") },
            {EFieldName.Estado, new FieldType("Estado", "VARCHAR(80)", EFieldName.Estado, ECategory.Direccion, EBCategory.Address, EBFieldType.State, " \n\r \n\r ") },
            {EFieldName.Estado_Abr, new FieldType("Estado_Abr", "VARCHAR(80)", EFieldName.Estado_Abr, ECategory.Direccion, EBCategory.Address, EBFieldType.StateAbbr, " \n\r \n\r ") },
            {EFieldName.Latitud, new FieldType("Latitud", "VARCHAR(80)", EFieldName.Latitud, ECategory.Direccion, EBCategory.Address, EBFieldType.Latitude, " \n\r \n\r ") },
            {EFieldName.Longitud, new FieldType("Longitud", "VARCHAR(80)", EFieldName.Longitud, ECategory.Direccion, EBCategory.Address, EBFieldType.Longitude, " \n\r \n\r ") },
            //Comercio
            {EFieldName.Departamento, new FieldType("Departamento", "VARCHAR(80)", EFieldName.Departamento, ECategory.Comercio, EBCategory.Commerce, EBFieldType.Department, " \n\r \n\r ") },
            {EFieldName.Precio, new FieldType("Precio", "VARCHAR(80)", EFieldName.Precio, ECategory.Comercio, EBCategory.Commerce, EBFieldType.Price, " \n\r \n\r ") },
            {EFieldName.Categorias, new FieldType("Categoria", "VARCHAR(80)", EFieldName.Categorias, ECategory.Comercio, EBCategory.Commerce, EBFieldType.Categories, " \n\r \n\r ") },
            {EFieldName.Nombre_Producto, new FieldType("Nombre_Producto", "VARCHAR(80)", EFieldName.Nombre_Producto, ECategory.Comercio, EBCategory.Commerce, EBFieldType.ProductName, " \n\r \n\r ") },
            {EFieldName.Color, new FieldType("Color", "VARCHAR(80)", EFieldName.Color, ECategory.Comercio, EBCategory.Commerce, EBFieldType.Color, " \n\r \n\r ") },
            {EFieldName.Producto, new FieldType("Producto", "VARCHAR(80)", EFieldName.Producto, ECategory.Comercio, EBCategory.Commerce, EBFieldType.Product, " \n\r \n\r ") },
            {EFieldName.Adjetivo_Producto, new FieldType("Adjetivo_Producto", "VARCHAR(80)", EFieldName.Adjetivo_Producto, ECategory.Comercio, EBCategory.Commerce, EBFieldType.ProductAdjective, " \n\r \n\r ") },
            {EFieldName.Material_Producto, new FieldType("Material_Producto", "VARCHAR(80)", EFieldName.Material_Producto, ECategory.Comercio, EBCategory.Commerce, EBFieldType.ProductMaterial, " \n\r \n\r ") },
            {EFieldName.Codigo_Barra_Ean8, new FieldType("Codigo_Barra_Ean8", "VARCHAR(80)", EFieldName.Codigo_Barra_Ean8, ECategory.Comercio, EBCategory.Commerce, EBFieldType.Ean8, " \n\r \n\r ") },
            {EFieldName.Codigo_Barra_Ean13, new FieldType("Codigo_Barra_Ean13", "VARCHAR(80)", EFieldName.Codigo_Barra_Ean13, ECategory.Comercio, EBCategory.Commerce, EBFieldType.Ean13, " \n\r \n\r ") },
            //Compañia


            //{EFieldName., new FieldType("", "VARCHAR(80)", EFieldName., ECategory.Comercio, EBCategory.Commerce, EBFieldType., " \n\r \n\r ") },
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
        /// Tipo de columna para mostrar en creacion de tabla.
        /// </summary>
        public string ColumnType;
        /// <summary>
        /// Nombre del campo para busqueda.
        /// </summary>
        public EFieldName SearchName;
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
        /// Tipo de dato del campo.
        /// </summary>
        /// <param name="name">Nombre del campo por defecto.(En textbox)</param>
        /// <param name="searchCategoryName">Nombre de categoria del campo para busqueda.</param>
        /// <param name="searchName">Nombre del campo para busqueda.</param>
        /// <param name="bName">Nombre del campo para Bogus.</param>
        /// <param name="bCategoryName">Categoria del campo para Bogus.</param>
        /// <param name="example">Ejemplo para mostrar en la lista de seleccion.</param>
        /// <param name="columnType">Ejemplo para mostrar en la lista de seleccion.</param>
        public FieldType(
            string name,
            string columnType,
            EFieldName searchName,
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
