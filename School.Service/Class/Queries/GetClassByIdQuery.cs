using Common.ApiResponse;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Service.Class.Queries
{
	public class GetClassByIdQuery : IRequest<ApiResult>
	{
		public string Id { get; set; }
	}
}
