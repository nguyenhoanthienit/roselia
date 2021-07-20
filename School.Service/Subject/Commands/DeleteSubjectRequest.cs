using Common.ApiResponse;
using MediatR;

namespace School.Service.Subject.Commands
{
	public class DeleteSubjectRequest : IRequest<ApiResult>
	{
		public string Id { get; set; }
	}
}
