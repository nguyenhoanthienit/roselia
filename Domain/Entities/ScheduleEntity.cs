using Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Domain.Entities
{
	public class ScheduleEntity : ICreatedEntity, IUpdatedEntity
	{
		public Guid ClassId { get; set; }
		public Guid SubjectId { get; set; }
		public int DayOfWeek { get; set; }
		public DateTime? CreatedAt { get; set; }
		public string CreatedBy { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public string UpdatedBy { get; set; }
		public virtual ClassEntity Class { get; set; }
		public virtual SubjectEntity Subject { get; set; }
	}
}
