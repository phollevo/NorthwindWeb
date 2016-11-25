using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Libraries;

namespace NorthWindServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProductService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ProductService.svc or ProductService.svc.cs at the Solution Explorer and start debugging.
    public class ProductService : IProduct
    {
        DatabaseContext context = new DatabaseContext();

        public bool addProduct(Libraries.Product product)
        {
            context.Products.Add(product);
            return true;
        }

        public bool delete(int id)
        {
            context.Products.Remove(getProduct(id));
            return true;
        }

        public Libraries.Product getProduct(int Id)
        {
            return context.Products.Find(Id);
        }

        public bool modify(Libraries.Product product)
        {
            context.Products.Remove(getProduct(product.id));
            context.Products.Add(product);
            return true;
        }

        public List<Libraries.Product> searchProducts(string pattern)
        {
            return context.Products.Where(c => c.name.Contains(pattern)).ToList<Libraries.Product>();
        }

        public Libraries.Product seeDetails(int Id)
        {
            return context.Products.Find(Id);
        }
    }
}
