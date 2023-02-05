using AutoMapper;
using EmployeeAttendanceWebApp.Application.Common.Dtos;
using EmployeeAttendanceWebApp.Application.Employee.Commands.Create;
using EmployeeAttendanceWebApp.Application.Employee.Commands.Update;
using EmployeeAttendanceWebApp.Application.EmployeeAttendance.Commands.Create;

using System;
using System.Linq;
using System.Reflection;

namespace EmployeeAttendanceWebApp.Application.Common.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            ApplyMappingsFromAssembly(Assembly.GetExecutingAssembly());
            CreateMap<CreateEmployeeCommand, Domain.Entities.Employee>()
                     .ForMember(dest => dest.Name, opt => opt.MapFrom(s => s.Name))
                     .ForMember(dest => dest.Email, opt => opt.MapFrom(s => s.Email))
                     .ForMember(dest => dest.PhoneNo, opt => opt.MapFrom(s => s.Phone)).ReverseMap();
            CreateMap<UpdateEmployeeCommand, Domain.Entities.Employee>()
                .ForMember(dest => dest.EMPID, opt => opt.MapFrom(s => s.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(s => s.Name))
                     .ForMember(dest => dest.Email, opt => opt.MapFrom(s => s.Email))
                     .ForMember(dest => dest.PhoneNo, opt => opt.MapFrom(s => s.Phone)).ReverseMap();
            CreateMap<EmployeeAttendanceDto, Domain.Entities.EmployeeAttendance>()
             .ReverseMap();
            CreateMap<EmployeeDto, Domain.Entities.Employee>()
                   .ForMember(dest => dest.EMPID, opt => opt.MapFrom(s => s.EMPID))
                   .ForMember(dest => dest.Name, opt => opt.MapFrom(s => s.Name))
                     .ForMember(dest => dest.Email, opt => opt.MapFrom(s => s.Email))
                     .ForMember(dest => dest.PhoneNo, opt => opt.MapFrom(s => s.PhoneNo)).ReverseMap();
            CreateMap<CreateEmployeeAttendanceCommand, Domain.Entities.EmployeeAttendance>()
            .ForMember(dest => dest.EMPID, opt => opt.MapFrom(s => s.EMPID))
            .ForMember(dest => dest.DEVUID, opt => opt.MapFrom(s => s.DEVUID))
              .ForMember(dest => dest.EVETLGUID, opt => opt.MapFrom(s => s.EVETLGUID))
              .ReverseMap();
        //    CreateMap<UpdateEmployeeAttendanceCommand, Domain.Entities.EmployeeAttendance>()
        //.ForMember(dest => dest.EMPID, opt => opt.MapFrom(s => s.EMPID))
        //.ForMember(dest => dest.Id, opt => opt.MapFrom(s => s.Id))
        //.ForMember(dest => dest.DEVUID, opt => opt.MapFrom(s => s.DEVUID))
        //  .ForMember(dest => dest.EVETLGUID, opt => opt.MapFrom(s => s.EVETLGUID))
        //  .ReverseMap();
        }

        private void ApplyMappingsFromAssembly(Assembly assembly)
        {
            var types = assembly.GetExportedTypes().Where(t => t.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IMapFrom<>))).ToList();
            foreach (var type in types)
            {
                var instance = Activator.CreateInstance(type);
                var methodInfo = type.GetMethod("Mapping");
                methodInfo?.Invoke(instance, new object[] { this });
            }
        }
    }
}
