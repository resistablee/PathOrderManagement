using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PathOrderManagement.Business.Service.Abstract;
using PathOrderManagement.Common.BaseModels.Api;
using PathOrderManagement.Contract.App.Request.Order;
using PathOrderManagement.Contract.App.Response.Order;

namespace PathOrderManagement.Api.Controllers.V1
{
    [ApiVersion("1.0")]
    public class OrderController : BaseController
    {
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;

        public OrderController(IOrderService orderService,
                               IMapper mapper)
        {
            _orderService = orderService;
            _mapper = mapper;
        }

        [HttpGet("{id:guid}")]
        [Authorize(Roles = "SuperAdmin, SystemAdmin, Admin")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(OrderResponse))]
        public async Task<ActionResult> Get(Guid id)
        {
            var result = await _orderService.GetAsync<OrderResponse>(id);

            return ApiResponse.CreateResult(result);
        }

        [HttpGet]
        [Authorize(Roles = "SuperAdmin, SystemAdmin, Admin")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<OrderResponse>))]
        public async Task<ActionResult> GetAll()
        {
            var result = await _orderService.GetAllAsync<OrderResponse>();

            return ApiResponse.CreateResult(result);
        }

        [HttpGet("cancellation-requests")]
        [Authorize(Roles = "SuperAdmin, SystemAdmin")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<OrderResponse>))]
        public async Task<ActionResult> CancellationRequests()
        {
            var result = await _orderService.CancellationRequests();

            return ApiResponse.CreateResult(result);
        }

        [HttpPost("create-order")]
        [Authorize(Roles = "Customer")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DataResponse))]
        public async Task<ActionResult> CreateOrder (CreateOrderRequest request)
        {
            var result = await _orderService.CreateAsync(request);

            return ApiResponse.CreateResult(result);
        }

        [HttpPost("{id:guid}/cancel-order")]
        [Authorize(Roles = "Customer")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DataResponse))]
        public async Task<ActionResult> CancelOrder(Guid id)
        {
            var result = await _orderService.CancelOrder(id);

            return ApiResponse.CreateResult(result);
        }

        [HttpPost("{id:guid}/cancellation-confirmation")]
        [Authorize(Roles = "SuperAdmin, SystemAdmin")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DataResponse))]
        public async Task<ActionResult> CancellationConfirmation(Guid id)
        {
            var result = await _orderService.CancellationConfirmation(id);

            return ApiResponse.CreateResult(result);
        }
    }
}