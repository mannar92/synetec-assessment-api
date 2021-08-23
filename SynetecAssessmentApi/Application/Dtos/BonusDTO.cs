namespace SynetecAssessmentApi.Application.Dtos
{
    public class BonusDTO
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }
        public string JobTitle { get; set; }
        public string Department { get; set; }
        public decimal BonusAmount { get; set; }
    }
}
