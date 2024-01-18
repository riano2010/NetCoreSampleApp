using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OcrCamundaService
{
    [Route("api/ocrrequests")]
    [ApiController]
    public class OcrRequestsController : ControllerBase
    {
        public class OcrResult
        {
            public bool success { get; set; }
        }

        [HttpPost]
        public object Create([FromBody]string value)
        {

            OcrResult ocrResult = new OcrResult();

            if (string.IsNullOrWhiteSpace(value)) { 
                ocrResult.success = false;
            }
            else if (value.Contains("bad"))
            {
               ocrResult.success = false;
            }
            else
            {
                ocrResult.success = true;
            }


            return ocrResult;
        }
    }
}
