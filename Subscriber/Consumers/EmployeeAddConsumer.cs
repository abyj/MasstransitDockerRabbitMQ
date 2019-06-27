using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MassTransit;
using MessageContracts;

namespace Subscriber.Consumers
{
    public class EmployeeAddConsumer : IConsumer<EmployeeAdded>
    {
        public Task Consume(ConsumeContext<EmployeeAdded> context)
        {
            Console.WriteLine($"Receive message value: {context.Message.EmployeeId}");
            return Task.CompletedTask;
        }
    }
   
}
