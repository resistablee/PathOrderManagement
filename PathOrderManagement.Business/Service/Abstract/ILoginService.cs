using PathOrderManagement.Contract;
using PathOrderManagement.Contract.App.Request.Login;
using PathOrderManagement.Contract.App.Response.Login;
using PathOrderManagement.Entity.DbPathOrderManagement.User;
using System.Dynamic;

namespace PathOrderManagement.Business.Service.Abstract
{
    public interface ILoginService : IBaseService<User>
    {
        Task<ServiceResult<GetTokenResponse>> GetTokenAsync(GetTokenRequest request);
        Task<ServiceResult<GetTokenResponse>> RefreshTokenAsync(RefreshTokenRequest request);
        Task<ServiceResult<ExpandoObject>> SignUp(SignUpRequest request);
    }
}
