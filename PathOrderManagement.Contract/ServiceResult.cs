
using PathOrderManagement.Contract.Service;

namespace PathOrderManagement.Contract
{
    public class ServiceResult<TResponse> where TResponse : class
    {
        public ResultStatus Status { get; set; }
        public string Message { get; set; }
        public TResponse Data { get; set; }
    }
}
