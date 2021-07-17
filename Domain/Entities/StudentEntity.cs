using Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Domain.Entities
{
	public class StudentEntity : IBaseEntity<Guid>, ICreatedEntity, IUpdatedEntity
	{
		public Guid Id { get; set; }
		public DateTime? CreatedAt { get; set; }
		public string CreatedBy { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public string UpdatedBy { get; set; }
		public string StudentName { get; set; }
		public virtual ClassEntity Class { get; set; }
		public Guid ClassId { get; set; }
	}
}
