using Common.ApiResponse;
using MediatR;
using Microsoft.EntityFrameworkCore;
using School.Data.Context;
using School.Domain.Contracts;
using School.Domain.Entities;
using School.Service.Subject.Commands;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;

namespace School.Service.Subject.Handlers
{
	public class UpdateSubjectHandler : IRequestHandler<UpdateSubjectRequest, ApiResult>
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;

		public UpdateSubjectHandler(IUnitOfWork<WriteDbContext> unitOfWork, IMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}

		public async Task<ApiResult> Handle(UpdateSubjectRequest request, CancellationToken cancellationToken)
		{
			var subject = _mapper.Map<SubjectEntity>(request);

			_unitOfWork.GetRepository<SubjectEntity>().Update(subject);
			await _unitOfWork.CommitAsync();

			return ApiResult.Succeeded(subject);
		}
	}
}
