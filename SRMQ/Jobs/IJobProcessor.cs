using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace SRMQ.Jobs
{
    /// <summary>
    /// This interface is to be implemented on any job that would actually do job actions
    /// </summary>
    public interface IJobProcessor
    {
        void Process(BasicDeliverEventArgs Event);
    }
}
