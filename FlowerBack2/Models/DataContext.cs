using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace FlowerBack2.Models
{
    public class DataContext: DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public DbSet<Flower> Flowers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }

}