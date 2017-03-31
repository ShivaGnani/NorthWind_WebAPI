using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NorthWind_WebAPI.Models;


namespace NorthWind_WebAPI.Controllers
{
    public class OrderController : ApiController
    {
        public NORTHWINDEntities db = new NORTHWINDEntities();


        [ActionName("categories")]
        public IEnumerable<CategoriesViewModel> GetCategories()
        {
            return db.Categories.Select(x => new CategoriesViewModel { CategoryID = x.CategoryID, CategoryName = x.CategoryName });
        }

        [ActionName("productsbyid")]
        public IEnumerable<ProductsViewModel> GetProductsByID(int id)
        {
            return db.Products.Where(x => x.CategoryID == id).Select(x => new ProductsViewModel{ ProductID = x.ProductID, ProductName = x.ProductName, UnitPrice = x.UnitPrice });
        }

        [HttpPost]
        public string SaveOrder(Order order)
        {
            return "saved";
        }
    }
}
