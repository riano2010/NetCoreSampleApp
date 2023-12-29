using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OcrCamundaService
{
    [Route("api/ocrrequests")]
    [ApiController]
    public class OcrRequestsController : ControllerBase
    {
        [HttpPost]
        public object Create(int value)
        {
            return new
            {
                result = value
            };
        }
    }
}
