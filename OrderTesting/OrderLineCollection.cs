using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoeWars;
using System.Collections.Generic;

namespace ShoeWars
{
    [TestClass]
    public class OrderLineCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class I want to create
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            //test to see that it exists
            Assert.IsNotNull(AllOrderLines);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class I want to create
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 2;
            //assign the data to the property
            AllOrderLines.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrderLines.Count, SomeCount);
        }

        [TestMethod]
        public void OrderLineListOK()
        {
            //create an instance of the class I want to create
            clsOrderLineCollection OrderLines = new clsOrderLineCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrderLine> TestList = new List<clsOrderLine>();
            //add an item to the list of test data
            //create the item of test data
            clsOrderLine TestItem = new clsOrderLine();
            //set its properties
            TestItem.OrderLineID = 1;
            TestItem.OrderID = "1";
            TestItem.ProductID = "1";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            OrderLines.OrderLineList = TestList;
            //test to see thst the two values are the same
            Assert.AreEqual(OrderLines.OrderLineList, TestList);
        }

        [TestMethod]
        public void CountMatchesListOK()
        {
            //create an instance of the class I want to create
            clsOrderLineCollection OrderLines = new clsOrderLineCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrderLine> TestList = new List<clsOrderLine>();
            //add an item to the list of test data
            //create the item of test data
            clsOrderLine TestItem = new clsOrderLine();
            //set its properties
            TestItem.OrderLineID = 1;
            TestItem.OrderID = "1";
            TestItem.ProductID = "1";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            OrderLines.OrderLineList = TestList;
            //test to see thst the two values are the same
            Assert.AreEqual(OrderLines.Count, TestList.Count);
        }

        [TestMethod]
        public void TwoOrderLinesPresent()
        {
            //create an instance of the class I want to create
            clsOrderLineCollection OrderLines = new clsOrderLineCollection();
            //test to see that the two values are the same
            Assert.AreEqual(OrderLines.Count, 2);
        }
    }
}
