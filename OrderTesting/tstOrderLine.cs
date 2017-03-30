using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoeWars;

namespace ShoeWars
{
    [TestClass]
    public class tstOrderLine
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class I want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //test to see that it exists
            Assert.IsNotNull(AnOrderLine);
        }

        [TestMethod]
        public void OrderLineID()
        {
            //create an instance of the class I want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //create some test data to assign to the property
            Int32 OrderLineID = 1;
            //assign the data to the property
            AnOrderLine.OrderLineID = OrderLineID;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderLine.OrderLineID, OrderLineID);
            
        }

        [TestMethod]
        public void OrderID()
        {
            //create an instance of the class I want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //create some test data to assign to the property
            String OrderID = "1";
            //assign the data to the property
            AnOrderLine.OrderID = OrderID;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderLine.OrderID, OrderID);

        }

        [TestMethod]
        public void ProductID()
        {
            //create an instance of the class I want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //create some test data to assign to the property
            String ProductID = "1";
            //assign the data to the property
            AnOrderLine.ProductID = ProductID;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderLine.ProductID, ProductID);

        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class I want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to assign to the property
            String SomeOrder = "1";
            OK = AnOrderLine.Valid(SomeOrder);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
    }
}
