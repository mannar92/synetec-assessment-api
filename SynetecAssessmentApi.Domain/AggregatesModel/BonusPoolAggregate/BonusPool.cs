using SynetecAssessmentApi.Domain.SeedWork;
using SynetecAssessmentApi.SeedWork.Domain;
using System;
using System.Collections.Generic;

namespace SynetecAssessmentApi.Domain.AggregatesModel.BonusPoolAggregate
{
    public class BonusPool : Entity, IAggregateRoot
    {
        private decimal _totalCompanyProfit;

        private DateTime _poolDate;
        private double _bonusPercentage;

        private int _totalSalaryBudget;

        private readonly List<Employee> _employees;
        public IReadOnlyCollection<Employee> Employees => _employees;

        public BonusPool (
            decimal totalCompanyProfit,
            double bonusPercentage
        ) {
            _employees = new List<Employee>();
            _poolDate = DateTime.Now;
            _totalCompanyProfit = totalCompanyProfit;
            _bonusPercentage = bonusPercentage;     
        }

        public void AddEmployees(List<Employee> employees)
        {
            _employees.AddRange(employees);
        }

        public void CalculateBonus(int employeeId)
        {
            Employee findEmployee = _employees.Find(e => e.Id == employeeId);
            if (findEmployee != null)
            {
                // calculate
            } else
            {
                // throw employee not found exception
            }
        }
    }
}
