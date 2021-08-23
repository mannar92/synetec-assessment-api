using SynetecAssessmentApi.Domain.SeedWork;
using SynetecAssessmentApi.SeedWork.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SynetecAssessmentApi.Domain.AggregatesModel.BonusPoolAggregate
{
    public class BonusPool : Entity, IAggregateRoot
    {
        public DateTime PoolDate { get; private set; }
        public IReadOnlyCollection<Employee> Employees => _employees;

        private decimal _totalCompanyProfit;

        [Range(0, 1, ErrorMessage = "The field {0} must be between 0.00 and 1.00.")]
        private decimal _profitToBonusPercentage;

        private decimal _totalSalaryBudget;
        private readonly List<Employee> _employees = new List<Employee>();

        public BonusPool (
            decimal totalCompanyProfit,
            decimal profitToBonusPercentage,
            List<Employee> employees
        ) {
            if (totalCompanyProfit <= 0)
            {
                throw new Exception("Total company profit must be greater than zero before assigning bonus to empoyees.");
            }

            if (profitToBonusPercentage < 0 || profitToBonusPercentage > 1)
            {
                throw new Exception("Invalid percentage value, try a value between 0.00 and 1.00.");
            }

            PoolDate = DateTime.Now;
            _employees.AddRange(employees);
            _totalCompanyProfit = totalCompanyProfit;
            _profitToBonusPercentage = profitToBonusPercentage;
            _totalSalaryBudget = CalculateTotalSalary();
        }

        public void AddEmployees(List<Employee> employees)
        {
            _employees.AddRange(employees);
        }

        public decimal CalculateBonus(int employeeId)
        {
            decimal bonus = 0;
            decimal bonusPoolAmount = _profitToBonusPercentage * _totalCompanyProfit;

            Employee findEmployee = _employees.Find(e => e.Id == employeeId);

            if (findEmployee != null)
            {
                decimal salary = findEmployee.Salary;
                decimal employeeBonusPercentage = salary / _totalSalaryBudget;
                bonus = employeeBonusPercentage * bonusPoolAmount;
            } else
            {
                string exceptionMessage = "Employee ID " + employeeId.ToString() + " was not found.";
                throw new Exception(exceptionMessage);
            }

            return bonus;
        }

        public decimal CalculateTotalSalary()
        {
            return _employees.Sum(e => e.Salary); ;
        }
    }
}
