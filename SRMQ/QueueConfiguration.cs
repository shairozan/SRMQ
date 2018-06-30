using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace SRMQ
{
    public class QueueConfiguration
    {
        public string Host { get; set; }
        public string Queue { get; set; }
        public MessageConfiguration MessageConfiguration { get; set; }
    }
}
