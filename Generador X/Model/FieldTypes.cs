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
            #region Name
            {EFieldName.Nombre, new FieldType("nombre", "VARCHAR(50)", EFieldName.Nombre, ECategory.Nombre, EBCategory.Name, EBFieldType.FirstName, "Shamil\n\rAdonis\n\rTiatira")},
            {EFieldName.Nombre_Completo, new FieldType("nombre_completo", "VARCHAR(50)", EFieldName.Nombre_Completo, ECategory.Nombre, EBCategory.Name, EBFieldType.FullName, "Shamil Carela\n\rAdonis Castillo\n\rAngelica María Rijo")},
            {EFieldName.Apellido, new FieldType("apellido", "VARCHAR(50)", EFieldName.Apellido, ECategory.Nombre, EBCategory.Name, EBFieldType.LastName, "Carela\n\rCastillo\n\rRijo")},
            {EFieldName.Titulo, new FieldType("titulo", "VARCHAR(10)", EFieldName.Titulo, ECategory.Nombre, EBCategory.Name, EBFieldType.Prefix, "Mr.\n\rMs.\n\rSrta.")},
            {EFieldName.Sufijo, new FieldType("sufijo", "VARCHAR(10)", EFieldName.Sufijo, ECategory.Nombre, EBCategory.Name, EBFieldType.Suffix, "MBA\n\rPhD.\n\rBA")},
            {EFieldName.Titulo_Profesional, new FieldType("titulo_profesional", "VARCHAR(10)", EFieldName.Titulo_Profesional, ECategory.Nombre, EBCategory.Name, EBFieldType.JobTitle, " \n\r \n\r ")},
            {EFieldName.Descripcion_Trabajo, new FieldType("Descripcion_Trabajo", "VARCHAR(150)", EFieldName.Descripcion_Trabajo, ECategory.Nombre, EBCategory.Name, EBFieldType.JobDescriptor, " \n\r \n\r ")},
            {EFieldName.Area_Trabajo, new FieldType("Area_Trabajo", "VARCHAR(80)", EFieldName.Area_Trabajo, ECategory.Nombre, EBCategory.Name, EBFieldType.JobArea, " \n\r \n\r ")},
            {EFieldName.Tipo_Trabajo, new FieldType("Tipo_Trabajo", "VARCHAR(80)", EFieldName.Tipo_Trabajo, ECategory.Nombre, EBCategory.Name, EBFieldType.JobType, " \n\r \n\r ")},
            #endregion
            #region Date
            {EFieldName.Fecha, new FieldType("fecha", "DATE", EFieldName.Fecha, ECategory.Fecha, EBCategory.Date, EBFieldType.Between, "7.1.2011\n\r15-feb-1996\n\r1 Enero 1492") },
            {EFieldName.Hora, new FieldType("hora", "TIME", EFieldName.Hora, ECategory.Fecha, EBCategory.Date, EBFieldType.Time, "8:50AM\n\r23:00\n\r12:03PM") },
            #endregion
            #region Address
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
            #endregion
            #region Comercio
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
            #endregion
            #region Compañia
            {EFieldName.Sufijo_Compañia, new FieldType("Sufijo_Compañia", "VARCHAR(80)", EFieldName.Sufijo_Compañia, ECategory.Compañia, EBCategory.Company, EBFieldType.CompanySuffix, " \n\r \n\r ") },
            {EFieldName.Nombre_Compañia, new FieldType("Nombre_Compañia", "VARCHAR(80)", EFieldName.Nombre_Compañia, ECategory.Compañia, EBCategory.Company, EBFieldType.CompanyName, " \n\r \n\r ") },
            {EFieldName.Slogan_Compañia, new FieldType("Slogan_Compañia", "VARCHAR(80)", EFieldName.Slogan_Compañia, ECategory.Compañia, EBCategory.Company, EBFieldType.CatchPhrase, " \n\r \n\r ") },
            {EFieldName.Frase_Compañia, new FieldType("Frase_Compañia", "VARCHAR(80)", EFieldName.Frase_Compañia, ECategory.Compañia, EBCategory.Company, EBFieldType.Bs, " \n\r \n\r ") },
            #endregion
            #region Database
            {EFieldName.Columna, new FieldType("columna", "VARCHAR(80)", EFieldName.Columna, ECategory.Base_de_Datos, EBCategory.Database, EBFieldType.Column, " \n\r \n\r ") },
            {EFieldName.Tipo_Dato, new FieldType("tipo_dato", "VARCHAR(80)", EFieldName.Tipo_Dato, ECategory.Base_de_Datos, EBCategory.Database, EBFieldType.Type, " \n\r \n\r ") },
            {EFieldName.Collation, new FieldType("collation", "VARCHAR(80)", EFieldName.Collation, ECategory.Base_de_Datos, EBCategory.Database, EBFieldType.Collation, " \n\r \n\r ") },
            {EFieldName.Motor_BD, new FieldType("motor_BD", "VARCHAR(80)", EFieldName.Motor_BD, ECategory.Base_de_Datos, EBCategory.Database, EBFieldType.Engine, " \n\r \n\r ") },
            #endregion
            #region Finance
            {EFieldName.Cuenta, new FieldType("Cuenta", "VARCHAR(80)", EFieldName.Cuenta, ECategory.Finanzas, EBCategory.Finance, EBFieldType.Account, " \n\r \n\r ") },
            {EFieldName.Nombre_Cuenta, new FieldType("Nombre_Cuenta", "VARCHAR(80)", EFieldName.Nombre_Cuenta, ECategory.Finanzas, EBCategory.Finance, EBFieldType.AccountName, " \n\r \n\r ") },
            {EFieldName.Saldo, new FieldType("Saldo", "VARCHAR(80)", EFieldName.Saldo, ECategory.Finanzas, EBCategory.Finance, EBFieldType.Amount, " \n\r \n\r ") },
            {EFieldName.Tipo_Transaccion, new FieldType("Tipo_Transaccion", "VARCHAR(80)", EFieldName.Tipo_Transaccion, ECategory.Finanzas, EBCategory.Finance, EBFieldType.TransactionType, " \n\r \n\r ") },
            {EFieldName.Moneda, new FieldType("Moneda", "VARCHAR(80)", EFieldName.Moneda, ECategory.Finanzas, EBCategory.Finance, EBFieldType.Currency, " \n\r \n\r ") },
            {EFieldName.Numero_Tarjeta_Credito, new FieldType("Numero_Tarjeta_Credito", "VARCHAR(80)", EFieldName.Numero_Tarjeta_Credito, ECategory.Finanzas, EBCategory.Finance, EBFieldType.CreditCardNumber, " \n\r \n\r ") },
            {EFieldName.CVV_Tarjeta_Credito, new FieldType("CVV_Tarjeta_Credito", "VARCHAR(80)", EFieldName.CVV_Tarjeta_Credito, ECategory.Finanzas, EBCategory.Finance, EBFieldType.CreditCardCvv, " \n\r \n\r ") },
            {EFieldName.Direccion_Bitcoin, new FieldType("Direccion_Bitcoin", "VARCHAR(80)", EFieldName.Direccion_Bitcoin, ECategory.Finanzas, EBCategory.Finance, EBFieldType.BitcoinAddress, " \n\r \n\r ") },
            {EFieldName.Direccion_Ethereum, new FieldType("Direccion_Ethereum", "VARCHAR(80)", EFieldName.Direccion_Ethereum, ECategory.Finanzas, EBCategory.Finance, EBFieldType.EthereumAddress, " \n\r \n\r ") },
            {EFieldName.Numero_Routing, new FieldType("Numero_Routing", "VARCHAR(80)", EFieldName.Numero_Routing, ECategory.Finanzas, EBCategory.Finance, EBFieldType.RoutingNumber, " \n\r \n\r ") },
            {EFieldName.Bic, new FieldType("Bic", "VARCHAR(80)", EFieldName.Bic, ECategory.Finanzas, EBCategory.Finance, EBFieldType.Bic, " \n\r \n\r ") },
            {EFieldName.Iban, new FieldType("Iban", "VARCHAR(80)", EFieldName.Iban, ECategory.Finanzas, EBCategory.Finance, EBFieldType.Iban, " \n\r \n\r ") },
            #endregion
            #region Hacker
            {EFieldName.Abreviatura, new FieldType("Abreviatura", "VARCHAR(80)", EFieldName.Abreviatura, ECategory.Lenguaje, EBCategory.Hacker, EBFieldType.Abbreviation, " \n\r \n\r ") },
            {EFieldName.Adjetivo, new FieldType("Adjetivo", "VARCHAR(80)", EFieldName.Adjetivo, ECategory.Lenguaje, EBCategory.Hacker, EBFieldType.Adjective, " \n\r \n\r ") },
            {EFieldName.Sustantivo, new FieldType("Sustantivo", "VARCHAR(80)", EFieldName.Sustantivo, ECategory.Lenguaje, EBCategory.Hacker, EBFieldType.Noun, " \n\r \n\r ") },
            {EFieldName.Verbo, new FieldType("Verbo", "VARCHAR(80)", EFieldName.Verbo, ECategory.Lenguaje, EBCategory.Hacker, EBFieldType.Verb, " \n\r \n\r ") },
            {EFieldName.Infinitivo, new FieldType("Infinitivo", "VARCHAR(80)", EFieldName.Infinitivo, ECategory.Lenguaje, EBCategory.Hacker, EBFieldType.IngVerb, " \n\r \n\r ") },
            {EFieldName.Frase, new FieldType("Frase", "VARCHAR(80)", EFieldName.Frase, ECategory.Lenguaje, EBCategory.Hacker, EBFieldType.Phrase, " \n\r \n\r ") },
            #endregion
            #region Internet
            {EFieldName.Email, new FieldType("Email", "VARCHAR(80)", EFieldName.Email, ECategory.Internet, EBCategory.Internet, EBFieldType.Email, " \n\r \n\r ") },
            {EFieldName.ExampleEmail, new FieldType("ExampleEmail", "VARCHAR(80)", EFieldName.ExampleEmail, ECategory.Internet, EBCategory.Internet, EBFieldType.ExampleEmail, " \n\r \n\r ") },
            {EFieldName.Nombre_Usuario, new FieldType("Nombre_Usuario", "VARCHAR(80)", EFieldName.Nombre_Usuario, ECategory.Internet, EBCategory.Internet, EBFieldType.UserName, " \n\r \n\r ") },
            {EFieldName.Nombre_Usuario_UTF8, new FieldType("Nombre_Usuario_UTF8", "VARCHAR(80)", EFieldName.Nombre_Usuario_UTF8, ECategory.Internet, EBCategory.Internet, EBFieldType.UserNameUnicode, " \n\r \n\r ") },
            {EFieldName.Nombre_Dominio, new FieldType("Nombre_Dominio", "VARCHAR(80)", EFieldName.Nombre_Dominio, ECategory.Internet, EBCategory.Internet, EBFieldType.DomainName, " \n\r \n\r ") },
            {EFieldName.Palabra_Dominio, new FieldType("Palabra_Dominio", "VARCHAR(80)", EFieldName.Palabra_Dominio, ECategory.Internet, EBCategory.Internet, EBFieldType.DomainWord, " \n\r \n\r ") },
            {EFieldName.Sufijo_Dominio, new FieldType("Sufijo_Dominio", "VARCHAR(80)", EFieldName.Sufijo_Dominio, ECategory.Internet, EBCategory.Internet, EBFieldType.DomainSuffix, " \n\r \n\r ") },
            {EFieldName.Ip, new FieldType("Ip", "VARCHAR(80)", EFieldName.Ip, ECategory.Internet, EBCategory.Internet, EBFieldType.Ip, " \n\r \n\r ") },
            {EFieldName.Direccion_Ip, new FieldType("Direccion_Ip", "VARCHAR(80)", EFieldName.Direccion_Ip, ECategory.Internet, EBCategory.Internet, EBFieldType.IpAddress, " \n\r \n\r ") },
            {EFieldName.Extremo_Ip, new FieldType("Extremo_Ip", "VARCHAR(80)", EFieldName.Extremo_Ip, ECategory.Internet, EBCategory.Internet, EBFieldType.IpEndPoint, " \n\r \n\r ") },
            {EFieldName.Ipv6, new FieldType("Ipv6", "VARCHAR(80)", EFieldName.Ipv6, ECategory.Internet, EBCategory.Internet, EBFieldType.Ipv6, " \n\r \n\r ") },
            {EFieldName.Direccion_Ipv6, new FieldType("Direccion_Ipv6", "VARCHAR(80)", EFieldName.Direccion_Ipv6, ECategory.Internet, EBCategory.Internet, EBFieldType.Ipv6Address, " \n\r \n\r ") },
            {EFieldName.Extremo_Ipv6, new FieldType("Extremo_Ipv6", "VARCHAR(80)", EFieldName.Extremo_Ipv6, ECategory.Internet, EBCategory.Internet, EBFieldType.Ipv6EndPoint, " \n\r \n\r ") },
            {EFieldName.UserAgent, new FieldType("UserAgent", "VARCHAR(80)", EFieldName.UserAgent, ECategory.Internet, EBCategory.Internet, EBFieldType.UserAgent, " \n\r \n\r ") },
            {EFieldName.Mac, new FieldType("Mac", "VARCHAR(80)", EFieldName.Mac, ECategory.Internet, EBCategory.Internet, EBFieldType.Mac, " \n\r \n\r ") },
            {EFieldName.Contraseña, new FieldType("Contraseña", "VARCHAR(80)", EFieldName.Contraseña, ECategory.Internet, EBCategory.Internet, EBFieldType.Password, " \n\r \n\r ") },
            {EFieldName.Protocolo, new FieldType("Protocolo", "VARCHAR(80)", EFieldName.Protocolo, ECategory.Internet, EBCategory.Internet, EBFieldType.Protocol, " \n\r \n\r ") },
            {EFieldName.Url, new FieldType("Url", "VARCHAR(80)", EFieldName.Url, ECategory.Internet, EBCategory.Internet, EBFieldType.Url, " \n\r \n\r ") },
            {EFieldName.Url_Ruta, new FieldType("Url_Ruta", "VARCHAR(80)", EFieldName.Url_Ruta, ECategory.Internet, EBCategory.Internet, EBFieldType.UrlWithPath, " \n\r \n\r ") },
            {EFieldName.Url_Base, new FieldType("Url_Base", "VARCHAR(80)", EFieldName.Url_Base, ECategory.Internet, EBCategory.Internet, EBFieldType.UrlRootedPath, " \n\r \n\r ") },
            #endregion
            #region Lorem
            {EFieldName.Palabra, new FieldType("Palabra", "VARCHAR(80)", EFieldName.Palabra, ECategory.Lorem, EBCategory.Lorem, EBFieldType.Word, " \n\r \n\r ") },
            //{EFieldName.Palabras, new FieldType("Palabras", "VARCHAR(80)", EFieldName.Palabras, ECategory.Lorem, EBCategory.Lorem, EBFieldType.Words, " \n\r \n\r ") },
            {EFieldName.Letra, new FieldType("Letra", "VARCHAR(80)", EFieldName.Letra, ECategory.Lorem, EBCategory.Lorem, EBFieldType.Letter, " \n\r \n\r ") },
            {EFieldName.Oracion, new FieldType("Oracion", "VARCHAR(80)", EFieldName.Oracion, ECategory.Lorem, EBCategory.Lorem, EBFieldType.Sentence, " \n\r \n\r ") },
            {EFieldName.Oraciones, new FieldType("Oraciones", "VARCHAR(80)", EFieldName.Oraciones, ECategory.Lorem, EBCategory.Lorem, EBFieldType.Sentences, " \n\r \n\r ") },
            {EFieldName.Parrafo, new FieldType("Parrafo", "VARCHAR(80)", EFieldName.Parrafo, ECategory.Lorem, EBCategory.Lorem, EBFieldType.Paragraph, " \n\r \n\r ") },
            {EFieldName.Parrafos, new FieldType("Parrafos", "VARCHAR(80)", EFieldName.Parrafos, ECategory.Lorem, EBCategory.Lorem, EBFieldType.Paragraphs, " \n\r \n\r ") },
            {EFieldName.Texto, new FieldType("Texto", "VARCHAR(80)", EFieldName.Texto, ECategory.Lorem, EBCategory.Lorem, EBFieldType.Text, " \n\r \n\r ") },
            {EFieldName.Lineas, new FieldType("Lineas", "VARCHAR(80)", EFieldName.Lineas, ECategory.Lorem, EBCategory.Lorem, EBFieldType.Lines, " \n\r \n\r ") },
            {EFieldName.Ficha, new FieldType("Ficha", "VARCHAR(80)", EFieldName.Ficha, ECategory.Lorem, EBCategory.Lorem, EBFieldType.Slug, " \n\r \n\r ") },
            #endregion
            #region Phone
            {EFieldName.Numero_Telefono, new FieldType("Numero_Telefono", "VARCHAR(80)", EFieldName.Numero_Telefono, ECategory.Telefono, EBCategory.Phone, EBFieldType.PhoneNumber, " \n\r \n\r ") },
            {EFieldName.Formato_Numero_Telefono, new FieldType("Formato_Numero_Telefono", "VARCHAR(80)", EFieldName.Formato_Numero_Telefono, ECategory.Telefono, EBCategory.Phone, EBFieldType.PhoneNumberFormat, " \n\r \n\r ") },
            #endregion
            #region Rant
            {EFieldName.Reseña, new FieldType("Reseña", "VARCHAR(80)", EFieldName.Reseña, ECategory.Discurso, EBCategory.Rant, EBFieldType.Review, " \n\r \n\r ") },
            #endregion
            #region System
            {EFieldName.Nombre_Archivo, new FieldType("Nombre_Archivo", "VARCHAR(80)", EFieldName.Nombre_Archivo, ECategory.Sistema, EBCategory.System, EBFieldType.FileName, " \n\r \n\r ") },
            {EFieldName.Ruta_Directorio, new FieldType("Ruta_Directorio", "VARCHAR(80)", EFieldName.Ruta_Directorio, ECategory.Sistema, EBCategory.System, EBFieldType.DirectoryPath, " \n\r \n\r ") },
            {EFieldName.Ruta_Archivo, new FieldType("Ruta_Archivo", "VARCHAR(80)", EFieldName.Ruta_Archivo, ECategory.Sistema, EBCategory.System, EBFieldType.FilePath, " \n\r \n\r ") },
            {EFieldName.Tipo_MIME, new FieldType("Tipo_MIME", "VARCHAR(80)", EFieldName.Tipo_MIME, ECategory.Sistema, EBCategory.System, EBFieldType.MimeType, " \n\r \n\r ") },
            {EFieldName.Tipo_Archivo, new FieldType("Tipo_Archivo", "VARCHAR(80)", EFieldName.Tipo_Archivo, ECategory.Sistema, EBCategory.System, EBFieldType.FileType, " \n\r \n\r ") },
            {EFieldName.Extension_Archivo, new FieldType("Extension_Archivo", "VARCHAR(80)", EFieldName.Extension_Archivo, ECategory.Sistema, EBCategory.System, EBFieldType.FileExt, " \n\r \n\r ") },
            {EFieldName.Version, new FieldType("Version", "VARCHAR(80)", EFieldName.Version, ECategory.Sistema, EBCategory.System, EBFieldType.Version, " \n\r \n\r ") },
            {EFieldName.Excepcion, new FieldType("Excepcion", "VARCHAR(80)", EFieldName.Excepcion, ECategory.Sistema, EBCategory.System, EBFieldType.Exception, " \n\r \n\r ") },
            {EFieldName.AndroidId, new FieldType("AndroidId", "VARCHAR(80)", EFieldName.AndroidId, ECategory.Sistema, EBCategory.System, EBFieldType.AndroidId, " \n\r \n\r ") },
            {EFieldName.ApplePushToken, new FieldType("ApplePushToken", "VARCHAR(80)", EFieldName.ApplePushToken, ECategory.Sistema, EBCategory.System, EBFieldType.ApplePushToken, " \n\r \n\r ") },
            {EFieldName.Pin_BlackBerry, new FieldType("Pin_BlackBerry", "VARCHAR(80)", EFieldName.Pin_BlackBerry, ECategory.Sistema, EBCategory.System, EBFieldType.BlackBerryPin, " \n\r \n\r ") },
            #endregion
            #region Vehicle
            {EFieldName.Vin, new FieldType("Vin", "VARCHAR(80)", EFieldName.Vin, ECategory.Vehiculo, EBCategory.Vehicle, EBFieldType.Vin, " \n\r \n\r ") },
            {EFieldName.Fabricante, new FieldType("Fabricante", "VARCHAR(80)", EFieldName.Fabricante, ECategory.Vehiculo, EBCategory.Vehicle, EBFieldType.Manufacturer, " \n\r \n\r ") },
            {EFieldName.Modelo, new FieldType("Modelo", "VARCHAR(80)", EFieldName.Modelo, ECategory.Vehiculo, EBCategory.Vehicle, EBFieldType.Model, " \n\r \n\r ") },
            {EFieldName.Combustible, new FieldType("Combustible", "VARCHAR(80)", EFieldName.Combustible, ECategory.Vehiculo, EBCategory.Vehicle, EBFieldType.Fuel, " \n\r \n\r ") },
            #endregion
            #region Random
            {EFieldName.Numero, new FieldType("Numero", "INT", EFieldName.Numero,  ECategory.Aleatorio, EBCategory.Random, EBFieldType.Number, " \n\r \n\r ") },
            {EFieldName.Hash, new FieldType("Hash", "VARCHAR(40)", EFieldName.Hash, ECategory.Aleatorio, EBCategory.Random, EBFieldType.Hash, "caa91af303ffaa575b63874fd4bfd302b498a3a3") },
            {EFieldName.Booleano_DB, new FieldType("Bool", "BIT", EFieldName.Booleano_DB, ECategory.Aleatorio, EBCategory.Random, EBFieldType.BoolDB, "1\n\r0\n\rNull") },
            {EFieldName.Booleano, new FieldType("Bool", "BIT", EFieldName.Booleano, ECategory.Aleatorio, EBCategory.Random, EBFieldType.Bool, "True\n\rFalse") },
            #endregion                                                                                                      
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
