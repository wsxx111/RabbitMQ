using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWork.RabbitMq.MsgMonitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("监控启动");
            var app =new MainService();
            app.Start();

            Console.Read();
        }
    }
}
