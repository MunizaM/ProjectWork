using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoeWars.Properties;

namespace TestFramework
{
    [TestClass]
    public class tstPayment
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of our class clsPayment
            clsPayment APayment = new clsPayment();
            //check to see that the class is not null
            Assert.IsNotNull(APayment);
        }
    }
}
