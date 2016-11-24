﻿using Libraries;
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
        public bool delete(int id)
        {
            var context = new DatabaseContext();
            context.Categories.Remove(getCategorie(id));
            return true;
        }

        public Libraries.Categorie getCategorie(int Id)
        {
            var context = new DatabaseContext();
            return context.Categories.Find(Id);

        }

        public bool modify(Libraries.Categorie categorie)
        {
            var context = new DatabaseContext();
            context.Categories.Remove(getCategorie(categorie.id));
            context.Categories.Add(categorie);
            return true;
        }

        public List<Libraries.Categorie> searchCategories(string pattern)
        {
            var context = new DatabaseContext();
            return context.Categories.Where(c => c.name.Contains(pattern)).ToList<Libraries.Categorie>();
        }

        public Libraries.Categorie seeDetails(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
