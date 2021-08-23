using SynetecAssessmentApi.Application.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SynetecAssessmentApi.Application.Services
{
    public interface IBonusService
    {
        Task<List<BonusDTO>> GetAllBonuses(BonusRequestDTO bonusRequest);
        Task<BonusDTO> GetBonusById(int employeeId, BonusRequestDTO bonusRequest);
    }
}
