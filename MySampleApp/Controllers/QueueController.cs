using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MySampleApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QueueController : ControllerBase
    {
        public QueueController()
        {
        }

        [HttpPost]
        [Route("AddMessage")]
        public void AddMessageToQueue(string message)
        {
            using var rabbitMqConnectionManager = new RabbitMqConnectionManager();
            rabbitMqConnectionManager.GetChannel();
            var body = Encoding.UTF8.GetBytes(message);
            rabbitMqConnectionManager.Publish(body);
        }
    }
}
