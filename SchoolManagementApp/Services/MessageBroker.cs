using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementApp.Services
{
    public class MessageBroker
    {
        private readonly IConnection _connection;

        public MessageBroker(IConnection connection)
        {
            _connection = connection;
        }
        public async Task SendMessage(string studentJson)
        {
            using (var channel = _connection.CreateModel())
            {
                channel.QueueDeclare(queue: "students",
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                
                var body = Encoding.UTF8.GetBytes(studentJson);

                channel.BasicPublish(exchange: "",
                                     routingKey: "students",
                                     basicProperties: null,
                                     body: body);
                Console.WriteLine(" [x] Sent {0}", studentJson);
            }

            Console.WriteLine(" Press [enter] to exit.");
        }
    }
}