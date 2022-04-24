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
        //Excel,
        //XML,
        //Personalizado,
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
        Comercio,
        Compañia,
        Base_de_Datos,
        Finanzas,
        Lenguaje,
        Internet,
        Lorem,
        Telefono,
        Discurso,
        Sistema,
        Vehiculo,
        Aleatorio,
    }

    /// <summary>
    /// Categoria en Bogus.
    /// </summary>
    public enum EBCategory
    {
        Basico, //Esta categoria no existe en bogus
        Date,
        Name,
        Address,
        Commerce,
        Company,
        Database,
        Finance,
        Hacker,
        Internet,
        Lorem,
        Phone,
        Rant,
        System,
        Vehicle,
        Random,
    }


    /// <summary>
    /// Nombre de tipo de campo en Bogus.
    /// </summary>
    public enum EBFieldType
    {
        //Basico
        id, //No existe en Bogus
        //Date
        Between,
        Time, //(Hora) Este no existe en Bogus, pero lo pongo para usarlo como parametro.
        //Name
        FirstName,
        LastName,
        FullName,
        Prefix,
        Suffix,
        FindName,
        JobTitle,
        JobDescriptor,
        JobArea,
        JobType,
        //Address
        ZipCode,
        City,
        StreetAddress,
        CityPrefix,
        CitySuffix,
        StreetName,
        BuildingNumber,
        StreetSuffix,
        SecondaryAddress,
        County,
        Country,
        FullAddress,
        CountryCode,
        State,
        StateAbbr,
        Latitude,
        Longitude,
        //Commerce
        Department,
        Price,
        Categories,
        ProductName,
        Color,
        Product,
        ProductAdjective,
        ProductMaterial,
        Ean8,
        Ean13,
        //Company
        CompanySuffix,
        CompanyName,
        CatchPhrase,
        Bs,
        //Database
        Column,
        Type,
        Collation,
        Engine,
        //Finance
        Account,
        AccountName,
        Amount,
        TransactionType,
        Currency,
        CreditCardNumber,
        CreditCardCvv,
        BitcoinAddress,
        EthereumAddress,
        RoutingNumber,
        Bic,
        Iban,
        //Hacker
        Abbreviation,
        Adjective,
        Noun,
        Verb,
        IngVerb,
        Phrase,
        //Internet
        Email,
        ExampleEmail,
        UserName,
        UserNameUnicode,
        DomainName,
        DomainWord,
        DomainSuffix,
        Ip,
        IpAddress,
        IpEndPoint,
        Ipv6,
        Ipv6Address,
        Ipv6EndPoint,
        UserAgent,
        Mac,
        Password,
        Protocol,
        Url,
        UrlWithPath,
        UrlRootedPath,
        //Lorem
        Word,
        Words,
        Letter,
        Sentence,
        Sentences,
        Paragraph,
        Paragraphs,
        Text,
        Lines,
        Slug,
        //Phone
        PhoneNumber,
        PhoneNumberFormat,
        //Rant
        Review,
        //System
        FileName,
        DirectoryPath,
        FilePath,
        MimeType,
        FileType,
        FileExt,
        Version,
        Exception,
        AndroidId,
        ApplePushToken,
        BlackBerryPin,
        //Vehicle
        Vin,
        Manufacturer,
        Model,
        Fuel,
        //Random
        Number,
        //Digits,
        //Even,
        //Odd,
        //Double,
        //Decimal,
        //Float,
        //Byte,
        //Bytes,
        //SByte,
        //Int,
        //UInt,
        //ULong,
        //Long,
        //Short,
        //UShort,
        //Char,
        //Chars,
        //String,
        Hash,
        BoolDB,
        Bool,
        Replace,
        Guid,
        Uuid,
        AlphaNumeric,
        Hexadecimal,
    }

    /// <summary>
    /// Nombre de campos para busqueda.
    /// </summary>
    public enum EFieldName
    {
        //Basico
        Numero_Fila,
        #region \Nombre/Personal
        Nombre,
        Apellido,
        Nombre_Completo,
        Titulo,
        Sufijo,
        Titulo_Profesional,
        Descripcion_Trabajo,
        Area_Trabajo,
        Tipo_Trabajo,
        #endregion
        #region \Fecha
        Fecha, //Between
        Hora, //Between (instanciado con el parametro "hora")
        #endregion
        #region \Direccion
        Codigo_Postal,
        Ciudad,
        Direccion_Calle,
        Prefijo_Ciudad,
        Sufijo_Ciudad,
        Nombre_Calle,
        Numero_Edificio,
        Sufijo_Calle,
        Direccion_Secundaria,
        Condado,
        Pais,
        Direccion_Completa,
        Codigo_Pais,
        Estado,
        Estado_Abr,
        Latitud,
        Longitud,
        #endregion
        #region \Comercio
        Departamento,
        Precio,
        Categorias,
        Nombre_Producto,
        Color,
        Producto,
        Adjetivo_Producto,
        Material_Producto,
        Codigo_Barra_Ean8,
        Codigo_Barra_Ean13,
        #endregion
        #region \Compania
        Sufijo_Compañia,
        Nombre_Compañia,
        Slogan_Compañia,
        Frase_Compañia,
        #endregion
        #region \Base de datos
        Columna,
        Tipo_Dato,
        Collation,
        Motor_BD,
        #endregion
        #region \Finanzas
        Cuenta,
        Nombre_Cuenta,
        Saldo,
        Tipo_Transaccion,
        Moneda,
        Numero_Tarjeta_Credito,
        CVV_Tarjeta_Credito,
        Direccion_Bitcoin,
        Direccion_Ethereum,
        Numero_Routing,
        Bic,
        Iban,
        #endregion
        #region \Lenguaje
        Abreviatura,
        Adjetivo,
        Sustantivo,
        Verbo,
        Infinitivo,
        Frase,
        #endregion
        #region \Internet
        Email,
        ExampleEmail,
        Nombre_Usuario,
        Nombre_Usuario_UTF8,
        Nombre_Dominio,
        Palabra_Dominio,
        Sufijo_Dominio,
        Ip,
        Direccion_Ip,
        Extremo_Ip,
        Ipv6,
        Direccion_Ipv6,
        Extremo_Ipv6,
        UserAgent,
        Mac,
        Contraseña,
        Protocolo,
        Url,
        Url_Ruta,
        Url_Base,
        #endregion
        #region \Lorem
        Palabra,
        Palabras,
        Letra,
        Oracion,
        Oraciones,
        Parrafo,
        Parrafos,
        Texto,
        Lineas,
        Ficha,
        #endregion
        #region \Telefono
        Numero_Telefono,
        Formato_Numero_Telefono,
        #endregion
        #region \Discuro
        Reseña,
        #endregion
        #region \Sistema
        Nombre_Archivo,
        Ruta_Directorio,
        Ruta_Archivo,
        Tipo_MIME,
        Tipo_Archivo,
        Extension_Archivo,
        Version,
        Excepcion,
        AndroidId,
        ApplePushToken,
        Pin_BlackBerry,
        #endregion
        #region \Vehiculo
        Vin,
        Fabricante,
        Modelo,
        Combustible,
        #endregion
        #region \Aleatorio
        Numero, //opc max o min max
        //Digitos,
        //Par,
        //Impar,
        //Double,
        //Decimal,
        //Flotante,
        //Byte,
        //Bytes,
        //SByte,
        //Int, //opc min max
        //UInt, //'
        //ULong,
        //Long, //'
        //Short, //'
        //UShort, //'
        //Caracter, //'
        //Caracteres, //'
        //Cadena, //opc length(int)
        Hash,
        Booleano_DB,
        Booleano,
        Replace,
        Guid,
        Uuid,
        AlfaNumerico,
        Hexadecimal,
        #endregion
    }
}
