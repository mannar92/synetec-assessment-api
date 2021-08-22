using SynetecAssessmentApi.Application.Dtos;
using SynetecAssessmentApi.Domain.SeedWork;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SynetecAssessmentApi.Application.Services
{
    public class BonusService : IBonusService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IEmployeeRepository _employeeRepository;

        public BonusService(
            IUnitOfWork unitOfWork,
            IEmployeeRepository employeeRepository
        )
        {
            _employeeRepository = employeeRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<List<BonusDTO>> GetAllBonuses(BonusRequestDTO bonusRequest)
        {
            List<BonusDTO> allBonuses = new List<BonusDTO>();
            var test = await _employeeRepository.GetAllAsync();
            return null;
        }

        public BonusDTO GetBonusById(int EmployeeId, BonusRequestDTO bonusRequest)
        {
            return new BonusDTO();
        }




        //public async Task<IEnumerable<EmployeeDto>> GetEmployeesAsync()
        //{
        //    IEnumerable<EmployeeModel> employees = await _dbContext
        //        .Employees
        //        .Include(e => e.DepartmentId)
        //        .ToListAsync();

        //    List<EmployeeDto> result = new List<EmployeeDto>();

        //    foreach (var employee in employees)
        //    {
        //        //result.Add(
        //        //    new EmployeeDto
        //        //    {
        //        //        Fullname = employee.Name,
        //        //        JobTitle = employee.JobTitleId,
        //        //        Salary = employee.Salary,
        //        //        Department = new DepartmentDto
        //        //        {
        //        //            Title = employee.Department.Title,
        //        //            Description = employee.Department.Description
        //        //        }
        //        //    });
        //    }

        //    return result;
        //}

        //public async Task<BonusPoolCalculatorResultDto> CalculateAsync(int bonusPoolAmount, int selectedEmployeeId)
        //{
        //    //load the details of the selected employee using the Id
        //    EmployeeModel employee = await _dbContext.Employees
        //        .Include(e => e.DepartmentId)
        //        .FirstOrDefaultAsync(item => item.Id == selectedEmployeeId);

        //    //get the total salary budget for the company
        //    int totalSalary = (int)_dbContext.Employees.Sum(item => item.Salary);

        //    //calculate the bonus allocation for the employee
        //    decimal bonusPercentage = (decimal)employee.Salary / (decimal)totalSalary;
        //    int bonusAllocation = (int)(bonusPercentage * bonusPoolAmount);

        //    return new BonusPoolCalculatorResultDto
        //    {
        //        //Employee = new EmployeeDto
        //        //{
        //        //    Fullname = employee.Name,
        //        //    JobTitle = employee.JobTitleId,
        //        //    Salary = employee.Salary,
        //        //    Department = new DepartmentDto
        //        //    {
        //        //        Title = employee.Department.Title,
        //        //        Description = employee.Department.Description
        //        //    }
        //        //},

        //        Amount = bonusAllocation
        //    };
        //}
    }
}
