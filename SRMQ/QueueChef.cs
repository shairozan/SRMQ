using RabbitMQ;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace SRMQ
{
    public static class QueueChef
    {
        public static QueueComponents Configure(QueueConfiguration conf)       
        {
            QueueComponents qnew = new QueueComponents();
            qnew.Config = conf;
            var factory = new ConnectionFactory() { HostName = qnew.Config.Host };
            qnew.Channel = factory.CreateConnection();
            qnew.Model = qnew.Channel.CreateModel();

            qnew.Model.QueueDeclare(queue: qnew.Config.Queue,
                                 durable: false,
                                 exclusive: false,
                                 autoDelete: false,
                                 arguments: null);

            qnew.Consumer = new EventingBasicConsumer(qnew.Model);

            return qnew;
        }
    }
}
