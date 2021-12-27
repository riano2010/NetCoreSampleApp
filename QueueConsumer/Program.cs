using System.Text;
using QueueConsumer;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

var factory = new ConnectionFactory() { HostName = "localhost" };
using var connection = factory.CreateConnection();
var channel = connection.CreateModel();

var consumer = new EventingBasicConsumer(channel);
var messageProcessor = new MessageProcessor();

consumer.Received += (model, ea) =>
{
    var body = ea.Body.ToArray();
    var message = Encoding.UTF8.GetString(body);


    try
    {
        messageProcessor.Process(message);
        channel.BasicAck(ea.DeliveryTag, false);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Произошла ошибка при обработке сообщения: " + ea.DeliveryTag);
        Console.WriteLine("Произошла ошибка при обработке сообщения: " + ex.Message);
        throw;
        

        channel.BasicNack(ea.DeliveryTag, false, true);
    }

    Console.WriteLine(" [x] Received {0}", message);
};

channel.BasicConsume(queue: "main",
    autoAck: false,
    consumer: consumer);

Console.ReadLine(); 