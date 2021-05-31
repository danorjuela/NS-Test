using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace NSDataAccess.Context
{
    public class NSContext : DbContext
    {
        public NSContext (DbContextOptions<NSContext> options)
            : base(options)
        {

        }

        public DbSet<Models.Fligth> Fligths { get; set; }
        public DbSet<Models.Transport> Transports { get; set; }
    }



}
