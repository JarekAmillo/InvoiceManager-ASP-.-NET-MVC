using InvoiceManager_ASP.NET_MVC.Models.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InvoiceManager_ASP.NET_MVC.Models.Repositories
{
    public class ProductRepository
    {
        public List<Product> GetProducts()
        {
            using (var context = new ApplicationDbContext())
            {
                return context.Products.ToList();
            }
        }



        internal Product GetProduct(int productId)
        {
            using (var context = new ApplicationDbContext())
            {
                return context.Products.Single(x => x.Id == productId);
            }
        }
    }
}