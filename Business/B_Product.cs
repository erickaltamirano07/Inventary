using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Business
{
    public class B_Product
    {
        public List<ProductEntity>productsList()
        {
            using(var db = new InventaryContext ())
            {
                return db.Products.ToList();
            }
        }

        public void CreateProduct(ProductEntity product)
        {
            using (var db = new InventaryContext())
            {
                db.Products.Add(product);
                db.SaveChanges();
            }
        }

        public void UpdateProduct(ProductEntity product)
        {
            using(var db= new InventaryContext())
            {
                db.Products.Update(product);
                db.SaveChanges();
            }
        }

        public void RemoveProduct(ProductEntity product)
        {
            using (var db = new InventaryContext())
            {
                db.Products.Remove(product);
                db.SaveChanges();
            }
        }
    }
}
