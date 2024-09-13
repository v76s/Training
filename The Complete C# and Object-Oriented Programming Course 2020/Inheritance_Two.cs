using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace The_Complete_cSharp
{
    interface IOT_Device
    {
        string? Name { get; }
        IPAddress? Address { get; }
        IPAddress? SetToServer { get; }  
        Exception? EncodeDownlink(string Package);
        Exception? EncodeDownlink(byte[] Package);
        Exception? DecodeDownlink(string Package);
        Exception? DecodeDownlink(byte[] Package);

        Exception? EncodeUplink (string Package);
        Exception? EncodeUplink(byte[] Package);
        Exception? DecodeUplink(string Package);
        Exception? DecodeUplink(byte[] Package);  

        Exception? Send(byte[] Package);
        Exception? Receive(byte[] Package);
    }

    public class Gateway : IOT_Device
    {
        public Gateway()
        {
            Console.WriteLine("Gateway constructor implemented ..."); 
        }
        public string? Name {get; set;}

        public IPAddress? Address { get; set; }

        public IPAddress? SetToServer { get; set; }

        public virtual Exception? DecodeDownlink(string Package)
        {
            Console.WriteLine("Decode downlink implemented in Gateway"); 
            return null;    
        }

        public Exception? DecodeDownlink(byte[] Package)
        {
            Console.WriteLine("Decode downlink implemented in Gateway");
            return null;
        }

        public Exception? DecodeUplink(string Package)
        {
            Console.WriteLine("Decode uplink implemented in Gateway");
            return null;
        }

        public Exception? DecodeUplink(byte[] Package)
        {
            Console.WriteLine("Decode downlink implemented in Gateway");
            return null;
        }

        public Exception? EncodeDownlink(string Package)
        {
            Console.WriteLine("Encode downlink implemented in Gateway");
            return null;
        }

        public Exception? EncodeDownlink(byte[] Package)
        {
            Console.WriteLine("Encode downlink implemented in Gateway");
            return null;
        }

        public Exception? EncodeUplink(string Package)
        {
            Console.WriteLine("Encode uplink implemented in Gateway");
            return null;
        }

        public Exception? EncodeUplink(byte[] Package)
        {
            Console.WriteLine("Encode uplink implemented in Gateway");
            return null;
        }

        public Exception? Receive(byte[] Package)
        {
            Console.WriteLine("Receive implemented in Gateway");
            return null;
        }

        public virtual Exception? Send(byte[] Package)
        {
            Console.WriteLine("Send implemented in Gateway");
            return null;
        }
    }

    public class Multitech : Gateway
    {
        public Multitech()
        {
            Console.WriteLine("Multitech constructor implemented ...");
        }
        /// <summary>
        /// Watch where the base is implemented
        /// </summary>
        /// <param name="Package"></param>
        /// <returns></returns>
        public new Exception? Receive(byte[] Package)
        {
            base.Receive(Package);  
            Console.WriteLine("Receive implemented in Multitech");
            return null;
        }

        public override Exception? Send(byte[] Package)
        {
            Console.WriteLine("Send implemented in Multitech");
            return null;
        }


    }
}
