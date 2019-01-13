using System;
using System.IO.Ports;
using System.Linq;
using System.Management;
using PowerSupplyManager.Dto;

namespace PowerSupplyManager
{
    internal class ComManager
    {
        public static ComInfo[] ListComPorts()
        {
            try
            {
                using (var searcher = new ManagementObjectSearcher("root\\WMI",
                                                                   "SELECT * FROM MSSerial_PortName WHERE Active=True"))
                {
                    var portNames = SerialPort.GetPortNames();
                    var ports = searcher.Get()
                                        .Cast<ManagementObject>()
                                        .Select(x => new
                                        {
                                            InstanceName = x["InstanceName"].ToString(),
                                            PortName = x["PortName"].ToString(),
                                        })
                                        .ToArray();

                    return (from pn in portNames
                            join p in ports on pn equals p.PortName
                            select p)
                           .Select(x => new ComInfo
                           {
                               Name = x.PortName,
                               EqualUsbVid = x.InstanceName.Contains(VendorId) &&
                                             x.InstanceName.Contains(ProductId)
                           })
                           .ToArray();
                }
            }
            catch
            {
                // empty
            }

            return new ComInfo[] { };
        }

        public static void SetComPort(string comPort)
        {
            if (string.IsNullOrWhiteSpace(comPort))
            {
                throw new Exception("Wrong COM port!");
            }

            _comPort = comPort;
        }

        public static string GetComPort()
        {
            return _comPort;
        }

        private static string _comPort;

        private const string VendorId = "VID_0403";
        private const string ProductId = "PID_6001";
    }
}
