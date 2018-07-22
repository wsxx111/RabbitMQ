using Framework.RabbitMq;
using Framework.RabbitMq.Model;
using Framework.RabbitMq.RabbitMqProxyConfig;
using FrameWork.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWork.RabbitMq.MsgMonitor
{
    public class MainService
    {
        public readonly RabbitMqService _rabbitMqProxy;
        public MainService()
        {
            _rabbitMqProxy = new RabbitMqService(new MqConfig
            {
                AutomaticRecoveryEnabled = true,
                HeartBeat = 60,
                NetworkRecoveryInterval = new TimeSpan(60),
                Host = "192.168.1.109",
                UserName = "wk",
                Password = "111"
            });
        }

        public bool Start()
        {          
            _rabbitMqProxy.Subscribe<MessageModel>(msg =>
            {
                var json = msg.ToJson();
                Console.WriteLine(json);
            });

            return true;
        }

        public bool Stop()
        {          
            _rabbitMqProxy.Dispose();          
            return true;
        }
    }
}
