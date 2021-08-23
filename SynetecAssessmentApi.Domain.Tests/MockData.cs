using SynetecAssessmentApi.Domain.AggregatesModel.BonusPoolAggregate;
using System.Collections.Generic;

namespace SynetecAssessmentApi.Domain.Tests
{
    public class MockData
    {
        public readonly ICollection<Employee> MockEmployees;
        public readonly ICollection<Department> MockDepartments;
        public readonly ICollection<JobTitle> MockJobTitles;

        public MockData()
        {
            MockEmployees = InitMockEmployees();
            MockDepartments = InitMockDepartments();
            MockJobTitles = InitMockJobTitles();
        }
        
        private ICollection<Employee> InitMockEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee(1, "John", "Smith", 1, 60000, 1));
            employees.Add(new Employee(2, "Janet", "Jones", 2, 90000, 2));
            employees.Add(new Employee(3, "Robert", "Rinser", 3, 95000, 3));
            employees.Add(new Employee(4, "Jilly", "Thornton", 4, 55000, 4));
            employees.Add(new Employee(5, "Gemma", "Jones", 5, 45000, 4));
            employees.Add(new Employee(6, "Peter", "Bateman", 6, 35000, 3));
            employees.Add(new Employee(7, "Azimir", "Smirkov", 7, 62500, 4));
            employees.Add(new Employee(8, "Penelope", "Scunthorpe", 8, 38750, 4));
            employees.Add(new Employee(9, "Amil", "Kahn", 6, 36000, 3));
            employees.Add(new Employee(10, "Joe", "Masters", 6, 36500, 3));
            employees.Add(new Employee(11, "Paul", "Azgul", 9, 53000, 2));
            employees.Add(new Employee(12, "Jennifer", "Smith", 10, 48000, 1));
            return employees;
        }

        private ICollection<Department> InitMockDepartments()
        {
            List<Department> departments = new List<Department>();
            departments.Add(new Department(1, "Finance", "The finance department for the company"));
            departments.Add(new Department(2, "Human Resources", "The Human Resources department for the company"));
            departments.Add(new Department(3, "IT", "The IT support department for the company"));
            departments.Add(new Department(4, "Marketing", "The Marketing department for the company"));
            return departments;
        }

        private ICollection<JobTitle> InitMockJobTitles()
        {
            List<JobTitle> jobTitles = new List<JobTitle>();
            jobTitles.Add(new JobTitle(1, "Accountant (Senior)", "The Accountant (Senior) of the company"));
            jobTitles.Add(new JobTitle(2, "HR Director", "The HR Director of the company"));
            jobTitles.Add(new JobTitle(3, "IT Director", "The IT Director of the company"));
            jobTitles.Add(new JobTitle(4, "Marketing Manager (Senior)", "The Marketing Manager (Senior) of the company"));
            jobTitles.Add(new JobTitle(5, "Marketing Manager (Junior)", "The Marketing Manager (Junior) of the company"));
            jobTitles.Add(new JobTitle(6, "IT Support Engineer", "The IT Support Engineer of the company"));
            jobTitles.Add(new JobTitle(7, "Creative Director", "The Creative Director of the company"));
            jobTitles.Add(new JobTitle(8, "Creative Assistant", "The Creative Assistant of the company"));
            jobTitles.Add(new JobTitle(9, "HR Manager", "The HR Manager of the company"));
            jobTitles.Add(new JobTitle(10, "Accountant (Junior)", "The Accountant (Junior) of the company"));
            return jobTitles;
        }
    }
}
