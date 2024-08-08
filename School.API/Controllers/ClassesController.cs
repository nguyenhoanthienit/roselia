using Common.ApiResponse;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using School.Service.Class.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.API.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class ClassesController : ControllerBase
	{
		private readonly IMediator _mediator;
		public ClassesController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetClassById(string id)
		{
			try
			{
				return Ok(await _mediator.Send(new GetClassByIdQuery { Id = id }));
			}
			catch (Exception ex)
			{
				return ApiResult.Failed(Common.ErrorResult.ErrorCode.BAD_REQUEST);
			}
		}

	        [HttpGet]
	        public async Task<IActionResult> GetClasses()
	        {
	            try
	            {
	                return Ok(await _mediator.Send(new GetClassesQuery { }));
	            }
	            catch (Exception ex)
	            {
	                return ApiResult.Failed(Common.ErrorResult.ErrorCode.BAD_REQUEST);
	            }
	        }
	}
}
