using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Asp.netCoreWithSqlServer.ContextDb;
using Asp.netCoreWithSqlServer.Models;

namespace Asp.netCoreWithSqlServer.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ConnectionDbContext _dbcontext;

        public IndexModel(ConnectionDbContext connectionDbContext)
        {
            _dbcontext = connectionDbContext;
        }
        public IEnumerable<Customer> getrecords { get; set; }
        public async Task OnGet()
        {
            getrecords = await _dbcontext.Customer.ToListAsync();
        }
    }
}
