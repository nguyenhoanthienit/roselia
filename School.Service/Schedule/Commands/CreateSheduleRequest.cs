using Common.ApiResponse;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace School.Service.Schedule.Commands
{
	public class CreateSheduleRequest : IRequest<ApiResult>
	{
		[Required]
		public Guid ClassId { get; set; }
		[Required]
		public Guid SubjectId { get; set; }
		[Required]
		public int DayOfWeek { get; set; }
		public DateTime? CreatedAt { get; set; }
		public string CreatedBy { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public string UpdatedBy { get; set; }
	}
}
