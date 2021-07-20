using Microsoft.EntityFrameworkCore;
using School.Domain.Contracts;
using School.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Data.Context
{
	public abstract class ApplicationContext : DbContext, IApplicationDbContext
	{
		public ApplicationContext(DbContextOptions options) : base(options)
		{
		}

		public virtual DbSet<ClassEntity> Classes { get; set; }
		public virtual DbSet<StudentEntity> Students { get; set; }
		public virtual DbSet<SubjectEntity> Subjects { get; set; }
		public virtual DbSet<ScheduleEntity> Schedules { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			builder.HasPostgresExtension("unaccent");

			builder.Entity<StudentEntity>(entity =>
			{
				entity.HasOne(e => e.Class)
				.WithMany(e => e.Students)
				.HasForeignKey(e => e.ClassId)
				.OnDelete(DeleteBehavior.Cascade);
			});

			builder.Entity<ScheduleEntity>(entity =>
			{
				entity.HasIndex(e => new { e.ClassId, e.SubjectId, e.DayOfWeek }).IsUnique();

				entity.HasOne(e => e.Class)
				.WithMany(e => e.Schedules)
				.HasForeignKey(e => e.ClassId);

				entity.HasOne(e => e.Subject)
				.WithMany(e => e.Schedules)
				.HasForeignKey(e => e.SubjectId);
			});
		}
	}
}
