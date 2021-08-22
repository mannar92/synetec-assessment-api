using SynetecAssessmentApi.Domain.SeedWork;
using SynetecAssessmentApi.SeedWork.Domain;

namespace SynetecAssessmentApi.Domain.AggregatesModel.BonusPoolAggregate
{
    public class Employee : Entity
    {
        public string Fullname { get; private set; }
        public string JobTitle { get; private set; }

        private int _departmentId;
        private int _salary;


        public Employee(
            int id,
            string fullname,
            string jobTitle,
            int salary,
            int departmentId)
        {
            Id = id;
            Fullname = fullname;
            JobTitle = jobTitle;
            _salary = salary;
            _departmentId = departmentId;
        }

        
    }
}
