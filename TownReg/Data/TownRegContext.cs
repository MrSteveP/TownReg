using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TownReg.Models;

namespace TownReg.Data
{
    public class TownRegContext : DbContext
    {
        public TownRegContext (DbContextOptions<TownRegContext> options)
            : base(options)
        {
        }

        public DbSet<TownReg.Models.Person> Person { get; set; }
    }
}
