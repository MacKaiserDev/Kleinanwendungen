using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task_Await
{
    class TestTask
    {
        public static async Task<int> IntTask()
        {
            int Rückgabe = 0;
            Thread.Sleep(5000);

            return Rückgabe;
        }
    }
}
