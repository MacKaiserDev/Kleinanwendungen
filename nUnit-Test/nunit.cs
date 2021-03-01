using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace nUnit_Test
{
   
    class nunit
    {
        [TestCase]
        public static void MeinTest()
        {
            Assert.AreEqual(2, 2);
        }

    }
}
