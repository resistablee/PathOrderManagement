
using PathOrderManagement.Contract;
using PathOrderManagement.Contract.App.Request.Order;
using PathOrderManagement.Contract.App.Response.Order;
using PathOrderManagement.Entity.DbPathOrderManagement.Order;
using System.Dynamic;

namespace PathOrderManagement.Business.Service.Abstract
{
    public interface IOrderService : IBaseService<Order>
    {
        Task<ServiceResult<ExpandoObject>> CancelOrder(Guid Id);
        Task<ServiceResult<ExpandoObject>> CancellationConfirmation(Guid Id);
        Task<ServiceResult<List<OrderResponse>>> CancellationRequests();
    }
}
