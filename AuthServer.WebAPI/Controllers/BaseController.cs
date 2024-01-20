using Microsoft.AspNetCore.Mvc;
using SharedLibrary.ResponseDto;

namespace AuthServer.WebAPI.Controllers
{
    public class BaseController : ControllerBase
    {
        public IActionResult ActionResultInstance<T>(Response<T> response) where T : class
        {
            return new ObjectResult(response) // Http Response
            {
                StatusCode = response.StatusCode
            };
        }
    }
}
