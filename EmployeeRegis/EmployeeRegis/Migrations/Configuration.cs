namespace EmployeeRegis.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EmployeeRegis.DataAccessLayer.RegisterContext.StorageContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EmployeeRegis.DataAccessLayer.RegisterContext.StorageContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.employee.AddOrUpdate(Id> ne,
                new Employee()
                {
                    Id = 123,
                    FirstName = "John",
                    LastName = "Helman",
                    Salary = 2000,
                    Postion = "Saleman",
                    Department = "Women Dress"
                },

                new Employee()
                {
                    Id = 33,
                    FirstName = "Oscar",
                    LastName = "Jakob",
                    Salary = 300,
                    Postion = "Boss",
                    Department = "Kids Dress"
                },

                new Employee()
                {
                    Id = 1,
                    FirstName = "Dimitris",
                    LastName = "Unnone",
                    Salary = 5,
                    Postion = "Cash Keeper",
                    Department = "Men Dress"
                });

        }
    }
}
