using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceProcess;
using System.Management;

namespace David_Dienststart
{
    class Get_Service_PID
    {
        public static int Get_MyService_PID(string ServiceName)
        {
            int iPID = 0; ;

            var MyService = new ServiceController(ServiceName);
            ServiceController[] SCMyServices;

            SCMyServices = ServiceController.GetServices();

            foreach (var item in SCMyServices)
            {
                if (item.ServiceName==ServiceName)
                {
                    ManagementObject MObject=new ManagementObject(@"Win32_service.Name='" + item.ServiceName + "'");
                    var o = MObject.GetPropertyValue("ProcessID");
                    iPID = Int16.Parse(o.ToString());

                }
            }

            return iPID;
        }
    }
}
