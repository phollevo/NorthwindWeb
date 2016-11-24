using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Libraries
{
    public interface ICategorie
    {
        [OperationContract]
        Categorie getCategorie(int Id);

        [OperationContract]
        List<Categorie> searchCategories(string pattern);

        [OperationContract]
        Categorie seeDetails(int Id);

        [OperationContract]
        Boolean modify(Categorie categorie);

        [OperationContract]
        Boolean delete(int id);
    }
}
