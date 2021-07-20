using Common.ApiResponse;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace School.Service.Subject.Commands
{
	public class CreateSubjectRequest : IRequest<ApiResult>
	{
		public Guid Id { get; set; } = new Guid();
		public DateTime? CreatedAt { get; set; }
		public string CreatedBy { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public string UpdatedBy { get; set; }
		[Required]
		public string SubjectName { get; set; }
	}
}
