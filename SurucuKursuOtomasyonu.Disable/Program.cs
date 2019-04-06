using System.ServiceProcess;

namespace SurucuKursuOtomasyonu.Information
{
    internal static class Program
    {
        /// <summary>
        ///     Uygulamanın ana girdi noktası.
        /// </summary>
        private static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new Service1()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}