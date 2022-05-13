using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PathOrderManagement.Business.Service.Abstract;
using PathOrderManagement.Common.BaseModels.Api;
using PathOrderManagement.Contract.App.Request.Login;
using PathOrderManagement.Contract.App.Response.Login;

namespace PathOrderManagement.Api.Controllers.V1
{
    [ApiVersion("1.0")]
    public class LoginController : BaseController
    {
        private readonly ILoginService _loginService;
        private readonly IMapper _mapper;

        public LoginController(ILoginService loginService, IMapper mapper)
        {
            _loginService = loginService;
            _mapper = mapper;
        }

        [HttpPost("/sign-in")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GetTokenResponse))]
        public async Task<ActionResult> SignIn([FromBody] GetTokenRequest request)
        {
            var result = await _loginService.GetTokenAsync(request);
            return ApiResponse.CreateResult(result);
        }

        [HttpPost("/sign-up")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DataResponse))]
        public async Task<ActionResult> SignUp([FromBody] SignUpRequest request)
        {
            var result = await _loginService.SignUp(request);
            return ApiResponse.CreateResult(result);
        }

        [HttpPost("/refresh-token")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GetTokenResponse))]
        public async Task<ActionResult> RefreshToken([FromBody] RefreshTokenRequest request)
        {
            var result = await _loginService.RefreshTokenAsync(request);
            return ApiResponse.CreateResult(result);
        }
    }
}
