using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Libraries
{
    [ServiceContract]
    public interface IProduct
    {
        [OperationContract]
        Product getProduct(long Id);

        [OperationContract]
        List<Product> searchProducts(string pattern);

        [OperationContract]
        Product seeDetails(long Id);

        [OperationContract]
        Boolean modify(Product product);

        [OperationContract]
        bool addProduct(Product product);

        [OperationContract]
        Boolean delete(long id);
    }
}
