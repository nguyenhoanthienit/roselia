using Common.ApiResponse;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using School.Service.Schedule.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.API.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class SchedulesController : ControllerBase
	{
		private readonly IMediator _mediator;
		public SchedulesController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpPost]
		public async Task<IActionResult> CreateSchedule([FromBody] CreateSheduleRequest request)
		{
			try
			{
				return Ok(await _mediator.Send(request));
			}
			catch (Exception ex)
			{
				return ApiResult.Failed(Common.ErrorResult.ErrorCode.BAD_REQUEST);
			}
		}
	}
}
