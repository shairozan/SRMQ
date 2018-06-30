using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace SRMQ.Send
{
    public class PostMaster : IMessageHandler
    {
        public QueueComponents Components { get; set; }

        public PostMaster(QueueConfiguration c)
        {

            Components = QueueChef.Configure(c);
        }

        public void Send(string Message)
        {
            var body = Encoding.UTF8.GetBytes(Message);

            Components.Model.BasicPublish(exchange: "",
                                 routingKey: Components.Config.Queue, //This should match the queue name
                                 basicProperties: null,
                                 body: body);

            //Console.WriteLine(" [x] Sent {0}", Message);
            Components.Model.Close(); // Close the Queue connection
            Components.Channel.Close(); // Close the connection
        }
    }
}
