using System;
using Framework.RabbitMq.RabbitMqProxyConfig;

namespace Framework.RabbitMq.Model
{
    [RabbitMq("WK.QueueName.Monitor", ExchangeName = "Wk.ExchangeName", IsProperties = false)]
    public class MessageModel
    {
        public string Msg { get; set; }

        public DateTime CreateDateTime { get; set; }
    }
}
