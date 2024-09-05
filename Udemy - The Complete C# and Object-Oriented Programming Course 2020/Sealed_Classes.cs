using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace The_Complete_cSharp
{
    public class Sealed_IOT_Device
    //public sealed class Sealed_IOT_Device
    {
        public int Id { get; set; } 
        public string? Name { get; set; }    
        public string? Description { get; set; } 

        public string? Address { get; set; }

        IPAddress? SetToServer { get; }
        protected Exception? EncodeDownlink(string Package) { return null; }
        protected Exception? EncodeDownlink(byte[] Package) { return null; }
        protected Exception? DecodeDownlink(string Package) { return null; }
        protected Exception? DecodeDownlink(byte[] Package) { return null; }

        protected Exception? EncodeUplink(string Package) { return null; }
        protected Exception? EncodeUplink(byte[] Package) { return null; }
        protected Exception? DecodeUplink(string Package) { return null; }
        protected Exception? DecodeUplink(byte[] Package) { return null; }

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

    public class Sealed_Gateway : Sealed_IOT_Device
    {
        // The inheritance is possible only if the 
        // sealed definition is removed from Sealed_IOT_Device class
    }
}
