using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioConv.Repository
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options)
            : base(options)
        {

        }
        public DbSet<Borders.Entities.Produto> Produto { get; set; }
    }
}
