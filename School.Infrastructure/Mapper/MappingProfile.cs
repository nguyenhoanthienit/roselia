using AutoMapper;
using School.Domain.Entities;
using School.Service.Class.Dto;
using School.Service.Schedule.Commands;
using School.Service.Schedule.Dto;
using School.Service.Student.Dto;
using School.Service.Subject.Commands;
using School.Service.Subject.Dto;

namespace School.Infrastructure.Mapper
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			// Class
			CreateMap<ClassDetailDto, ClassEntity>().ReverseMap();

			// Student
			CreateMap<StudentDetailDto, StudentEntity>().ForMember(c => c.Class, opt => opt.Ignore()).ReverseMap();

			// Schedule
			CreateMap<CreateSheduleRequest, ScheduleEntity>().ReverseMap();
			CreateMap<ScheduleDetailDto, ScheduleEntity>().ReverseMap();

			// Subject
			CreateMap<SubjectDetailDto, SubjectEntity>().ReverseMap();
			CreateMap<CreateSubjectRequest, SubjectEntity>().ReverseMap();
			CreateMap<UpdateSubjectRequest, SubjectEntity>().ReverseMap();
		}
	}
}
