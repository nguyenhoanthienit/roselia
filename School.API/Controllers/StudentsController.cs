using Common.ApiResponse;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using School.Service.Student.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.API.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class StudentsController : ControllerBase
	{
		private readonly IMediator _mediator;

		public StudentsController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpGet("class/{id}")]
		public async Task<IActionResult> GetStudentsByClassId(string id)
		{
			try
			{
				return Ok(await _mediator.Send(new GetStudentsByClassIdQuery { ClassId = id }));
			}
			catch
			{
				return ApiResult.Failed(Common.ErrorResult.ErrorCode.BAD_REQUEST);
			}
		}
	}
}
