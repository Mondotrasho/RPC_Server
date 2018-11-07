using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels;

    class Program
    {
        static void Main(string[] args)
        {
            //Create Server
            TcpServerChannel channel = new TcpServerChannel(1337);
            ChannelServices.RegisterChannel(channel, false);

            //Register Player
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(Player),"Little",WellKnownObjectMode.SingleCall);

            //Pause
            Console.WriteLine("Listening for requests.\nPress enter to exit...\n");
            Console.ReadLine();
        }
    }