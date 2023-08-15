using System;
using MySql.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using shopEntities.Concrete;
using Core.Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class ShopContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=sirius;user=root;password=4561TaKo");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<User> Users{ get; set; }
        public DbSet<UserOperations> UserOperations { get; set; }
        public DbSet<UserPermissions> UserPermissions { get; set; }

    }
}

