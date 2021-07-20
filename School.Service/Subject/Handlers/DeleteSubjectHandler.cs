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
using System;

namespace School.Service.Subject.Handlers
{
	public class DeleteSubjectHandler : IRequestHandler<DeleteSubjectRequest, ApiResult>
	{
		private readonly IUnitOfWork _unitOfWork;

		public DeleteSubjectHandler(IUnitOfWork<WriteDbContext> unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		public async Task<ApiResult> Handle(DeleteSubjectRequest request, CancellationToken cancellationToken)
		{
			var repo = _unitOfWork.GetRepository<SubjectEntity>();

			repo.Delete(Guid.Parse(request.Id));
			await _unitOfWork.CommitAsync();

			return ApiResult.Succeeded(request.Id);
		}
	}
}
