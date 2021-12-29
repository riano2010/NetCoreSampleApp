using System.Text;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MySampleApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QueueController : ControllerBase
    {
        public IRabbitMqConnectionManager RabbitMqConnectionManager { get; }

        public QueueController(IRabbitMqConnectionManager rabbitMqConnectionManager)
        {
            RabbitMqConnectionManager = rabbitMqConnectionManager;
        }

        [HttpPost]
        [Route("AddMessage")]
        public async Task AddMessageToQueue(string message, string routingKey)
        {
            RabbitMqConnectionManager.GetChannel();

            await using var memoryStream = new MemoryStream();
            await JsonSerializer.SerializeAsync<Message>(memoryStream, new Message(message));

            RabbitMqConnectionManager.Publish(routingKey, memoryStream.ToArray());
            RabbitMqConnectionManager.Dispose();
        }
    }

    public class Message
    {
        public Message(string text)
        {
            Text = text;
        }

        public string Text { get; set; }
    }
}
