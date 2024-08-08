using AutoMapper;
using Common.ApiResponse;
using MediatR;
using Microsoft.EntityFrameworkCore;
using School.Data.Context;
using School.Domain.Contracts;
using School.Domain.Entities;
using School.Service.Class.Dto;
using School.Service.Class.Queries;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace School.Service.Class.Handlers
{
	public class GetClassesHandler : IRequestHandler<GetClassesQuery, ApiResult>
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;

		public GetClassesHandler(IUnitOfWork<ReadDbContext> unitOfWork, IMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}

		public async Task<ApiResult> Handle(GetClassesQuery request, CancellationToken cancellationToken)
		{
			var classes = await _unitOfWork.GetRepository<ClassEntity>().TableNoTracking.ToListAsync();
			var res = new List<ClassDetailDto>();
            foreach (var item in classes)
            {
                res.Add(_mapper.Map(item, new ClassDetailDto()));
            }
            return ApiResult.Succeeded(res);
		}
	}
}
