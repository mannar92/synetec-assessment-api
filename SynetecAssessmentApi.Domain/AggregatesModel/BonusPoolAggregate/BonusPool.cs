using SynetecAssessmentApi.Domain.SeedWork;
using SynetecAssessmentApi.SeedWork.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SynetecAssessmentApi.Domain.AggregatesModel.BonusPoolAggregate
{
    public class BonusPool : Entity, IAggregateRoot
    {
        public DateTime PoolDate { get; private set; }
        public IReadOnlyCollection<Employee> Employees => _employees;

        private decimal _totalCompanyProfit;
        private decimal _profitToBonusPercentage;
        private decimal _totalSalaryBudget;
        private readonly List<Employee> _employees;

        public BonusPool (
            decimal totalCompanyProfit,
            decimal profitToBonusPercentage,
            List<Employee> employees
        ) {
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
                // throw employee not found exception
            }

            return bonus;
        }

        public decimal CalculateTotalSalary()
        {
            return _employees.Sum(e => e.Salary); ;
        }
    }
}
