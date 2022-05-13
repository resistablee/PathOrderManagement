using Microsoft.AspNetCore.Mvc;
using PathOrderManagement.Common.Constans;

namespace PathOrderManagement.Api.Controllers
{
    [ApiController]
    [Produces(AppConstants.JsonContentType)] //Desteklenen response type
    [Route("api/v{version:apiVersion}/[controller]")]
    public class BaseController : ControllerBase
    {
    }
}
