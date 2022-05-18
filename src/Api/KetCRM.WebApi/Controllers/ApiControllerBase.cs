using Microsoft.AspNetCore.Mvc;

namespace KetCRM.WebApi.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class ApiControllerBase : ControllerBase
    {
    }
}
