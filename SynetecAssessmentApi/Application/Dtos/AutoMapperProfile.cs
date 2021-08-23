using AutoMapper;
using SynetecAssessmentApi.Domain.AggregatesModel.BonusPoolAggregate;

namespace SynetecAssessmentApi.Application.Dtos
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Employee, BonusDTO>()
                .ForMember(dest => dest.EmployeeName, source => source.MapFrom(source => source.Name))
                .ForMember(dest => dest.EmployeeSurname, source => source.MapFrom(source => source.Surname))
                .ForMember(dest => dest.EmployeeId, source => source.MapFrom(source => source.Id))
                .ForMember(dest => dest.JobTitle, source => source.MapFrom(source => source.JobTitleId))
                .ForMember(dest => dest.Department, source => source.MapFrom(source => source.DepartmentId));

            CreateMap<Department, BonusDTO>()
                .ForMember(dest => dest.Department, source => source.MapFrom(source => source.Title));

            CreateMap<JobTitle, BonusDTO>()
                .ForMember(dest => dest.JobTitle, source => source.MapFrom(source => source.Title));
        }
    }
}
