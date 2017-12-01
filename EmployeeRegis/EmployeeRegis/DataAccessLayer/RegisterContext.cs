using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EmployeeRegis.DataAccessLayer
{
    
        public class RegisterContext : DbContext
        {
            public RegisterContext() : base("DefaultConnection")
            { }
            //Dbset set some in to database
            public DbSet<Models.Employee> Employees { get; set; }
        }
    }
}