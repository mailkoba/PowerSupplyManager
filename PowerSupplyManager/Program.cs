using System;
using System.Linq;
using System.Windows.Forms;

namespace PowerSupplyManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SetPort();
            Application.Run(new FormMain());
        }

        private static void SetPort()
        {
            var ports = ComManager.ListComPorts();
            if (ports.Count(x => x.EqualUsbVid) > 0)
            {
                ComManager.SetComPort(ports.First(x => x.EqualUsbVid).Name);
            }
        }
    }
}
