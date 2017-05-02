using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoeWars;

namespace TestFramework
{
    [TestClass]
    public class tstPaymentCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            //test to see that it exists
            Assert.IsNotNull(AllPayments);
        }

        [TestMethod]
        public void PaymentListOK()
        {
            //create an instance of the class we want to create
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            //create some data to assign to the property 
            //in this case the data needs to be a list of objects 
            List<clsPayment> TestList = new List<clsPayment>();
            //add an item to the list
            //create the item of test data
            clsPayment TestItem = new clsPayment();
            //set its properties 
            TestItem.CardDetails = "4055123488886523";
            TestItem.CardType = "Visa";
            TestItem.CustomerID = 1;
            TestItem.DatePurchased = DateTime.Now.Date;
            TestItem.OrderID = 1;
            TestItem.PaymentID = 10;
            TestItem.Total = 60;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllPayments.PaymentList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllPayments.PaymentList, TestList);
        }

     
        [TestMethod]
        public void ThisPaymentPropertyOK()
        {
            //create an instance of the class we want to create
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            //create some data to assign to the property 
            clsPayment TestPayment = new clsPayment();
            //set the properties of the test objects 
            TestPayment.CardDetails = "4055123488886523";
            TestPayment.CardType = "Visa";
            TestPayment.CustomerID = 1;
            TestPayment.DatePurchased = DateTime.Now.Date;
            TestPayment.OrderID = 1;
            TestPayment.PaymentID = 10;
            TestPayment.Total = 60;
            //assign the data to the property
            AllPayments.ThisPayment = TestPayment;
            //test to see that the two values are the same
            Assert.AreEqual(AllPayments.ThisPayment, TestPayment);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            //create some data to assign to the property
            //in this case the data needs to be a list of objects 
            List<clsPayment> TestList = new List<clsPayment>();
            //add the item to the list
            //create the item to the test data
            clsPayment TestItem = new clsPayment();
            //set its properties
            TestItem.CardDetails = "4055123488886523";
            TestItem.CardType = "Visa";
            TestItem.CustomerID = 1;
            TestItem.DatePurchased = DateTime.Now.Date;
            TestItem.OrderID = 1;
            TestItem.PaymentID = 10;
            TestItem.Total = 60;
            //add the item to the test list
            AllPayments.PaymentList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllPayments.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            //create the item of test data 
            clsPayment TestItem = new clsPayment();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CardDetails = "4055123488886523";
            TestItem.CardType = "Visa";
            TestItem.CustomerID = 1;
            TestItem.DatePurchased = DateTime.Now.Date;
            TestItem.OrderID = 1;
            TestItem.PaymentID = 10;
            TestItem.Total = 60;
            //set this ThisPayment to the test data
            AllPayments.ThisPayment = TestItem;
            //add the record
            PrimaryKey = AllPayments.Add();
            //set the primary key of the test data
            TestItem.PaymentNo = PrimaryKey;
            //find the record
            AllPayments.ThisPayment.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllPayments.ThisPayment, TestItem);

        }

     }
}
