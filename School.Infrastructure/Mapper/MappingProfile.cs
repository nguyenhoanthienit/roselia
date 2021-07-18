using AutoMapper;
using School.Domain.Entities;
using School.Service.Class.Dto;

namespace School.Infrastructure.Mapper
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			// Class
			CreateMap<ClassDetailDto, ClassEntity>().ReverseMap();
		}
	}
}
