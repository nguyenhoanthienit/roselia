using AutoMapper;
using Common.ApiResponse;
using MediatR;
using Microsoft.EntityFrameworkCore;
using School.Data.Context;
using School.Domain.Contracts;
using School.Domain.Entities;
using School.Service.Student.Dto;
using School.Service.Student.Queries;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace School.Service.Student.Handlers
{
	public class GetStudentByClassIdHandler : IRequestHandler<GetStudentsByClassIdQuery, ApiResult>
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;

		public GetStudentByClassIdHandler(IUnitOfWork<ReadDbContext> unitOfWork, IMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}

		public async Task<ApiResult> Handle(GetStudentsByClassIdQuery request, CancellationToken cancellationToken)
		{
			var repo = await _unitOfWork.GetRepository<StudentEntity>().TableNoTracking
				.Where(c => c.ClassId.ToString() == request.ClassId)
				.ToListAsync();

			return ApiResult.Succeeded(_mapper.Map(repo, new List<StudentDetailDto>()));
		}
	}
}
