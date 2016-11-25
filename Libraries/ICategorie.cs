using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Libraries
{
    [ServiceContract]
    public interface ICategorie
    {
        [OperationContract]
        Categorie getCategorie(long Id);

        [OperationContract]
        List<Categorie> searchCategories(string pattern);

        [OperationContract]
        Categorie seeDetails(long Id);

        [OperationContract]
        Boolean modify(Categorie categorie);

        [OperationContract]
        Boolean delete(long id);
    }
}
