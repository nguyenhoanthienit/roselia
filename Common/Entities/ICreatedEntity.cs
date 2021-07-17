using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Entities
{
	public interface ICreatedEntity
	{
		public DateTime? CreatedAt { get; set; }
		public string CreatedBy { get; set; }
	}
}
