using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace The_Complete_cSharp
{
    /// <summary>
    /// The class definitions made in 2 files, partially in Partial_Classes1 and 
    /// Partial_Classes2. The definitions should be logically seperated in some 
    /// files, such as methods somewhere, attribs another, props another etc.
    /// </summary>
    abstract partial class Partial_IOT_Device
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
    }
}
