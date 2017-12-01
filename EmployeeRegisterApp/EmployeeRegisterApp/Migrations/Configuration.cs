namespace EmployeeRegisterApp.Migrations
{
    using EmployeeRegisterApp.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EmployeeRegisterApp.DataAccessLayer.RegisterContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EmployeeRegisterApp.DataAccessLayer.RegisterContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Employees.AddOrUpdate(n => n.FirstName,
                 new Employee()
                 {
                   
                     FirstName = "John",
                     LastName = "Helman",
                     Salary = 2000,
                     Position = "Teacher",
                     Department = "Computer"
                 },

                new Employee()
                {
                  
                    FirstName = "Oscar",
                    LastName = "Jakob",
                    Salary = 300,
                    Position = "Boss",
                    Department = "Coordinator"
                },

                new Employee()
                {
                  
                    FirstName = "Dimitris",
                    LastName = "Unnone",
                    Salary = 5,
                    Position = "Teacher",
                    Department = "Computer"

                });


               



        }
    }
}
