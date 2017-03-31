using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthWind_WebAPI.Models
{
    public class CategoriesViewModel
    {
        public int CategoryID{ get; set; }
        public string CategoryName{ get; set; }

    }

    public class ProductsViewModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
    }
}