using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Infrastructure.Mapper
{
	public static class AutoMapper
	{
		public static IServiceCollection AddAutoMapper(this IServiceCollection services)
		{
			var configuration = new MapperConfiguration(c => c.AddProfile(new MappingProfile()));

			var mapper = configuration.CreateMapper();

			return services.AddSingleton(mapper);
		}
	}
}
