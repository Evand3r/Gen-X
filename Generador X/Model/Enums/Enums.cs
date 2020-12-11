using System;
using System.Collections.Generic;
using System.Text;

namespace Generador_X.Model.Enums
{
    /// <summary>
    /// Formatos de salida.
    /// </summary>
    public enum EOutputFormat
    {
        SQL,
        JSON,
        CSV,
        TSV,
        Excel,
        XML,
        Personalizado,
    }

    /// <summary>
    /// Categoria en busqueda.
    /// </summary>
    public enum ECategory
    {
        Basico,
        Nombre,
        Fecha,
        Direccion,

    }

    /// <summary>
    /// Categoria en Bogus.
    /// </summary>
    public enum EBCategory
    {
        Basico,
        Date,
        Name,
        Address
    }


    /// <summary>
    /// Nombre de tipo de campo en Bogus.
    /// </summary>
    public enum EBFieldType
    {
        //Basico
        id,
        //Date
        Between,
        Time, //(Hora) Este no existe en Bogus, pero lo pongo para usarlo como parametro.
        //Name
        FirstName,
        FullName,
        LastName,
        //Address
        //Commerce
        //Company
        //Finanzas
        //Hacker
        //Internet
        Email,
        ExampleEmail,
        UserName,
        DomainName,
    }

    /// <summary>
    /// Nombre de campos para busqueda.
    /// </summary>
    public enum EFieldName
    {
        //Basico
        Numero_Fila,
        //Nombre/Personal
        Primer_Nombre,
        Nombre_Completo,
        //Fecha
        Fecha, //Between
        Hora, //Between (instanciado con el parametro "hora")
        Apellido,
        //Direccion
        Ciudad,
        Provincia,
        Pais,
        Direccion_Completa,
        Direccion_Calle,
        Prefijo_Ciudad,
        Prefijo_Pais,
        Nombre_Calle,
        Latitud,
        Longitud,
    }
}
