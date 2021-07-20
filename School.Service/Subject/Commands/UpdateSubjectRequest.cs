using Common.ApiResponse;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Service.Subject.Commands
{
	public class UpdateSubjectRequest : IRequest<ApiResult>
	{
		public string Id { get; set; }
		public string SubjectName { get; set; }
	}
}
