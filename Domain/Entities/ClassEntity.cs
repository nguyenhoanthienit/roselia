using Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Domain.Entities
{
	public class ClassEntity : IBaseEntity<Guid>, ICreatedEntity, IUpdatedEntity
	{
		public ClassEntity()
		{
			Students = new HashSet<StudentEntity>();
			Schedules = new HashSet<ScheduleEntity>();
		}
		public Guid Id { get; set; }
		public DateTime? CreatedAt { get; set; }
		public string CreatedBy { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public string UpdatedBy { get; set; }
		public string ClassName { get; set; }
		public virtual ICollection<StudentEntity> Students { get; set; }
		public virtual ICollection<ScheduleEntity> Schedules { get; set; }
	}
}
