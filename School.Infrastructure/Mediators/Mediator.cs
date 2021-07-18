using Common.ApiResponse;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace School.Infrastructure.Mediators
{
	public static class Mediator
	{
		public static IServiceCollection AddMediator(this IServiceCollection services)
		{
			return services.AddMediatR(Assembly.GetExecutingAssembly());
		}

		public static void AddService<TRequest, TImplementation>(this IServiceCollection services)
			where TRequest : class, IRequest<ApiResult>
			where TImplementation : class, IRequestHandler<TRequest, ApiResult>
		{
			services.AddScoped<IRequestHandler<TRequest, ApiResult>, TImplementation>();
		}
	}
}
