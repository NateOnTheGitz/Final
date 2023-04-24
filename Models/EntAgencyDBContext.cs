using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public class EntAgencyDBContext : DbContext
    {
        public EntAgencyDBContext(DbContextOptions<EntAgencyDBContext> options) : base (options)
        {

        }

        public DbSet<Entertainer> Entertainers { get; set; }
    }
}
