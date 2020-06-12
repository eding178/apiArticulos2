using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace apiArticulos.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options): base(options)
        {
        }

        public DbSet<Article> article { get; set; }
        public DbSet<Store> Store { get; set; }
    }
}
