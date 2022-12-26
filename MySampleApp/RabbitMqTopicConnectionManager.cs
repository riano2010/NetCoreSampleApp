using RabbitMQ.Client;

namespace MySampleApp;

public class RabbitMqTopicConnectionManager : IRabbitMqConnectionManager
{
    private IConnection? _connection;
    private IModel? _channel;

    private const string ExchangeName = "main";

    public void GetChannel()
    {
        var factory = new ConnectionFactory() { HostName = "localhost" };
        _connection = factory.CreateConnection();
        _channel = _connection.CreateModel();

        _channel.ExchangeDeclare(exchange: ExchangeName, type: "topic");
    }

    public void Publish(string routingKey, byte[] data)
    {
        _channel.BasicPublish(
                exchange: ExchangeName,
                routingKey:routingKey,
                basicProperties: null,
                body: data
            );
    }

    public void Dispose()
    {
        _connection?.Dispose();
        _channel?.Dispose();

        _connection = null;
        _channel = null;
    }
}