using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace Nunit.Testanwendung.Test
{
    class NUnit_Tests
    {
        #region NUnitStatus()
        [TestCase]
        public void NUnitStatus()
        {
            Assert.IsTrue(true);
        }
        #endregion

        #region TestAddition
        [TestCase]
        public void TestAddition()
        {
            int iTest=Nunit.Testanwendung.Functions.Schubbelwup.MyAddition(2, 2);

            Assert.AreEqual(4, iTest);
        }
        #endregion



    }
}
