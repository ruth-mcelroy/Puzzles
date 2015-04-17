using ProductsApp.Models;       //using model class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductsApp.Controllers       //a controller handles http requests
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]          //In reality this would take data from a database
        { 
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 }, 
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M }, 
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M } 
        };




        public IEnumerable<Product> GetAllProducts()        //The GetAllProducts method returns the entire list of products as an IEnumerable<Product> type.
        {
            return products;
        }


        
        public IHttpActionResult GetProduct(int id)        //The GetProduct method looks up a single product by its ID. 
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

    }
}
