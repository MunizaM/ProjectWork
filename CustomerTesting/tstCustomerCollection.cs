using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoeWars;
using System.Collections.Generic;

namespace ShoeWars
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }
        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property, the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list and create the item of the test data
            clsCustomer TestItem = new clsCustomer();
            //set the properties
            TestItem.CustomerID = 2;
            TestItem.Forename = "Muniza";
            TestItem.Surname = "Malamji";
            TestItem.Address = "Field Lane";
            TestItem.Town = "Leicester";
            TestItem.Postcode = "LE15SP";
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.Mobile = "07123456789";
            TestItem.Active = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //asign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 2;
            //asign the data to the property
            AllCustomers.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, SomeCount);
        }
        [TestMethod]
        public void ThisCustomerOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.CustomerID = 2;
            TestCustomer.Forename = "Muniza";
            TestCustomer.Surname = "Malamji";
            TestCustomer.Address = "Field Lane";
            TestCustomer.Town = "Leicester";
            TestCustomer.Postcode = "LE15SP";
            TestCustomer.DateOfBirth = DateTime.Now.Date;
            TestCustomer.Mobile = "07123456789";
            TestCustomer.Active = true;
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property, the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list and create the item of the test data
            clsCustomer TestItem = new clsCustomer();
            //set the properties
            TestItem.CustomerID = 2;
            TestItem.Forename = "Muniza";
            TestItem.Surname = "Malamji";
            TestItem.Address = "Field Lane";
            TestItem.Town = "Leicester";
            TestItem.Postcode = "LE15SP";
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.Mobile = "07123456789";
            TestItem.Active = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }
        [TestMethod]
        public void TwoRecordsPresent()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that the two values are the same 
            Assert.AreEqual(AllCustomers.Count, 2);
        }
    }
}
