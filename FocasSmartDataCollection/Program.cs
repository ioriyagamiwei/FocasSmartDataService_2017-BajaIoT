using System.Collections.Generic;
using System.ServiceProcess;
using System.Text;

namespace FocasSmartDataCollection
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            //ServiceBase[] ServicesToRun;
            //ServicesToRun = new ServiceBase[] { new Service1() };
            //ServiceBase.Run(ServicesToRun);

#if (!DEBUG)
             System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] { new FocasSmartDataService() };
            ServiceBase.Run(ServicesToRun);
#else
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            FocasSmartDataService service = new FocasSmartDataService();
            service.StartDebug();
            System.Threading.Thread.Sleep(System.Threading.Timeout.Infinite);
#endif
        }
    }
}