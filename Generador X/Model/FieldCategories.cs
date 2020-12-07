using System;
using System.Collections.Generic;
using System.Text;

namespace Generador_X.Model
{
    public class FieldCategories
    {
        //public static List<Category> Categories = new List<Category>
        //{
        //    new Category("Fecha", "Date"),
        //    new Category("Nombre", "Name")
        //};

        public static Dictionary<string, Category> Categories = new Dictionary<string, Category>
        {
            {"Basico", new Category("Basico", "")},
            {"Fecha", new Category("Fecha", "Date")},
            {"Nombre", new Category("Nombre", "Name")},
        };

    }

    public class Category
    {
        public string SearchName;
        public string BName;

        public Category(string searchname, string Bname)
        {
            this.SearchName = searchname;
            this.BName = Bname;
        }
    }


}
