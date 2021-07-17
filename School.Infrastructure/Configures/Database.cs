using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using School.Data.Context;
using School.Data.EntityFramework;
using School.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Infrastructure.Configures
{
	public static class Database
	{
		public static IServiceCollection AddUnitOfWork(this IServiceCollection services)
		{
			var readConnectionString = Environment.GetEnvironmentVariable("READ_DATABASE_CONNECTION_STRING");
			var writeConnectionString = Environment.GetEnvironmentVariable("WRITE_DATABASE_CONNECTION_STRING");

			services.AddDbContext<ReadDbContext>(opt => opt.UseNpgsql(readConnectionString));
			services.AddScoped<IUnitOfWork<ReadDbContext>, UnitOfWork<ReadDbContext>>();

			services.AddDbContext<WriteDbContext>(opt => opt.UseNpgsql(writeConnectionString));
			services.AddScoped<IUnitOfWork<WriteDbContext>, UnitOfWork<WriteDbContext>>();

			return services;
		}
	}
}
