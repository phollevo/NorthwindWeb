using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Libraries
{
    [ServiceContract]
    public interface ISupplier
    {
        [OperationContract]
        bool addSupplier(Supplier supplier);

        [OperationContract]
        Supplier getSupplier(long Id);

        [OperationContract]
        List<Supplier> searchSuppliers(string pattern);

        [OperationContract]
        Supplier seeDetails(long Id);

        [OperationContract]
        Boolean modify(Supplier supplier);

        [OperationContract]
        Boolean delete(long id);
    }
}
