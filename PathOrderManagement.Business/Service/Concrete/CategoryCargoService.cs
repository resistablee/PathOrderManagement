using AutoMapper;
using PathOrderManagement.Business.Service.Abstract;
using PathOrderManagement.DataAccess.Repositories.Abstract;
using PathOrderManagement.Entity.DbPathOrderManagement.Cargo;

namespace PathOrderManagement.Business.Service.Concrete
{
    public class CategoryCargoService : BaseService<CategoryCargo>, ICategoryCargoService
    {
        public CategoryCargoService(IGenericRepository<CategoryCargo> repository,
                                    IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
