using RabbitMQ;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace SRMQ
{
    public class QueueComponents
    {
        public IConnection Channel { get; set; }
        public IModel Model { get; set; }
        public QueueConfiguration Config { get; set; }
        public EventingBasicConsumer Consumer { get; set; }
    }
}
