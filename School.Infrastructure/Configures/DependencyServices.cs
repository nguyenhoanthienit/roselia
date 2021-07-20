using Microsoft.Extensions.DependencyInjection;
using School.Infrastructure.Mediators;
using School.Service.Class.Handlers;
using School.Service.Class.Queries;
using School.Service.Schedule.Commands;
using School.Service.Schedule.Handlers;
using School.Service.Student.Handlers;
using School.Service.Student.Queries;
using School.Service.Subject.Commands;
using School.Service.Subject.Handlers;

namespace School.Infrastructure.Configures
{
	public static class DependencyServices
	{
		public static IServiceCollection AddServices(this IServiceCollection services)
		{
			// Class
			services.AddService<GetClassByIdQuery, GetClassByIdHandler>();

			// Student
			services.AddService<GetStudentsByClassIdQuery, GetStudentByClassIdHandler>();

			// Schedule
			services.AddService<CreateSheduleRequest, CreateScheduleHandler>();

			// Subject
			services.AddService<DeleteSubjectRequest, DeleteSubjectHandler>();
			services.AddService<CreateSubjectRequest, CreateSubjectHandler>();
			services.AddService<UpdateSubjectRequest, UpdateSubjectHandler>();

			return services;
		}
	}
}
