using Common.ApiResponse;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Service.Student.Queries
{
	public class GetStudentsByClassIdQuery : IRequest<ApiResult>
	{
		public string ClassId { get; set; }
	}
}
