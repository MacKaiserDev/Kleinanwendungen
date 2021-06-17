using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Task_Await
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Method();

            Console.ReadLine();
        }

        public static async void Method()
        {

            Task<int> GetInt = TestTask.IntTask();
            int iRückgabe = await GetInt;
            Console.WriteLine(iRückgabe);
        }

    }
}
