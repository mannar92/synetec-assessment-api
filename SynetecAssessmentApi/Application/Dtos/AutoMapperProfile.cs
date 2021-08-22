using AutoMapper;
using SynetecAssessmentApi.Domain.AggregatesModel.BonusPoolAggregate;

namespace SynetecAssessmentApi.Application.Dtos
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<BonusDTO, Employee>()
                .ForMember(dest => dest.Name, source => source.MapFrom(source => source.EmployeeName))
                .ForMember(dest => dest.Surname, source => source.MapFrom(source => source.EmployeeSurname))
                .ForMember(dest => dest.Id, source => source.MapFrom(source => source.EmployeeId));
        }
    }
}
