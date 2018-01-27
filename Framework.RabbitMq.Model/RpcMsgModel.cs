using System;
using Framework.RabbitMq.RabbitMqProxyConfig;

namespace Framework.RabbitMq.Model
{
    [RabbitMq("Wk.Rpc.QueueName", ExchangeName = "Wk.Rpc.ExchangeName", IsProperties = false)]
    public class RpcMsgModel
    {
        public string Msg { get; set; }

        public DateTime CreateDateTime { get; set; }
    }
}
