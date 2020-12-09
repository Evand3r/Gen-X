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
    }

    /// <summary>
    /// Categoria en Bogus.
    /// </summary>
    public enum EBCategory
    {
        Basico,
        Date,
        Name,
    }


    /// <summary>
    /// Tipos de campo.
    /// </summary>
    public enum EFieldType
    {
        //Basico
        id,
        //Date
        Date,
        //Name
        FirstName,
        FullName,
    }

    /// <summary>
    /// Nombre de campos para busqueda.
    /// </summary>
    public enum EFieldName
    {

    }
}
