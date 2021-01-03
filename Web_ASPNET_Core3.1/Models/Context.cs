using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_ASPNET_Core3._1.Models
{
    public class Context : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=Web_ASPNET_Core3._1;Integrated Security=True");
        }

        public void SetModified(Category categoria)
        {
            throw new NotImplementedException();
        }

        public void SetModified(Product produto)
        {
            throw new NotImplementedException();
        }
    }
}
