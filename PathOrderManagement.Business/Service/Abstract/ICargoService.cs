using PathOrderManagement.Contract;
using PathOrderManagement.Contract.App.Request.Cargo;
using PathOrderManagement.Entity.DbPathOrderManagement.Cargo;
using System.Dynamic;

namespace PathOrderManagement.Business.Service.Abstract
{
    public interface ICargoService : IBaseService<Cargo>
    {
        Task<ServiceResult<ExpandoObject>> CreateAsync(CreateCargoRequest request);
    }
}
