using Microsoft.AspNetCore.Mvc;
using PathOrderManagement.Contract;
using PathOrderManagement.Contract.Service;

namespace PathOrderManagement.Common.BaseModels.Api
{
    public class ApiResponse
    {
        public static ObjectResult CreateResult<T>(ServiceResult<T> result) where T : class
        {
            if (result.Status == ResultStatus.Successful) //Successful - 200
            {
                return new ObjectResult(new DataResponse
                {
                    Status = "Işlem başarılı",
                    Message = result.Message,
                    Data = result.Data
                })
                { StatusCode = 200 };
            }

            else if (result.Status == ResultStatus.Created) //Created - 201
            {
                return new ObjectResult(new DataResponse
                {
                    Status = "Eklendi",
                    Message = result.Message,
                    Data = result.Data
                })
                { StatusCode = 201 };
            }

            else if (result.Status == ResultStatus.Accepted) //Accepted - 202
            {
                return new ObjectResult(new DataResponse
                {
                    Status = "Kabul edildi",
                    Message = result.Message
                })
                { StatusCode = 202 };
            }

            else if (result.Status == ResultStatus.InvalidInput) //InvalidInput - 400
            {
                return new ObjectResult(new DataResponse
                {
                    Status = "Geçersiz giriş",
                    Message = result.Message
                })
                { StatusCode = 400 };
            }

            else if (result.Status == ResultStatus.Exists) //Exists - 400
            {
                return new ObjectResult(new DataResponse
                {
                    Status = "Kaynak mevcut",
                    Message = result.Message
                })
                { StatusCode = 400 };
            }

            else if (result.Status == ResultStatus.BadRequest) //BadRequest - 400
            {
                return new ObjectResult(new DataResponse
                {
                    Status = "Geçersiz istek",
                    Message = result.Message
                })
                { StatusCode = 400 };
            }

            else if (result.Status == ResultStatus.Forbidden) //Forbidden - 403
            {
                return new ObjectResult(new DataResponse
                {
                    Status = "Yasaklı",
                    Message = result.Message
                })
                { StatusCode = 403 };
            }

            else if (result.Status == ResultStatus.ResourceNotFound) //ResourceNotFound - 404
            {
                return new ObjectResult(new DataResponse
                {
                    Status = "Kaynak bulunamadı",
                    Message = result.Message
                })
                { StatusCode = 404 };
            }

            else if (result.Status == ResultStatus.ErrorOccurred) //ErrorOccurred - 500
            {
                return new ObjectResult(new DataResponse
                {
                    Status = "Bir hata meydana geldi!",
                    Message = result.Message
                })
                { StatusCode = 500 };
            }

            else if (result.Status == ResultStatus.Failed) //Failed - 500
            {
                return new ObjectResult(new DataResponse
                {
                    Status = "Bir hata meydana geldi!",
                    Message = result.Message
                })
                { StatusCode = 500 };
            }

            else
            {
                return new ObjectResult(new DataResponse
                {
                    Status = "Bir hata meydana geldi!",
                    Message = "Bir hata meydana geldi!"
                })
                { StatusCode = 500 };
            }
        }
    }
}
