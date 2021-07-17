using Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Domain.Entities
{
	public class SubjectEntity : IBaseEntity<Guid>, ICreatedEntity, IUpdatedEntity
	{
		public SubjectEntity()
		{
			Schedules = new HashSet<ScheduleEntity>();
		}
		public Guid Id { get; set; }
		public DateTime? CreatedAt { get; set; }
		public string CreatedBy { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public string UpdatedBy { get; set; }
		public string SubjectName { get; set; }
		public virtual ICollection<ScheduleEntity> Schedules { get; set; }
	}
}
