using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;
using PowerShell = System.Management.Automation.PowerShell;

namespace PowershellController
{
    class Program
    {
        static void Main(string[] args)
        {
            //unter.net 4.x ist die system.managemente automatation nur bis Version 5 lauffähig. höhere Versionen erfordern .net Core 5.x.
            //https://www.nuget.org/packages/Microsoft.PowerShell.5.ReferenceAssemblies/ 

            using (PowerShell powershell = PowerShell.Create().AddCommand("get-process"))
            {
                Console.WriteLine("Process              HandleCount");
                Console.WriteLine("--------------------------------");

                // Invoke the command synchronously and display the
                // ProcessName and HandleCount properties of the
                // objects that are returned.
                foreach (PSObject result in powershell.Invoke())
                {
                    Console.WriteLine(
                                "{0,-50} {1}",
                                result.Members["ProcessName"].Value,
                                result.Members["HandleCount"].Value);
                }
            }

            System.Console.WriteLine("Hit any key to exit...");
            System.Console.ReadKey();
        }
    }
}
