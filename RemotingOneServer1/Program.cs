using RemotingOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;

namespace RemotingOneServer1
{
    class Program
    {
        static void Main(string[] args)
        {
            var channel = new TcpServerChannel(8086);
            ChannelServices.RegisterChannel(channel, true);
            RemotingConfiguration.RegisterWellKnownServiceType(
                  typeof(Hello), "Hi", WellKnownObjectMode.SingleCall);
            Console.WriteLine("Press return to exit");
            Console.ReadLine();
        }
    }
}
