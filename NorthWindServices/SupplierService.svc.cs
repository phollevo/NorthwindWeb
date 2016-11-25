
using Libraries;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NorthWindServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SupplierService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SupplierService.svc or SupplierService.svc.cs at the Solution Explorer and start debugging.
    public class SupplierService : ISupplier
    {
        NorthwindEntities context = new NorthwindEntities();

        public bool addSupplier(Libraries.Supplier supplier)
        {
            context.Suppliers.Add(getNorthSupplier(supplier));
                return true;
        }

        public bool delete(long id)
        {
            context.Suppliers.Remove(getNorthSupplier(getSupplier(id)));
            return true;
        }

        public Libraries.Supplier getSupplier(long Id)
        {
            return getLibSupplier(context.Suppliers.Find(Id));
        }

        public bool modify(Libraries.Supplier supplier)
        {
            context.Suppliers.Remove(getNorthSupplier(getSupplier(supplier.id)));
            context.Suppliers.Add(getNorthSupplier(supplier));
            return true;
        }

        public List<Libraries.Supplier> searchSuppliers(string pattern)
        {
            List<Supplier> myList= context.Suppliers.Where(c => c.CompanyName.Contains(pattern)).ToList<Supplier>();
            List<Libraries.Supplier> returnList = new List<Libraries.Supplier>();
            foreach(Supplier supp in myList)
            {
                returnList.Add(getLibSupplier(supp));
            }
            return returnList;
        }

        public Libraries.Supplier seeDetails(long Id)
        {
            return getLibSupplier(context.Suppliers.Find(Id));
        }

        public Libraries.Supplier getLibSupplier(Supplier supplier)
        {
            return new Libraries.Supplier
            {
                address = supplier.Address,
                contactName = supplier.ContactName,
                contactTitle = supplier.ContactTitle,
                country = supplier.Country,
                fax = supplier.Fax,
                id = supplier.SupplierID,
                name = supplier.CompanyName,
            };
        }

        public Supplier getNorthSupplier(Libraries.Supplier supplier)
        {
            return new Supplier
            {
                Address = supplier.address,
                ContactName = supplier.contactName,
                ContactTitle = supplier.contactTitle,
                Country = supplier.country,
                Fax = supplier.fax,
                SupplierID = supplier.id,
                CompanyName = supplier.name
            };
        }
    }
}
