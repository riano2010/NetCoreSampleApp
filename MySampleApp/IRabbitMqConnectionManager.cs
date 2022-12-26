namespace MySampleApp;

public interface IRabbitMqConnectionManager : IDisposable
{
    void GetChannel();
    void Publish(string routingKey, byte[] data);
}