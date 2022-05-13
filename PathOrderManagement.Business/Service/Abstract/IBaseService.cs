using PathOrderManagement.Contract;
using System.Dynamic;

namespace PathOrderManagement.Business.Service.Abstract
{
    public interface IBaseService<TEntity> : IService where TEntity : class
    {
        Task<ServiceResult<TResponse>> GetAsync<TResponse>(Guid Id) where TResponse : class;
        Task<ServiceResult<List<TResponse>>> GetAllAsync<TResponse>() where TResponse : class;
        Task<ServiceResult<List<TResponse>>> GetAllAsNoTrackingAsync<TResponse>() where TResponse : class;
        Task<ServiceResult<ExpandoObject>> CreateAsync<TServiceRequest>(TServiceRequest request) where TServiceRequest : class;
        //Task<ServiceResult<ExpandoObject>> UpdateAsync<TServiceRequest>(Guid Id, TServiceRequest request) where TServiceRequest : class;
        Task<ServiceResult<ExpandoObject>> DeleteAsync(Guid Id);
    }
}
