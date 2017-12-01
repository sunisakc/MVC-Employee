using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EmployeeRegisterApp.DataAccessLayer
{
    public class RegisterContext : DbContext
    {
        public RegisterContext() : base("DefaultConnection")
        { }
        public DbSet<Models.Employee> Employees { get; set; }
    }
}