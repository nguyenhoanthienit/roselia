using AutoMapper;
using Common.ApiResponse;
using MediatR;
using School.Data.Context;
using School.Domain.Contracts;
using School.Domain.Entities;
using School.Service.Schedule.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace School.Service.Schedule.Handlers
{
	public class CreateScheduleHandler : IRequestHandler<CreateSheduleRequest, ApiResult>
	{
		private readonly IMapper _mapper;
		private readonly IUnitOfWork _unitOfWork;

		public CreateScheduleHandler(IUnitOfWork<WriteDbContext> unitOfWork, IMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}

		public async Task<ApiResult> Handle(CreateSheduleRequest request, CancellationToken cancellationToken)
		{
			var schedule = _mapper.Map<ScheduleEntity>(request);
			await _unitOfWork.GetRepository<ScheduleEntity>().InsertAsync(schedule, cancellationToken);
			await _unitOfWork.CommitAsync();

			return ApiResult.Succeeded();
		}
	}
}
