using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class DictionaryContext : DbContext
    {
        public DbSet<Category>  Categories { get; set; }

        public DbSet<Word> Words { get; set; }

        public DbSet<Admin> Admins { get; set; }

        public DbSet<About> Abouts { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=FATMA-NUR56;Initial Catalog=DictionaryDb;Integrated Security=True;");
        }

        
    }
}
