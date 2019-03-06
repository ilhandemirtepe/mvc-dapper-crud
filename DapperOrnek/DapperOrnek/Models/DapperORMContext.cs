using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace DapperOrnek.Models
{
    public class DapperORMContext : DbContext
    {
        public DapperORMContext() : base("name=DapperORMContext")
        {
        }

        public DbSet<User> Users { get; set; }

    }
}