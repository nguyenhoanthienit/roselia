using System;
using System.Collections.Generic;
using System.Text;

namespace School.Service.Class.Dto
{
	public class ClassDetailDto
	{
		public Guid Id { get; set; }
		public DateTime? CreatedAt { get; set; }
		public string CreatedBy { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public string UpdatedBy { get; set; }
		public string ClassName { get; set; }
	}
}
