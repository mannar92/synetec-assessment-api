using AutoMapper;
using SynetecAssessmentApi.Application.Dtos;
using SynetecAssessmentApi.Domain.AggregatesModel.BonusPoolAggregate;
using SynetecAssessmentApi.Domain.SeedWork;
using SynetecAssessmentApi.Persistence.Exceptions.CustomExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SynetecAssessmentApi.Application.Services
{
    public class BonusService : IBonusService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IEmployeeRepository _employeeRepository;

        public BonusService(
            IMapper mapper,
            IUnitOfWork unitOfWork,
            IEmployeeRepository employeeRepository
        )
        {
            _mapper = mapper;
            _employeeRepository = employeeRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<List<BonusDTO>> GetAllBonuses(BonusRequestDTO bonusRequest)
        {
            try
            {
                List<BonusDTO> allBonuses = new List<BonusDTO>();

                BonusPool bonusPool = await CreateBonusPool(bonusRequest);

                foreach (Employee e in bonusPool.Employees)
                {
                    try
                    {
                        decimal bonusAmount = bonusPool.CalculateBonus(e.Id);
                        BonusDTO employeeBonus = _mapper.Map<BonusDTO>(e);
                        employeeBonus.BonusAmount = bonusAmount;
                        allBonuses.Add(employeeBonus);
                    }
                    catch (Exception ex)
                    {
                        throw new BonusCalculationException(ex.Message);
                    }
                }

                return allBonuses;
            }
            catch (BonusCalculationException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<BonusDTO> GetBonusById(int EmployeeId, BonusRequestDTO bonusRequest)
        {
            try
            {
                BonusDTO employeeBonus = null;

                Employee findEmployee = await _employeeRepository.GetByIdAsync(EmployeeId);

                if (findEmployee != null)
                {
                    BonusPool bonusPool = await CreateBonusPool(bonusRequest);

                    try
                    {
                        decimal bonusAmount = bonusPool.CalculateBonus(EmployeeId);
                        employeeBonus = _mapper.Map<BonusDTO>(findEmployee);
                        employeeBonus.BonusAmount = bonusAmount;
                    }
                    catch (Exception ex)
                    {
                        throw new BonusCalculationException(ex.Message);
                    }

                }

                return employeeBonus;
            }
            catch (EmployeeNotFoundException)
            {
                throw;
            }
            catch (BonusCalculationException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private async Task<BonusPool> CreateBonusPool(BonusRequestDTO bonusRequest)
        {
            IEnumerable<Employee> employees = await _employeeRepository.GetAllAsync();
            List<Employee> employeesList = employees.ToList();
            return new BonusPool(bonusRequest.totalProfit, bonusRequest.bonusPercentage, employeesList);
        }
    }
}
