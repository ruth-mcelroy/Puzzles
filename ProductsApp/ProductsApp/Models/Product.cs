using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductsApp.Models        // model represents the data in you application, this is serialised to xml or json by the asp.net web api. The client app then has to be able to parse xml or json.
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price{get; set; }
    }
}