using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mod04_09.DAL;

namespace Mod04_09.Models
{
    public class ProductSystem
    {

        public Product GetProductByID(int id)
        {
            NorthwindEntities db = new NorthwindEntities();
            //var query = from p in db.Products
            //            where p.ProductID == id
            //            select p;
            var result = db.Products.Find(id);

            return result;
        }

        public IEnumerable<Product> GetProductsByCategryID(int id)
        {
            NorthwindEntities db = new NorthwindEntities();
            var query = from p in db.Products
                        where p.CategoryID == id
                        select p;
            var result = query.ToList();

            return result;
        }
    }
}