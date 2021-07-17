using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Entities
{
	public interface IUpdatedEntity
	{
		public DateTime? UpdatedAt { get; set; }
		public string UpdatedBy { get; set; }
	}
}
