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
        Supplier getSupplier(int Id);

        [OperationContract]
        List<Supplier> searchSuppliers(string pattern);

        [OperationContract]
        Supplier seeDetails(int Id);

        [OperationContract]
        Boolean modify(Supplier supplier);

        [OperationContract]
        Boolean delete(int id);
    }
}
