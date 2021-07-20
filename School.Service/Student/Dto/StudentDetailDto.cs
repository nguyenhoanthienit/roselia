using System;
using System.Collections.Generic;
using System.Text;

namespace School.Service.Student.Dto
{
	public class StudentDetailDto
	{
		public Guid Id { get; set; }
		public DateTime? CreatedAt { get; set; }
		public string CreatedBy { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public string UpdatedBy { get; set; }
		public string StudentName { get; set; }
	}
}
