using RabbitMQ.Client;

namespace MySampleApp
{
    public class RabbitMqConnectionManager : IDisposable
    {
        private IConnection? _connection;
        private IModel? _channel;

        private const string QueueName = "main";

        public void GetChannel()
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            _connection = factory.CreateConnection();
            _channel = _connection.CreateModel();

            _channel.QueueDeclare(queue: QueueName,
                durable: true,
                exclusive: false,
                autoDelete: false,
                arguments: null);
        }

        public void Publish(byte[] data)
        {
            _channel.BasicPublish(exchange: "",
                routingKey: QueueName,
                basicProperties: null,
                body: data);
        }

        public void Dispose()
        {
            _connection?.Dispose();
            _channel?.Dispose();
        }
    }
}
