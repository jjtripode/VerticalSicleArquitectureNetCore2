using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace VerticalSliceArqTEST
{
    public class ResponseResult
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public string DepartmentName { get; set; }
    }

    public class RequestQuery : IRequest<ResponseResult>
    {
        public int? Id { get; set; }
    }

    public class Handler : IRequestHandler<RequestQuery, ResponseResult>
    {
       public async Task<ResponseResult> Handle(RequestQuery request, CancellationToken cancellationToken)
    {
            return new ResponseResult(){Credits=800,DepartmentName="Department",Id=5000,Title="Title" };
        }
    }
}