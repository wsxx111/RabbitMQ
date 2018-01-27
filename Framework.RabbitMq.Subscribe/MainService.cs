using System;
using Framework.RabbitMq.Model;
using Framework.RabbitMq.RabbitMqProxyConfig;
using FrameWork.Extension;

namespace Framework.RabbitMq.Subscribe
{
    public class MainService
    {
        private readonly RabbitMqService _rabbitMqProxy;
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
