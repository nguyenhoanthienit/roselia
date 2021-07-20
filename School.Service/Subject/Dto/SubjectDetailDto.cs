using System;
using System.Collections.Generic;
using System.Text;

namespace School.Service.Subject.Dto
{
	public class SubjectDetailDto
	{
		public Guid Id { get; set; }
		public DateTime? CreatedAt { get; set; }
		public string CreatedBy { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public string UpdatedBy { get; set; }
		public string SubjectName { get; set; }
	}
}
