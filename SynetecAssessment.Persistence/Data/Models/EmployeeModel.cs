namespace SynetecAssessmentApi.Persistence.Data.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int JobTitleId { get; set; }
        public int Salary { get; set; }
        public int DepartmentId { get; set; }

        public EmployeeModel(
            int id,
            string name,
            string surname,
            int jobTitleId,
            int salary,
            int departmentId)
        {
            Id = id;
            Name = name;
            Surname = surname;
            JobTitleId = jobTitleId;
            Salary = salary;
            DepartmentId = departmentId;
        }
    }
}
