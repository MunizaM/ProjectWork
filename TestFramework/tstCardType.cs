using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoeWars;

namespace TestFramework
{
    [TestClass]
    public class tstCardType
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //test to see that it exists
            Assert.IsNotNull(APayment);
        }

        [TestMethod]
        public void CardDetailsExist()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //create some test data to assign to the property
            String TestData = "1";
            //assign the data to the property
            APayment.CardDetails = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(APayment.CardDetails, TestData);
        }

        [TestMethod]
        public void CardTypeExist()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //create some test data to asign to the property
            string TestData = "Visa";
            //assign the data to the property
            APayment.CardType = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(APayment.CardType, TestData);
        }

        [TestMethod]
        public void CustomerIDExist()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //assign the data to the property
            Int32 TestData = 1;
            //assign the data to the property
            APayment.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(APayment.CustomerID, TestData);
        }

        [TestMethod]
        public void DatePurchasedExist()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            APayment.DatePurchased = TestData;
            //test to see the two values are the same
            Assert.AreEqual(APayment.DatePurchased, TestData);
        }

        [TestMethod]
        public void OrderIDExist()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            APayment.OrderID = TestData;
            //test to see the two values are the same
            Assert.AreEqual(APayment.OrderID, TestData);
        }

        [TestMethod]
        public void PaymentIDExist()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            APayment.PaymentID = TestData;
            //test to see the two values are the same
            Assert.AreEqual(APayment.PaymentID, TestData);
        }

        [TestMethod]
        public void TotalExist()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //create some test data
            Int32 TestData = 1;
            //assign the test data to the property
            APayment.Total = TestData;
            //test to see the two values are the same
            Assert.AreEqual(APayment.Total, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 PaymentID = 10;
            //invoke the method 
            Found = APayment.Find(PaymentID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestPaymentIDFound()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PaymentID = 10;
            //invoke the method 
            Found = APayment.Find(PaymentID);
            //check the property
            if (APayment.PaymentID != 10)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderIDFound()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PaymentID = 10;
            //invoke the method 
            Found = APayment.Find(PaymentID);
            //check the property
            if (APayment.OrderID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCardDetailsFound()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PaymentID = 10;
            //invoke the method 
            Found = APayment.Find(PaymentID);
            //check the property
            if (APayment.CardDetails != "4055123488886523")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCardTypeFound()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PaymentID = 10;
            //invoke the method 
            Found = APayment.Find(PaymentID);
            //check the property
            if (APayment.CardType != "Visa")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PaymentID = 10;
            //invoke the method 
            Found = APayment.Find(PaymentID);
            //check the property
            if (APayment.CustomerID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTotalFound()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PaymentID = 10;
            //invoke the method 
            Found = APayment.Find(PaymentID);
            //check the property
            if (APayment.Total != 60)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDatePurchasedFound()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PaymentID = 10;
            //invoke the method 
            Found = APayment.Find(PaymentID);
            //check the property
            if (APayment.DatePurchased != Convert.ToDateTime("16/03/2017"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //boolean variable to store th result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string CardDetails = "4055123488886523";
            string CardType = "Visa";
            string DatePurchased = DateTime.Now.Date.ToString();
            //invoke the method
            OK = APayment.Valid(CardDetails, CardType, DatePurchased);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void CardDetailsMinLessOne()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //boolean variable to store th result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string CardDetails = ""; //this should trigger an error
            string CardType = "Visa";
            string DatePurchased = DateTime.Now.Date.ToString();
            //invoke the method
            OK = APayment.Valid(CardDetails, CardType, DatePurchased);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void CardDetailsMin()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //boolean variable to store th result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string CardDetails = "4"; //this should be ok
            string CardType = "Visa";
            string DatePurchased = DateTime.Now.Date.ToString();
            //invoke the method
            OK = APayment.Valid(CardDetails, CardType, DatePurchased);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CardDetailsMinPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //boolean variable to store th result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string CardDetails = "40"; //this should be ok
            string CardType = "Visa";
            string DatePurchased = DateTime.Now.Date.ToString();
            //invoke the method
            OK = APayment.Valid(CardDetails, CardType, DatePurchased);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void CardDetailsMaxLessOne()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //boolean variable to store th result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string CardDetails = "405512348888652"; //this should be ok
            string CardType = "Visa";
            string DatePurchased = DateTime.Now.Date.ToString();
            //invoke the method
            OK = APayment.Valid(CardDetails, CardType, DatePurchased);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CardDetailsMax()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //boolean variable to store th result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string CardDetails = "4055123488886523"; //this should be ok
            string CardType = "Visa";
            string DatePurchased = DateTime.Now.Date.ToString();
            //invoke the method
            OK = APayment.Valid(CardDetails, CardType, DatePurchased);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CardDetailsMid()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //boolean variable to store th result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string CardDetails = "40551234"; //this should be ok
            string CardType = "Visa";
            string DatePurchased = DateTime.Now.Date.ToString();
            //invoke the method
            OK = APayment.Valid(CardDetails, CardType, DatePurchased);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CardDetailsMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //boolean variable to store th result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string CardDetails = "40551234888865234"; //this should be fail
            string CardType = "Visa";
            string DatePurchased = DateTime.Now.Date.ToString();
            //invoke the method
            OK = APayment.Valid(CardDetails, CardType, DatePurchased);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void CardDetailsExtremeMax()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //boolean variable to store th result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string CardDetails = "";
            CardDetails = CardDetails.PadRight(500, 'a'); //this should be fail
            string CardType = "Visa";
            string DatePurchased = DateTime.Now.Date.ToString();
            //invoke the method
            OK = APayment.Valid(CardDetails, CardType, DatePurchased);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void DatePurchasedExtremeMin()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //boolean variable to store th result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string CardDetails = "405512348888652"; 
            string CardType = "Visa";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the data to todays date
            TestDate = DateTime.Now.Date;
            //change the date varibale to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variabale to a string variable
            string DatePurchased = TestDate.ToString();
            //invoke the method
            OK = APayment.Valid(CardDetails, CardType, DatePurchased);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void DatePurchasedMinLessOne()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //boolean variable to store th result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string CardDetails = "405512348888652"; 
            string CardType = "Visa";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the data to todays date
            TestDate = DateTime.Now.Date;
            //change the date varibale to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-1);
            //convert the date variabale to a string variable
            string DatePurchased = TestDate.ToString();
            //invoke the method
            OK = APayment.Valid(CardDetails, CardType, DatePurchased);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void DatePurchasedMin()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //boolean variable to store th result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string CardDetails = "405512348888652"; 
            string CardType = "Visa";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the data to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variabale to a string variable
            string DatePurchased = TestDate.ToString();
            //invoke the method
            OK = APayment.Valid(CardDetails, CardType, DatePurchased);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DatePurchasedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //boolean variable to store th result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string CardDetails = "405512348888652";
            string CardType = "Visa";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the data to todays date
            TestDate = DateTime.Now.Date;
            //change the date varibale to whatever the date plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variabale to a string variable
            string DatePurchased = TestDate.ToString();
            //invoke the method
            OK = APayment.Valid(CardDetails, CardType, DatePurchased);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void DatePurchasedExtremeMax()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //boolean variable to store th result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string CardDetails = "405512348888652"; 
            string CardType = "Visa";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the data to todays date
            TestDate = DateTime.Now.Date;
            //change the date varibale to whatever the date plus 1 day
            TestDate = TestDate.AddYears(100);
            //convert the date variabale to a string variable
            string DatePurchased = TestDate.ToString();
            //invoke the method
            OK = APayment.Valid(CardDetails, CardType, DatePurchased);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void DatePurchasedInvalidData()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //boolean variable to store th result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string CardDetails = "405512348888652"; 
            string CardType = "Visa";
            //set the DatePurchased to a non date value
            string DatePurchased = "this is not a date!";
            //invoke the method
            OK = APayment.Valid(CardDetails, CardType, DatePurchased);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void CardTypeMinLessOne()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //boolean variable to store th result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string CardDetails = "4055123488886523"; 
            string CardType = "";
            string DatePurchased = "16/03/2017";
            //invoke the method
            OK = APayment.Valid(CardDetails, CardType, DatePurchased);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void CardTypeMin()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //boolean variable to store th result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string CardDetails = "4055123488886523"; 
            string CardType = "V";
            string DatePurchased = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = APayment.Valid(CardDetails, CardType, DatePurchased);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CardTypeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //boolean variable to store th result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string CardDetails = "4055123488886523"; 
            string CardType = "Vi";
            string DatePurchased = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = APayment.Valid(CardDetails, CardType, DatePurchased);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CardTypeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //boolean variable to store th result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string CardDetails = "4055123488886523"; 
            string CardType = "";
            CardType = CardType.PadRight(9, 'v');
            string DatePurchased = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = APayment.Valid(CardDetails, CardType, DatePurchased);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CardTypeMax()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //boolean variable to store th result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string CardDetails = "4055123488886523"; 
            string CardType = "";
            CardType = CardType.PadRight(10, 'v');
            string DatePurchased = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = APayment.Valid(CardDetails, CardType, DatePurchased);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CardTypeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //boolean variable to store th result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string CardDetails = "4055123488886523";
            string CardType = "";
            CardType = CardType.PadRight(11, 'v');
            string DatePurchased = "16/03/2017";
            //invoke the method
            OK = APayment.Valid(CardDetails, CardType, DatePurchased);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void CardTypeMid()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //boolean variable to store th result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string CardDetails = "4055123488886523";
            string CardType = "";
            CardType = CardType.PadRight(5, 'v');
            string DatePurchased = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = APayment.Valid(CardDetails, CardType, DatePurchased);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }

}
