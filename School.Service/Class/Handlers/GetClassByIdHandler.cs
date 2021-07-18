using AutoMapper;
using Common.ApiResponse;
using MediatR;
using Microsoft.EntityFrameworkCore;
using School.Data.Context;
using School.Domain.Contracts;
using School.Domain.Entities;
using School.Service.Class.Dto;
using School.Service.Class.Queries;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace School.Service.Class.Handlers
{
	public class GetClassByIdHandler : IRequestHandler<GetClassByIdQuery, ApiResult>
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;

		public GetClassByIdHandler(IUnitOfWork<ReadDbContext> unitOfWork, IMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}

		public async Task<ApiResult> Handle(GetClassByIdQuery request, CancellationToken cancellationToken)
		{
			var res = await _unitOfWork.GetRepository<ClassEntity>().TableNoTracking
				.Where(c => c.Id.ToString() == request.Id)
				.SingleOrDefaultAsync();

			return ApiResult.Succeeded(_mapper.Map(res, new ClassDetailDto()));
		}
	}
}
