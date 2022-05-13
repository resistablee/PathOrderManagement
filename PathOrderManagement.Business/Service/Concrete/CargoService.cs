using AutoMapper;
using PathOrderManagement.Business.Service.Abstract;
using PathOrderManagement.Contract;
using PathOrderManagement.Contract.App.Request.Cargo;
using PathOrderManagement.Contract.Service;
using PathOrderManagement.DataAccess.Repositories.Abstract;
using PathOrderManagement.Entity.DbPathOrderManagement.Cargo;
using PathOrderManagement.Entity.DbPathOrderManagement.Order;
using System.Dynamic;

namespace PathOrderManagement.Business.Service.Concrete
{
    public class CargoService : BaseService<Cargo>, ICargoService
    {
        private readonly IGenericRepository<Order> _orderRepository;
        private readonly IGenericRepository<CategoryCargo> _categoryCargoRepository;

        public CargoService(IGenericRepository<Cargo> repository,
                            IGenericRepository<Order> orderRepository,
                            IGenericRepository<CategoryCargo> categoryCargoRepository,
                            IMapper mapper) : base(repository, mapper)
        {
            _orderRepository = orderRepository;
            _categoryCargoRepository = categoryCargoRepository;
        }

        public async Task<ServiceResult<ExpandoObject>> CreateAsync(CreateCargoRequest request)
        {
            if (request == null)
            {
                return new ServiceResult<ExpandoObject>
                {
                    Status = ResultStatus.BadRequest,
                    Message = "Request is null."
                };
            }
            var entity = Mapper.Map<Cargo>(request);

            var order = await _orderRepository.FindOneAsync(x => x.Id == entity.OrderID);

            if (order == null)
            {
                return new ServiceResult<ExpandoObject>
                {
                    Status = ResultStatus.BadRequest,
                    Message = "Order is null."
                };
            }

            var categoryCargo = await _categoryCargoRepository.FindOneAsync(x => x.CategoryID == order.CategoryID);

            entity.CompanyID = categoryCargo.CompanyID;

            await _repository.InsertAsync(entity);

            order.Status = OrderStatus.InCargo;
            await _orderRepository.UpdateAsync(order);

            return new ServiceResult<ExpandoObject>
            {
                Status = ResultStatus.Successful,
                Message = "Data added."
            };
        }
    }
}
