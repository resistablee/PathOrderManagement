using AutoMapper;
using PathOrderManagement.Business.Service.Abstract;
using PathOrderManagement.Common.Auth;
using PathOrderManagement.Common.Auth.Concrete;
using PathOrderManagement.Contract;
using PathOrderManagement.Contract.App.Request.Login;
using PathOrderManagement.Contract.App.Response.Login;
using PathOrderManagement.Contract.Service;
using PathOrderManagement.DataAccess.Repositories.Abstract;
using PathOrderManagement.Entity.DbPathOrderManagement.User;
using System.Dynamic;

namespace PathOrderManagement.Business.Service.Concrete
{
    public class LoginService : BaseService<User>, ILoginService
    {

        public LoginService(IGenericRepository<User> repository,
                            IMapper mapper) : base(repository, mapper)
        {
        }

        public async Task<ServiceResult<GetTokenResponse>> GetTokenAsync(GetTokenRequest request)
        {
            var entity = await _repository.FindOneAsync(x => x.Email == request.Email && x.Password == request.Password && !x.IsDeleted);

            if (entity == null)
            {
                return new ServiceResult<GetTokenResponse>
                {
                    Status = ResultStatus.ResourceNotFound,
                    Message = "User not found."
                };
            }

            var token = new JwtManager().GenerateToken(new JwtContract
            {
                Id = entity.Id,
                Name = $"{entity.Firstname} {entity.Lastname}",
                Email = entity.Email,
                UserType = entity.UserType.ToString()
            });

            entity.RefreshToken = token.RefreshToken;
            entity.RefreshTokenExpireDate = token.RefreshTokenExpireDate;

            await _repository.UpdateAsync(entity);

            return new ServiceResult<GetTokenResponse>
            {
                Status = ResultStatus.Successful,
                Message = "Token generated.",
                Data = token
            };
        }

        public async Task<ServiceResult<GetTokenResponse>> RefreshTokenAsync(RefreshTokenRequest request)
        {
            var entity = await _repository.FindOneAsync(x => x.RefreshToken == request.Token && x.RefreshTokenExpireDate > DateTime.Now && !x.IsDeleted);

            if (entity == null)
            {
                return new ServiceResult<GetTokenResponse>
                {
                    Status = ResultStatus.ResourceNotFound,
                    Message = "User not found."
                };
            }

            var token = new JwtManager().GenerateToken(new JwtContract
            {
                Id = entity.Id,
                Name = $"{entity.Firstname} {entity.Lastname}",
                Email = entity.Email,
                UserType = entity.UserType.ToString()
            });

            entity.RefreshToken = token.RefreshToken;
            entity.RefreshTokenExpireDate = token.RefreshTokenExpireDate;

            await _repository.UpdateAsync(entity);

            return new ServiceResult<GetTokenResponse>
            {
                Status = ResultStatus.Successful,
                Message = "Token renewed.",
                Data = token
            };
        }

        public async Task<ServiceResult<ExpandoObject>> SignUp(SignUpRequest request)
        {
            if (request == null)
            {
                return new ServiceResult<ExpandoObject>
                {
                    Status = ResultStatus.BadRequest,
                    Message = "Request is null."
                };
            }

            var entity = Mapper.Map<User>(request);

            if (await _repository.AnyAsync(x => x.Email == entity.Email))
            {
                return new ServiceResult<ExpandoObject>
                {
                    Status = ResultStatus.Exists,
                    Message = "User already exists."
                };
            }

            var user = await _repository.InsertAsync(entity);

            return new ServiceResult<ExpandoObject>
            {
                Status = ResultStatus.Successful,
                Message = "Sign up successful."
            };
        }
    }
}
