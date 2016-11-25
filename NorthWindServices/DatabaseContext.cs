﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NorthWindServices
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
            :base("name=DatabaseContext")
        {

        }

        public virtual DbSet<Libraries.Supplier> Suppliers { get; set; }
        public virtual DbSet<Libraries.Categorie> Categories { get; set; }
        public virtual DbSet<Libraries.Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}