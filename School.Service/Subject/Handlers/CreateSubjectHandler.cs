using AutoMapper;
using Common.ApiResponse;
using MediatR;
using School.Data.Context;
using School.Domain.Contracts;
using School.Domain.Entities;
using School.Service.Subject.Commands;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace School.Service.Subject.Handlers
{
	public class CreateSubjectHandler : IRequestHandler<CreateSubjectRequest, ApiResult>
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;

		public CreateSubjectHandler(IUnitOfWork<WriteDbContext> unitOfWork, IMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}

		public async Task<ApiResult> Handle(CreateSubjectRequest request, CancellationToken cancellationToken)
		{
			var schedule = _mapper.Map<SubjectEntity>(request);

			await _unitOfWork.GetRepository<SubjectEntity>().InsertAsync(schedule, cancellationToken);
			await _unitOfWork.CommitAsync();

			return ApiResult.Succeeded(schedule);
		}
	}
}
