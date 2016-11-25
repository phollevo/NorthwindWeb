using Libraries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NorthWindServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CategorieService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CategorieService.svc or CategorieService.svc.cs at the Solution Explorer and start debugging.
    public class CategorieService : ICategorie
    {
        NorthwindEntities secondContext = new NorthwindEntities();
        public bool delete(long id)
        {

            secondContext.Categories.Remove(getNorthCategory(getCategorie(id)));
            return true;
        }

        public Categorie getCategorie(long Id)
        {
            return getLibCategorie(secondContext.Categories.Find(Id));

        }

        public bool modify(Libraries.Categorie categorie)
        {
            secondContext.Categories.Remove(getNorthCategory(getCategorie(categorie.id)));
            secondContext.Categories.Add(getNorthCategory(categorie));
            return true;
        }

        public List<Libraries.Categorie> searchCategories(string pattern)
        {
            List<Category> myList=secondContext.Categories.Where(c => c.CategoryName.Contains(pattern)).ToList<Category>();
            List<Categorie> returnList= new List<Categorie>();
            foreach(Category cat in myList)
            {
                returnList.Add(getLibCategorie(cat));
            }
            return returnList;
        }

        public Libraries.Categorie seeDetails(long Id)
        {
            return getLibCategorie(secondContext.Categories.Find(Id));
        }

        public Libraries.Categorie getLibCategorie(Category northCategorie)
        {
            return new Categorie
            {
                description = northCategorie.Description,
                id = northCategorie.CategoryID,
                name = northCategorie.CategoryName
            };
        }

        public Category getNorthCategory(Categorie categorie)
        {
            return new Category
            {
                CategoryID = categorie.id,
                CategoryName = categorie.name,
                Description = categorie.description
            };
        }
    }
}
