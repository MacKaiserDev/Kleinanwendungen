using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceProcess;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Management;


namespace David_Dienststart
{
    class Program
    {
        static void Main(string[] args)
        {
            var SCGS = new ServiceController("DavidServiceLayer");
            var SCSL = new ServiceController("DavidGrabbingServer");
            int iPIDGrabbingServer = 0;
            int iPIDServiceLayer = 0;

            //Liest die PIDs der Dienste aus
            iPIDServiceLayer = Get_Service_PID.Get_MyService_PID("DavidServiceLayer");
            iPIDGrabbingServer = Get_Service_PID.Get_MyService_PID("DavidGrabbingServer");

            Console.WriteLine("PID-SL: "+ iPIDServiceLayer);
            Console.WriteLine("PID-GS: " + iPIDGrabbingServer);

            Thread.Sleep(3000);
            //Stoppe Serive Layer und Grabbing Server
            Console.WriteLine("Service Layer und Grabbing Server werden gestoppt");

            CMDCommander.RunCMDCommand("taskkill /PID", iPIDServiceLayer);
            CMDCommander.RunCMDCommand("taskkill /PID", iPIDGrabbingServer);

            Thread.Sleep(10000);

            //Startet die Dienste erneut. 
            try
            {
                SCGS.Start();
                Console.WriteLine("Grabbing Server gestartet.");
            }
            catch (Exception)
            {
                //MessageBox.Show("ServiceLayer nicht installiert");
                
            }   

            try
            {
                SCSL.Start();
                Console.WriteLine("David Service Layer gestartet.");
            }
            catch (Exception)
            {
                //MessageBox.Show("ServiceLayer nicht installiert");
                
            }
            Console.WriteLine("--------------------------");

            Console.ReadLine();
            
        }
    }
}
