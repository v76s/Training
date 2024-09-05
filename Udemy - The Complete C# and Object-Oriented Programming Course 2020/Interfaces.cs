using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace The_Complete_cSharp
{
    public class Backhaul_Config
    {
        public Backhaul_Config() { IPAddress = null; }
        IPAddress? IPAddress { get; set; }
        public int Port { get; set; }
        public string? Name { get; set; }
    }

    public class Adaptive_Data_Rate_Config
    {
        public Adaptive_Data_Rate_Config() { IPAddress = null; }
        IPAddress? IPAddress { get; set; }
        public int Port { get; set; }
        public bool ADREnabled { get; set; }
    }
    interface IIOT_Device 
    {
        string Name { get; }    
        string Description { get; } 
        
        Exception? CollectData(IPAddress address);  
        Exception? Connect(IPAddress address);
        Exception? Disconnect();
        object? ProcessData(byte[] uplink);
        object? PowerManagement(); 
    }

    interface ILoRa_Gateway
    {
        string Name { get; }
        string Brand { get; }
        Exception? LoRa_Protocol_CollectData(string RF_Source);
        void Configure_Multichannel(bool Multichannel);
        void Configure_BiDirectionalCommunication(bool BiDirectional);
        Exception? Configure_Backhaul_Connectivity(Backhaul_Config config);
        Exception? Adaptive_Data_Rate_Configuration(Adaptive_Data_Rate_Config config); 
    }

    public class Interface_Multitech : IIOT_Device, ILoRa_Gateway
    {
        public string Name => throw new NotImplementedException();

        public string Description => throw new NotImplementedException();

        string ILoRa_Gateway.Name => throw new NotImplementedException();

        string ILoRa_Gateway.Brand => throw new NotImplementedException();

        public Exception? CollectData(IPAddress address)
        {
            Console.Write("Collect data method completed without any exceptions"); 
            return null;    
        }

        public Exception? Connect(IPAddress address)
        {
            Console.Write("Connect method completed without any exceptions");
            return null;
        }

        public Exception? Disconnect()
        {
            Console.Write("Disonnection completed without any exceptions");
            return null;
        }

        public object? PowerManagement()
        {
            Console.Write("Power management returned the current configuration of the power management as below ...");
            return null;
        }

        public object? ProcessData(byte[] uplink)
        {
            Console.Write("Process data basically parses the uplink information in a readable format ...");
            return null;
        }

        Exception? ILoRa_Gateway.Adaptive_Data_Rate_Configuration(Adaptive_Data_Rate_Config config)
        {
            Console.Write("Adaptive data rate configuration completed");
            return null;
        }

        Exception? ILoRa_Gateway.Configure_Backhaul_Connectivity(Backhaul_Config config)
        {
            Console.Write("Wifi connection established to communicate with the LoRa Server");
            return null;
        }

        void ILoRa_Gateway.Configure_BiDirectionalCommunication(bool BiDirectional)
        {
            Console.Write("Downlinks enabled ...");            
        }

        void ILoRa_Gateway.Configure_Multichannel(bool Multichannel)
        {
            Console.Write("Multichannel enabled ...");
        }

        Exception? ILoRa_Gateway.LoRa_Protocol_CollectData(string RF_Source)
        {
            Console.Write("Collection of data enabled by default ...");
            return new HttpProtocolException(0x011,RF_Source,null);    
        }
    }
}
