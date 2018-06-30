using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace SRMQ
{
    /// <summary>
    /// Interface definition for anything that would interact with the RabbitMQ platform
    /// </summary>
    public interface IMessageHandler
    {
        QueueComponents Components { get; set; }
    }
}
