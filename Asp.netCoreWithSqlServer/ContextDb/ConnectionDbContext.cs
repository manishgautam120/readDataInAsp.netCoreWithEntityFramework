using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Asp.netCoreWithSqlServer.Models;

namespace Asp.netCoreWithSqlServer.ContextDb
{
    public class ConnectionDbContext :DbContext
    {
        public ConnectionDbContext(DbContextOptions<ConnectionDbContext> options):base(options)
        {

        }
        public DbSet<Customer> Customer { get; set; }
    }
}
