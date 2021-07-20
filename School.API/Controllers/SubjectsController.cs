using Common.ApiResponse;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using School.Service.Subject.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.API.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class SubjectsController : ControllerBase
	{
		private readonly IMediator _mediator;

		public SubjectsController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteSubjectById(string id)
		{
			try
			{
				return Ok(await _mediator.Send(new DeleteSubjectRequest { Id = id }));
			}
			catch (Exception ex)
			{
				return ApiResult.Failed(Common.ErrorResult.ErrorCode.BAD_REQUEST);
			}
		}

		[HttpPost]
		public async Task<IActionResult> CreateSubject(CreateSubjectRequest request)
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

		[HttpPut("{id}")]
		public async Task<IActionResult> UpdateSubject(string id, UpdateSubjectRequest request)
		{
			try
			{
				request.Id = id;
				return Ok(await _mediator.Send(request));
			}
			catch (Exception ex)
			{
				return ApiResult.Failed(Common.ErrorResult.ErrorCode.BAD_REQUEST);
			}
		}
	}
}
