using Microsoft.Extensions.DependencyInjection;
using SynetecAssessmentApi.Domain.AggregatesModel.BonusPoolAggregate;
using System.Collections.Generic;
using System.Linq;

namespace SynetecAssessmentApi.Persistence.Data.DbContexts.DbInitializer
{
    public class DbInitializer : IDbInitializer
    {
        private readonly IServiceScopeFactory _scopeFactory;

        public DbInitializer(IServiceScopeFactory scopeFactory)
        {
            this._scopeFactory = scopeFactory;
        }

        public void Initialize()
        {
            // initialize if relational db is used
        }

        public void SeedData()
        {
            using (var serviceScope = _scopeFactory.CreateScope())
            {
                using (AppDbContext context = serviceScope.ServiceProvider.GetService<AppDbContext>())
                {
                    SeedJobTitles(context);
                    SeedDepartments(context);
                    SeedEmployees(context);

                    context.SaveChanges();
                }
            }
        }

        private void SeedEmployees(AppDbContext context)
        {
            if (!context.Employees.Any())
            {
                List<Employee> seedEmployees = new List<Employee>();
                seedEmployees.Add(new Employee(1, "John", "Smith", 1, 60000, 1));
                seedEmployees.Add(new Employee(2, "Janet", "Jones", 2, 90000, 2));
                seedEmployees.Add(new Employee(3, "Robert", "Rinser", 3, 95000, 3));
                seedEmployees.Add(new Employee(4, "Jilly", "Thornton", 4, 55000, 4));
                seedEmployees.Add(new Employee(5, "Gemma", "Jones", 5, 45000, 4));
                seedEmployees.Add(new Employee(6, "Peter", "Bateman", 6, 35000, 3));
                seedEmployees.Add(new Employee(7, "Azimir", "Smirkov", 7, 62500, 4));
                seedEmployees.Add(new Employee(8, "Penelope", "Scunthorpe", 8, 38750, 4));
                seedEmployees.Add(new Employee(9, "Amil", "Kahn", 6, 36000, 3));
                seedEmployees.Add(new Employee(10, "Joe", "Masters", 6, 36500, 3));
                seedEmployees.Add(new Employee(11, "Paul", "Azgul", 9, 53000, 2));
                seedEmployees.Add(new Employee(12, "Jennifer", "Smith", 10, 48000, 1));

                context.Employees.AddRange(seedEmployees);
            }
        }

        private void SeedJobTitles(AppDbContext context)
        {
            if (!context.JobTitles.Any())
            {
                List<JobTitle> seedJobTitles = new List<JobTitle>();
                seedJobTitles.Add( new JobTitle(1, "Accountant (Senior)", "The Accountant (Senior) of the company"));
                seedJobTitles.Add( new JobTitle(2, "HR Director", "The HR Director of the company"));
                seedJobTitles.Add( new JobTitle(3, "IT Director", "The IT Director of the company"));
                seedJobTitles.Add( new JobTitle(4, "Marketing Manager (Senior)", "The Marketing Manager (Senior) of the company"));
                seedJobTitles.Add( new JobTitle(5, "Marketing Manager (Junior)", "The Marketing Manager (Junior) of the company"));
                seedJobTitles.Add( new JobTitle(6, "IT Support Engineer", "The IT Support Engineer of the company"));
                seedJobTitles.Add( new JobTitle(7, "Creative Director", "The Creative Director of the company"));
                seedJobTitles.Add( new JobTitle(8, "Creative Assistant", "The Creative Assistant of the company"));
                seedJobTitles.Add( new JobTitle(9, "HR Manager", "The HR Manager of the company"));
                seedJobTitles.Add(new JobTitle(10, "Accountant (Junior)", "The Accountant (Junior) of the company"));
                
                context.JobTitles.AddRange(seedJobTitles);
            }
        }

        private void SeedDepartments(AppDbContext context)
        {
            if (!context.Departments.Any())
            {
                List<Department> seedDepartments = new List<Department>();
                seedDepartments.Add(new Department(1, "Finance", "The finance department for the company"));
                seedDepartments.Add( new Department(2, "Human Resources", "The Human Resources department for the company"));
                seedDepartments.Add( new Department(3, "IT", "The IT support department for the company"));
                seedDepartments.Add(new Department(4, "Marketing", "The Marketing department for the company"));

                context.Departments.AddRange(seedDepartments);
            }
        }
    }
}
