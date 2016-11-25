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
        NorthwindEntities context = new NorthwindEntities();

        public bool addProduct(Libraries.Product product)
        {
            context.Products.Add(getNorthProduct(product));
            return true;
        }

        public bool delete(long id)
        {
            context.Products.Remove(getNorthProduct(getProduct(id)));
            return true;
        }

        public Libraries.Product getProduct(long Id)
        {
            return getLibProduct(context.Products.Find(Id));
        }

        public bool modify(Libraries.Product product)
        {
            context.Products.Remove(getNorthProduct(getProduct(product.id)));
            context.Products.Add(getNorthProduct(product));
            return true;
        }

        public List<Libraries.Product> searchProducts(string pattern)
        {
            List<Product> myList = context.Products.Where(c => c.ProductName.Contains(pattern)).ToList<Product>();
            List<Libraries.Product> returnList = new List<Libraries.Product>();
            foreach (Product cat in myList)
            {
                returnList.Add(getLibProduct(cat));
            }
            return returnList;
        }

        public Libraries.Product seeDetails(long Id)
        {
            return getLibProduct(context.Products.Find(Id));
        }

        public Libraries.Product getLibProduct(NorthWindServices.Product northProduct)
        {
            return new Libraries.Product
            {
                categorie = (long) northProduct.CategoryID,
                discontinued = northProduct.Discontinued,
                id = northProduct.ProductID,
                name = northProduct.ProductName,
                quantityPerUnit = northProduct.QuantityPerUnit,
                reorderLevel =(long) northProduct.ReorderLevel,
                supplier =(long) northProduct.SupplierID,

            };
        }

        public NorthWindServices.Product getNorthProduct(Libraries.Product product)
        {
            return new Product
            {
                CategoryID = product.categorie,
                Discontinued = product.discontinued,
                ProductID = product.id,
                ProductName = product.name,
                QuantityPerUnit = product.quantityPerUnit,
                ReorderLevel = product.reorderLevel,
                SupplierID = product.supplier
            };
        }
    }
}
