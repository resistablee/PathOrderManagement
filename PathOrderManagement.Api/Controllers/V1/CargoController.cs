using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PathOrderManagement.Business.Service.Abstract;
using PathOrderManagement.Common.BaseModels.Api;
using PathOrderManagement.Contract.App.Request.Cargo;
using PathOrderManagement.Contract.App.Response.Cargo;

namespace PathOrderManagement.Api.Controllers.V1
{
    [ApiVersion("1.0")]
    public class CargoController : BaseController
    {
        private readonly ICargoService _cargoService;
        private readonly IMapper _mapper;

        public CargoController(ICargoService cargoService, IMapper mapper)
        {
            _cargoService = cargoService;
            _mapper = mapper;
        }

        [HttpGet("{id:guid}")]
        [Authorize(Roles = "SuperAdmin, SystemAdmin, Admin, Customer")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CargoResponse))]
        public async Task<ActionResult> Get(Guid id)
        {
            var result = await _cargoService.GetAsync<CargoResponse>(id);

            return ApiResponse.CreateResult(result);
        }

        [HttpGet]
        [Authorize(Roles = "SuperAdmin, SystemAdmin, Admin")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<CargoResponse>))]
        public async Task<ActionResult> GetAll()
        {
            var result = await _cargoService.GetAllAsync<CargoResponse>();

            return ApiResponse.CreateResult(result);
        }

        [HttpPost]
        [Authorize(Roles = "SuperAdmin, SystemAdmin, Admin")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DataResponse))]
        public async Task<ActionResult> CreateAsync([FromBody] CreateCargoRequest request)
        {
            var result = await _cargoService.CreateAsync(request);
            return ApiResponse.CreateResult(result);
        }
    }
}
