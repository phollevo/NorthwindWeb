
using Libraries;
using System;
using System.Collections.Generic;


namespace NorthWindServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SupplierService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SupplierService.svc or SupplierService.svc.cs at the Solution Explorer and start debugging.
    public class SupplierService : ISupplier
    {
        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool modify(Libraries.Supplier supplier)
        {
            throw new NotImplementedException();
        }

        public List<Libraries.Supplier> searchSuppliers()
        {
            throw new NotImplementedException();
        }

        public Libraries.Supplier seeDatails(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
