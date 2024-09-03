using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace The_Complete_cSharp
{
    public abstract class Abstract_IOT_Device
    {
        string? Name { get; }
        IPAddress? Address { get; }
        IPAddress? SetToServer { get; }
        protected abstract Exception? EncodeDownlink(string Package);
        protected abstract Exception? EncodeDownlink(byte[] Package);
        protected abstract Exception? DecodeDownlink(string Package);
        protected abstract Exception? DecodeDownlink(byte[] Package);

        protected abstract Exception? EncodeUplink(string Package);
        protected abstract Exception? EncodeUplink(byte[] Package);
        protected abstract Exception? DecodeUplink(string Package);
        protected abstract Exception? DecodeUplink(byte[] Package);

        /// <summary>
        /// This is a general implementation for all the inherited classes.
        /// This is the reason why we define the method content here. 
        /// We may assume all the inherited IOT devices sending the byte[]
        /// messages in a similar way such as opening socket and sending etc.
        /// </summary>
        /// <param name="Package"></param>
        /// <returns></returns>
        Exception? Send(byte[] Package)
        {
            Socket sck = new Socket(SocketType.Raw, ProtocolType.Tcp);
            return null; 
        }
        /// <summary>
        /// This applies for the Receive method in this abstract class as well.
        /// It will be the common method that will be applied in all inherited
        /// classes, therefore we don't need it being overridden.       
        /// </summary>
        /// <param name="Package"></param>
        /// <returns></returns>
        Exception? Receive(byte[] Package)
        {
            Socket sck = new Socket(SocketType.Raw, ProtocolType.Tcp);              
            return null; 
        }
    }

    public class AbstractGateway : Abstract_IOT_Device
    {
        protected override Exception? DecodeDownlink(string Package)
        {
            Console.WriteLine("Decode downlink implemented in AbstractGateway");
            return null;
        }

        protected override Exception? DecodeDownlink(byte[] Package)
        {
            Console.WriteLine("Decode downlink implemented in AbstractGateway");
            return null;
        }

        protected override Exception? DecodeUplink(string Package)
        {
            Console.WriteLine("Decode uplink implemented in AbstractGateway");
            return null;
        }

        protected override Exception? DecodeUplink(byte[] Package)
        {
            // This method is overridden because it's not defined in the 
            // abstract class as abstract

            Console.WriteLine("Decode uplink implemented in AbstractGateway");
            return null;
        }

        protected override Exception? EncodeDownlink(string Package)
        {
            Console.WriteLine("Encode downlink implemented in AbstractGateway");
            return null;
        }

        protected override Exception? EncodeDownlink(byte[] Package)
        {
            Console.WriteLine("Encode downlink implemented in AbstractGateway");
            return null;
        }

        protected override Exception? EncodeUplink(string Package)
        {
            Console.WriteLine("Encode uplink implemented in AbstractGateway");
            return null;
        }

        protected override Exception? EncodeUplink(byte[] Package)
        {
            Console.WriteLine("Encode uplink implemented in AbstractGateway");
            return null;
        }

        public virtual Exception? SendDataToServer(byte[] downlinkData)
        {
            return new IOException();           
        }
    }

    public class AbstractMultitech : AbstractGateway
    {
        public override Exception? SendDataToServer(byte[] downlinkData)
        {
            return base.SendDataToServer(downlinkData); 
        }
    }

}
