using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Asp.netCoreWithSqlServer.Models
{
    public class Customer
    {
        [Key]
        public int  ID { get; set; }
        public string  FirstName { get; set; }
        public string LastName { get; set; }
        public int  Age { get; set; }
    }
}
