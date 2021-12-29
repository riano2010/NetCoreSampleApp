using System.Text;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

if (args.Length != 1)
{
    Console.WriteLine("routing_key must have!");
    return;
}


var factory = new ConnectionFactory() { HostName = "localhost" };
using var connection = factory.CreateConnection();
var channel = connection.CreateModel();

channel.ExchangeDeclare(exchange: "main", type: "topic");
var queueName = channel.QueueDeclare().QueueName;

channel.QueueBind(queue: queueName,
    exchange: "main",
    routingKey: "import");

var consumer = new EventingBasicConsumer(channel);

consumer.Received += (model, ea) =>
{
    var body = ea.Body.ToArray();
    var message = Encoding.UTF8.GetString(body);


    try
    {
        Console.WriteLine("Получено сообщение из очереди: "+ ea.DeliveryTag);

        Thread.Sleep(5000);
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

channel.BasicConsume(queue: queueName,
    autoAck: false,
    consumer: consumer);

Console.ReadLine();