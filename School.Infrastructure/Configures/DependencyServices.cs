using Microsoft.Extensions.DependencyInjection;
using School.Infrastructure.Mediators;
using School.Service.Class.Handlers;
using School.Service.Class.Queries;

namespace School.Infrastructure.Configures
{
	public static class DependencyServices
	{
		public static IServiceCollection AddServices(this IServiceCollection services)
		{
			services.AddService<GetClassByIdQuery, GetClassByIdHandler>();

			return services;
		}
	}
}
