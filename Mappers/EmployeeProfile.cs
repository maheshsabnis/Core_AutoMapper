using AutoMapper;
using Core_AutoMapper.Models;
using Core_AutoMapper.ViewModels;

namespace Core_AutoMapper.Mappers
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            // CreateMap<Employee,EmployeeViewModel>();
            CreateMap<Employee, EmployeeViewModel>()
                .ForMember(dest=>dest.EmpName,opt=>opt.MapFrom(src=>src.EmpName))
                .ForMember(dest => dest.DeptName, opt => opt.MapFrom(src => src.DeptName))
                .ForMember(dest => dest.Designation, opt => opt.MapFrom(src => src.Designation))
                  .ForMember(dest => dest.Address, opt => opt.MapFrom(src=>src.Address.ToString()))
                ;
        }
    }
}
