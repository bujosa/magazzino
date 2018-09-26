using System;
using System.Collections.Generic;
using System.Text;
using Magazzino.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Magazzino.Repository.Migrations
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet <Sales> SalesInPlurar { get; set; }
        public DbSet <Seller> Sellers { get; set; }
        public DbSet <Product> Products { get; set; }

        public ApplicationContext (DbContextOptions<ApplicationContext> options ) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
