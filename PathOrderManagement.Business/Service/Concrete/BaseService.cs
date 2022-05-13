using AutoMapper;
using PathOrderManagement.Business.Service.Abstract;
using PathOrderManagement.Contract;
using PathOrderManagement.Contract.Service;
using PathOrderManagement.DataAccess.Repositories.Abstract;
using PathOrderManagement.Entity.DbPathOrderManagement.Base;
using System.Dynamic;

namespace PathOrderManagement.Business.Service.Concrete
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : SoftDeleteEntity
    {
        public readonly IGenericRepository<TEntity> _repository;
        public readonly IMapper Mapper;

        public BaseService(IGenericRepository<TEntity> repository,
                           IMapper _Mapper)
        {
            _repository = repository;
            Mapper = _Mapper;
        }

        public virtual async Task<ServiceResult<TResponse>> GetAsync<TResponse>(Guid Id) where TResponse : class
        {
            var data = await _repository.FindOneAsync(x => x.Id == Id && !x.IsDeleted);

            if (data == null)
            {
                return new ServiceResult<TResponse>
                {
                    Status = ResultStatus.ResourceNotFound,
                    Message = "Data not found"
                };
            }

            return new ServiceResult<TResponse>
            {
                Data = Mapper.Map<TResponse>(data),
                Status = ResultStatus.Successful,
                Message = ""
            };
        }

        public virtual async Task<ServiceResult<List<TResponse>>> GetAllAsync<TResponse>() where TResponse : class
        {
            var dataList = await _repository.FindAllAsync(x => !x.IsDeleted);

            return new ServiceResult<List<TResponse>>
            {
                Data = Mapper.Map<List<TResponse>>(dataList),
                Status = ResultStatus.Successful,
                Message = ""
            };
        }

        public virtual async Task<ServiceResult<List<TResponse>>> GetAllAsNoTrackingAsync<TResponse>() where TResponse : class
        {
            var dataList = await _repository.FindAllWithAsNoTrackingAsync(x => !x.IsDeleted);

            return new ServiceResult<List<TResponse>>
            {
                Data = Mapper.Map<List<TResponse>>(dataList),
                Status = ResultStatus.Successful,
                Message = ""
            };
        }

        public virtual async Task<ServiceResult<ExpandoObject>> CreateAsync<TRequest>(TRequest request) where TRequest : class
        {
            if (request == null)
            {
                return new ServiceResult<ExpandoObject>
                {
                    Status = ResultStatus.BadRequest,
                    Message = "Request is null."
                };
            }
            var entity = Mapper.Map<TEntity>(request);

            await _repository.InsertAsync(entity);

            return new ServiceResult<ExpandoObject>
            {
                Status = ResultStatus.Successful,
                Message = "Data added."
            };
        }

        public virtual async Task<ServiceResult<ExpandoObject>> DeleteAsync(Guid Id)
        {
            var data = await _repository.FindOneAsync(x => x.Id == Id && !x.IsDeleted);

            if (data == null)
            {
                return new ServiceResult<ExpandoObject>
                {
                    Status = ResultStatus.ResourceNotFound,
                    Message = "Data not found."
                };
            }

            data.IsDeleted = true;
            data.DeletedOn = DateTime.Now;

            await _repository.UpdateAsync(data);

            return new ServiceResult<ExpandoObject>
            {
                Status = ResultStatus.Successful,
                Message = "Data deleted."
            };
        }
    }
}