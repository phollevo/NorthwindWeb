
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
        public bool delete(int id)
        {
            var context = new DatabaseContext();
            context.Suppliers.Remove(getSupplier(id));
            return true;
        }

        public Libraries.Supplier getSupplier(int Id)
        {
            var context = new DatabaseContext();
            return context.Suppliers.Find(Id);
            
        }

        public bool modify(Libraries.Supplier supplier)
        {
            var context = new DatabaseContext();
            context.Suppliers.Remove(getSupplier(supplier.id));
            context.Suppliers.Add(supplier);
            return true;
        }

        public List<Libraries.Supplier> searchSuppliers(string pattern)
        {
            var context = new DatabaseContext();
            return context.Suppliers.Where(c => c.name.Contains(pattern)).ToList<Libraries.Supplier>();
        }

        public Libraries.Supplier seeDetails(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
