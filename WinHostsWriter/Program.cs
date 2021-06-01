using System;
using System.IO;
using System.Text;

namespace WinHostsWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string Server_IP, Server_Name;

            Console.WriteLine("David Server IP im Format eingeben. Beispiel: 192.168.23.145");
            Server_IP=Console.ReadLine();

            Console.WriteLine("DNS Namen des David Servers eingeben. Beispiel: David.poltergeist.local");
            Server_Name = Console.ReadLine();

            string Eintrag = Server_IP + " " + Server_Name;
            //string path = @"C:\Windows\System32\drivers\etc\hosts";
            string path = @"C:\Users\stefa\Desktop\hosts";
            FileStream fs = File.Open(path, FileMode.Open, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            StreamWriter W = File.AppendText(path);

            W.WriteLine(Eintrag);
            //sw.WriteLine(Eintrag);
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
