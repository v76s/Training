using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace The_Complete_cSharp
{
    abstract partial class Partial_IOT_Device
    {
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
}
