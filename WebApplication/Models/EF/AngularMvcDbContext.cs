using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace WebApplication.Models.EF
{
    public class AngularMvcDbContext : DbContext

    {
        public AngularMvcDbContext() : base("name = UserDb") 
        { 
        
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove < PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<User> Users { get; set; }

      
    }
}