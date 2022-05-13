using AutoMapper;
using PathOrderManagement.Business.Service.Abstract;
using PathOrderManagement.Contract;
using PathOrderManagement.Contract.App.Response.Order;
using PathOrderManagement.Contract.Service;
using PathOrderManagement.DataAccess.Repositories.Abstract;
using PathOrderManagement.Entity.DbPathOrderManagement.Order;
using System.Dynamic;

namespace PathOrderManagement.Business.Service.Concrete
{
    public class OrderService : BaseService<Order>, IOrderService
    {
        public OrderService(IGenericRepository<Order> repository, 
                            IMapper mapper) : base(repository, mapper)
        {
        }

        public async Task<ServiceResult<ExpandoObject>> CancelOrder(Guid Id)
        {
            var data = await _repository.FindOneAsync(x => x.Id == Id && !x.IsDeleted);

            if (data == null)
            {
                return new ServiceResult<ExpandoObject>
                {
                    Status = ResultStatus.ResourceNotFound,
                    Message = "Order not found."
                };
            }

            string message = "";
            if (data.Category.Name == "Giyim")
            {
                data.Status = OrderStatus.Canceled;
                message = "Order canceled.";
            }
            else if(data.Category.Name == "Gıda")
            {
                data.Status = OrderStatus.CancellationConfirmationPending;
                message = "Sent for cancellation confirmation.";
            }

            await _repository.UpdateAsync(data);


            return new ServiceResult<ExpandoObject>
            {
                Status = ResultStatus.Successful,
                Message = message
            };
        }

        public async Task<ServiceResult<ExpandoObject>> CancellationConfirmation(Guid Id)
        {
            var data = await _repository.FindOneAsync(x => x.Id == Id && !x.IsDeleted);

            if (data == null)
            {
                return new ServiceResult<ExpandoObject>
                {
                    Status = ResultStatus.ResourceNotFound,
                    Message = "Order not found."
                };
            }

            if (data.Status != OrderStatus.CancellationConfirmationPending)
            {
                return new ServiceResult<ExpandoObject>
                {
                    Status = ResultStatus.BadRequest,
                    Message = "Order not found."
                };
            }

            data.Status = OrderStatus.Canceled;

            await _repository.UpdateAsync(data);

            return new ServiceResult<ExpandoObject>
            {
                Status = ResultStatus.Successful,
                Message = "Order canceled."
            };
        }

        public async Task<ServiceResult<List<OrderResponse>>> CancellationRequests()
        {
            var dataList = await _repository.FindAllAsync(x => x.Status == OrderStatus.CancellationConfirmationPending && !x.IsDeleted);

            return new ServiceResult<List<OrderResponse>>
            {
                Data = Mapper.Map<List<OrderResponse>>(dataList),
                Status = ResultStatus.Successful,
                Message = ""
            };
        }
    }
}
