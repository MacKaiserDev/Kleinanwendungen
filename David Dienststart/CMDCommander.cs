using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace David_Dienststart
{
    class CMDCommander
    {
        public static void RunCMDCommand(string sBefehl, int iPID)
        {
            string sCMD = "cmd.exe";

            Process P = new Process();
            P.StartInfo.FileName = sCMD;
            P.StartInfo.CreateNoWindow = false;
            P.StartInfo.UseShellExecute = true;
            P.StartInfo.Arguments= "/c "+sBefehl + " " + iPID +" /f";
            Console.WriteLine( sBefehl +" "+ iPID + " /f");
            Console.WriteLine("Prozess mit ID: "+iPID+" gestoppt");
            P.Start();
            P.Close();
        }

    }
}
