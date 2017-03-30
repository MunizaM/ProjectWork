using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoeWars;

namespace ShoeWars
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);

        }

        [TestMethod]
        public void ActiveExists()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            ACustomer.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Active, TestData);
        }

        [TestMethod]
        public void AddressExists()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            String TestData = "Some Address";
            //assign the data to the property
            ACustomer.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Address, TestData);
        }

        [TestMethod]
        public void CustomerIDExists()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 2;
            //assign the data to the property
            ACustomer.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerID, TestData);
        }


        [TestMethod]
        public void DateOfBirthExists()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ACustomer.DateOfBirth = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.DateOfBirth, TestData);
        }

        [TestMethod]
        public void ForenameExists()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            String TestData = "Susan";
            //assign the data to the property
            ACustomer.Forename = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Forename, TestData);
        }

        [TestMethod]
        public void MobileExists()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            String TestData = "1";
            //assign the data to the property
            ACustomer.Mobile = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Mobile, TestData);
        }

        [TestMethod]
        public void PostcodeExists()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            String TestData = "BD7 2HQ";
            //assign the data to the property
            ACustomer.Postcode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Postcode, TestData);
        }

        [TestMethod]
        public void SurnameExists()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            String TestData = "Patel";
            //assign the data to the property
            ACustomer.Surname = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Surname, TestData);
        }

        [TestMethod]
        public void TownExists()
        {
            //create some test data to assign to the property
            clsCustomer ACustomer = new clsCustomer();
            // create some test data to assign to the property
            String TestData = "Bradford";
            //assign the data to the property
            ACustomer.Town = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Town, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create some test data to assign to the property
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the Customer ID
            if (ACustomer.CustomerID != 2)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestDateOfBirthFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the property
            if (ACustomer.DateOfBirth != Convert.ToDateTime("11/08/1996"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestForenameFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the property
            if (ACustomer.Forename != "Muniza")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the property
            if (ACustomer.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the property
            if (ACustomer.Address != "Field Lane")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestMobileFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the property
            if (ACustomer.Mobile != "07123456789")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPostCodeFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the property
            if (ACustomer.Postcode != "LE15SP")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSurnameFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the property
            if (ACustomer.Surname != "Malamji")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTownFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the property
            if (ACustomer.Town != "Leicester")
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
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test method for the method to pass
            string Address = "Field Lane";
            string Forename = "Muniza";
            string Postcode = "LE15SP";
            string Surname = "Malamji";
            string Town = "Leicester";
            string Mobile = "07123456789";
            string DateOfBirth = DateTime.Now.Date.ToString();
            //invoke the method 
            OK = ACustomer.Valid(Address, Forename, Postcode, Surname, Town, Mobile, DateOfBirth);
            //test to see that the results are correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void AddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test method for the method to pass
            string Address = ""; //this should trigger an error
            string Forename = "Muniza";
            string Postcode = "LE15SP";
            string Surname = "Malamji";
            string Town = "Leicester";
            string Mobile = "07123456789";
            string DateOfBirth = DateTime.Now.Date.ToString();
            //invoke the method 
            OK = ACustomer.Valid(Address, Forename, Postcode, Surname, Town, Mobile, DateOfBirth);
            //test to see that the results are correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void AddressMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test method for the method to pass
            string Address = "F"; //this should be ok
            string Forename = "Muniza";
            string Postcode = "LE15SP";
            string Surname = "Malamji";
            string Town = "Leicester";
            string Mobile = "07123456789";
            string DateOfBirth = DateTime.Now.Date.ToString();
            //invoke the method 
            OK = ACustomer.Valid(Address, Forename, Postcode, Surname, Town, Mobile, DateOfBirth);
            //test to see that the results are correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void AddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test method for the method to pass
            string Address = "Fi"; //this should be ok
            string Forename = "Muniza";
            string Postcode = "LE15SP";
            string Surname = "Malamji";
            string Town = "Leicester";
            string Mobile = "07123456789";
            string DateOfBirth = DateTime.Now.Date.ToString();
            //invoke the method 
            OK = ACustomer.Valid(Address, Forename, Postcode, Surname, Town, Mobile, DateOfBirth);
            //test to see that the results are correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void AddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test method for the method to pass
            string Address = "FieldFieldFieldFieldFieldFieldFieldFieldFieldFiel"; //this should be ok
            string Forename = "Muniza";
            string Postcode = "LE15SP";
            string Surname = "Malamji";
            string Town = "Leicester";
            string Mobile = "07123456789";
            string DateOfBirth = DateTime.Now.Date.ToString();
            //invoke the method 
            OK = ACustomer.Valid(Address, Forename, Postcode, Surname, Town, Mobile, DateOfBirth);
            //test to see that the results are correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void AddressMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test method for the method to pass
            string Address = "FieldFieldFieldFieldFieldFieldFieldFieldFieldField"; //this should be ok
            string Forename = "Muniza";
            string Postcode = "LE15SP";
            string Surname = "Malamji";
            string Town = "Leicester";
            string Mobile = "07123456789";
            string DateOfBirth = DateTime.Now.Date.ToString();
            //invoke the method 
            OK = ACustomer.Valid(Address, Forename, Postcode, Surname, Town, Mobile, DateOfBirth);
            //test to see that the results are correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void AddressMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test method for the method to pass
            string Address = "FieldFieldFieldFieldField"; //this should be ok
            string Forename = "Muniza";
            string Postcode = "LE15SP";
            string Surname = "Malamji";
            string Town = "Leicester";
            string Mobile = "07123456789";
            string DateOfBirth = DateTime.Now.Date.ToString();
            //invoke the method 
            OK = ACustomer.Valid(Address, Forename, Postcode, Surname, Town, Mobile, DateOfBirth);
            //test to see that the results are correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test method for the method to pass
            string Address = "FieldFieldFieldFieldFieldF"; //this should fail
            string Forename = "Muniza";
            string Postcode = "LE15SP";
            string Surname = "Malamji";
            string Town = "Leicester";
            string Mobile = "07123456789";
            string DateOfBirth = DateTime.Now.Date.ToString();
            //invoke the method 
            OK = ACustomer.Valid(Address, Forename, Postcode, Surname, Town, Mobile, DateOfBirth);
            //test to see that the results are correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void AddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test method for the method to pass
            string Address = "";
            Address = Address.PadRight(500, 'F');  //this should fail
            string Forename = "Muniza";
            string Postcode = "LE15SP";
            string Surname = "Malamji";
            string Town = "Leicester";
            string Mobile = "07123456789";
            string DateOfBirth = DateTime.Now.Date.ToString();
            //invoke the method 
            OK = ACustomer.Valid(Address, Forename, Postcode, Surname, Town, Mobile, DateOfBirth);
            //test to see that the results are correct
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void DateOfBirthExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test method for the method to pass
            string Address = "Field Lane";
            string Forename = "Muniza";
            string Postcode = "LE15SP";
            string Surname = "Malamji";
            string Town = "Leicester";
            string Mobile = "07123456789";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the data to todays date
            TestDate = DateTime.Now.Date;
            //Don't allow customers more than the age 200
            TestDate = TestDate.AddYears(-200);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method 
            OK = ACustomer.Valid(Address, Forename, Postcode, Surname, Town, Mobile, DateOfBirth);
            //test to see that the results are correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void DateOfBirthMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test method for the method to pass
            string Address = "Field Lane";
            string Forename = "Muniza";
            string Postcode = "LE15SP";
            string Surname = "Malamji";
            string Town = "Leicester";
            string Mobile = "07123456789";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the data to todays date
            TestDate = DateTime.Now.Date;
            //data of birth for 99 year old
            TestDate = TestDate.AddYears(-100).AddDays(-1);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method 
            OK = ACustomer.Valid(Address, Forename, Postcode, Surname, Town, Mobile, DateOfBirth);
            //test to see that the results are correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void DateOfBirthMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test method for the method to pass
            string Address = "Field Lane";
            string Forename = "Muniza";
            string Postcode = "LE15SP";
            string Surname = "Malamji";
            string Town = "Leicester";
            string Mobile = "07123456789";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the data to todays date
            TestDate = DateTime.Now.Date;
            // date of birth for 100 year old 
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method 
            OK = ACustomer.Valid(Address, Forename, Postcode, Surname, Town, Mobile, DateOfBirth);
            //test to see that the results are correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void DateOfBirthMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test method for the method to pass
            string Address = "Field Lane";
            string Forename = "Muniza";
            string Postcode = "LE15SP";
            string Surname = "Malamji";
            string Town = "Leicester";
            string Mobile = "07123456789";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the data to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddYears(-100).AddDays(1);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method 
            OK = ACustomer.Valid(Address, Forename, Postcode, Surname, Town, Mobile, DateOfBirth);
            //test to see that the results are correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void DateOfBirthMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test method for the method to pass
            string Address = "Field Lane";
            string Forename = "Muniza";
            string Postcode = "LE15SP";
            string Surname = "Malamji";
            string Town = "Leicester";
            string Mobile = "07123456789";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the data to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddYears(-16).AddDays(1);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method 
            OK = ACustomer.Valid(Address, Forename, Postcode, Surname, Town, Mobile, DateOfBirth);
            //test to see that the results are correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void DateOfBirthMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test method for the method to pass
            string Address = "Field Lane";
            string Forename = "Muniza";
            string Postcode = "LE15SP";
            string Surname = "Malamji";
            string Town = "Leicester";
            string Mobile = "07123456789";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the data to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddYears(-16);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method 
            OK = ACustomer.Valid(Address, Forename, Postcode, Surname, Town, Mobile, DateOfBirth);
            //test to see that the results are correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void DateOfBirthMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test method for the method to pass
            string Address = "Field Lane";
            string Forename = "Muniza";
            string Postcode = "LE15SP";
            string Surname = "Malamji";
            string Town = "Leicester";
            string Mobile = "07123456789";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the data to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddYears(-16).AddDays(-1);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method 
            OK = ACustomer.Valid(Address, Forename, Postcode, Surname, Town, Mobile, DateOfBirth);
            //test to see that the results are correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void DateOfBirthExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test method for the method to pass
            string Address = "Field Lane";
            string Forename = "Muniza";
            string Postcode = "LE15SP";
            string Surname = "Malamji";
            string Town = "Leicester";
            string Mobile = "07123456789";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the data to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(200);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method 
            OK = ACustomer.Valid(Address, Forename, Postcode, Surname, Town, Mobile, DateOfBirth);
            //test to see that the results are correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void DateOfBirthInvalidData()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test method for the method to pass
            string Address = "Field Lane";
            string Forename = "Muniza";
            string Postcode = "LE15SP";
            string Surname = "Malamji";
            string Town = "Leicester";
            string Mobile = "07123456789";
            //set the DateOfBirth to a non date value
            string DateOfBirth = "This is not a date!";
            //invoke the method 
            OK = ACustomer.Valid(Address, Forename, Postcode, Surname, Town, Mobile, DateOfBirth);
            //test to see that the results are correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void ForenameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test method for the method to pass
            string Address = "Field Lane";
            string Forename = "";
            string Postcode = "LE15SP";
            string Surname = "Malamji";
            string Town = "Leicester";
            string Mobile = "07123456789";
            string DateOfBirth = "11/08/1996";
            //invoke the method 
            OK = ACustomer.Valid(Address, Forename, Postcode, Surname, Town, Mobile, DateOfBirth);
            //test to see that the results are correct
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void ForenameMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test method for the method to pass
            string Address = "Field Lane";
            string Forename = "M";
            string Postcode = "LE15SP";
            string Surname = "Malamji";
            string Town = "Leicester";
            string Mobile = "07123456789";
            string DateOfBirth = Convert.ToString(DateTime.Now.Date);
            //invoke the method 
            OK = ACustomer.Valid(Address, Forename, Postcode, Surname, Town, Mobile, DateOfBirth);
            //test to see that the results are correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void ForenameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test method for the method to pass
            string Address = "Field Lane";
            string Forename = "Mu";
            string Postcode = "LE15SP";
            string Surname = "Malamji";
            string Town = "Leicester";
            string Mobile = "07123456789";
            string DateOfBirth = Convert.ToString(DateTime.Now.Date);
            //invoke the method 
            OK = ACustomer.Valid(Address, Forename, Postcode, Surname, Town, Mobile, DateOfBirth);
            //test to see that the results are correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void ForenameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test method for the method to pass
            string Address = "Field Lane";
            string Forename = "MunizaMun";
            string Postcode = "LE15SP";
            string Surname = "Malamji";
            string Town = "Leicester";
            string Mobile = "07123456789";
            string DateOfBirth = Convert.ToString(DateTime.Now.Date);
            //invoke the method 
            OK = ACustomer.Valid(Address, Forename, Postcode, Surname, Town, Mobile, DateOfBirth);
            //test to see that the results are correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void ForenameMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test method for the method to pass
            string Address = "Field Lane";
            string Forename = "MunizaMuni";
            string Postcode = "LE15SP";
            string Surname = "Malamji";
            string Town = "Leicester";
            string Mobile = "07123456789";
            string DateOfBirth = Convert.ToString(DateTime.Now.Date);
            //invoke the method 
            OK = ACustomer.Valid(Address, Forename, Postcode, Surname, Town, Mobile, DateOfBirth);
            //test to see that the results are correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void ForenameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test method for the method to pass
            string Address = "Field Lane";
            string Forename = "MunizaMuniz";
            string Postcode = "LE15SP";
            string Surname = "Malamji";
            string Town = "Leicester";
            string Mobile = "07123456789";
            string DateOfBirth = Convert.ToString(DateTime.Now.Date);
            //invoke the method 
            OK = ACustomer.Valid(Address, Forename, Postcode, Surname, Town, Mobile, DateOfBirth);
            //test to see that the results are correct
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void ForenameMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test method for the method to pass
            string Address = "Field Lane";
            string Forename = "Muniz";
            string Postcode = "LE15SP";
            string Surname = "Malamji";
            string Town = "Leicester";
            string Mobile = "07123456789";
            string DateOfBirth = Convert.ToString(DateTime.Now.Date);
            //invoke the method 
            OK = ACustomer.Valid(Address, Forename, Postcode, Surname, Town, Mobile, DateOfBirth);
            //test to see that the results are correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void PostcodeMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test method for the method to pass
            string Address = "Field Lane";
            string Forename = "Muniza";
            string Postcode = "";
            string Surname = "Malamji";
            string Town = "Leicester";
            string Mobile = "07123456789";
            string DateOfBirth = "11/08/1996";
            //invoke the method 
            OK = ACustomer.Valid(Address, Forename, Postcode, Surname, Town, Mobile, DateOfBirth);
            //test to see that the results are correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void PostcodeMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test method for the method to pass
            string Address = "Field Lane";
            string Forename = "Muniza";
            string Postcode = "L";
            string Surname = "Malamji";
            string Town = "Leicester";
            string Mobile = "07123456789";
            string DateOfBirth = Convert.ToString(DateTime.Now.Date);
            //invoke the method 
            OK = ACustomer.Valid(Address, Forename, Postcode, Surname, Town, Mobile, DateOfBirth);
            //test to see that the results are correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void PostcodeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test method for the method to pass
            string Address = "Field Lane";
            string Forename = "Muniza";
            string Postcode = "LE";
            string Surname = "Malamji";
            string Town = "Leicester";
            string Mobile = "07123456789";
            string DateOfBirth = Convert.ToString(DateTime.Now.Date);
            //invoke the method 
            OK = ACustomer.Valid(Address, Forename, Postcode, Surname, Town, Mobile, DateOfBirth);
            //test to see that the results are correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void PostcodeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test method for the method to pass
            string Address = "Field Lane";
            string Forename = "Muniza";
            string Postcode = "LE15S";
            string Surname = "Malamji";
            string Town = "Leicester";
            string Mobile = "07123456789";
            string DateOfBirth = Convert.ToString(DateTime.Now.Date);
            //invoke the method 
            OK = ACustomer.Valid(Address, Forename, Postcode, Surname, Town, Mobile, DateOfBirth);
            //test to see that the results are correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void PostcodeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test method for the method to pass
            string Address = "Field Lane";
            string Forename = "Muniza";
            string Postcode = "LE15SP";
            string Surname = "Malamji";
            string Town = "Leicester";
            string Mobile = "07123456789";
            string DateOfBirth = Convert.ToString(DateTime.Now.Date);
            //invoke the method 
            OK = ACustomer.Valid(Address, Forename, Postcode, Surname, Town, Mobile, DateOfBirth);
            //test to see that the results are correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void PostcodeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test method for the method to pass
            string Address = "Field Lane";
            string Forename = "Muniza";
            string Postcode = "LE15SPL";
            string Surname = "Malamji";
            string Town = "Leicester";
            string Mobile = "07123456789";
            string DateOfBirth = Convert.ToString(DateTime.Now.Date);
            //invoke the method 
            OK = ACustomer.Valid(Address, Forename, Postcode, Surname, Town, Mobile, DateOfBirth);
            //test to see that the results are correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void PostcodeMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test method for the method to pass
            string Address = "Field Lane";
            string Forename = "Muniza";
            string Postcode = "LE1";
            string Surname = "Malamji";
            string Town = "Leicester";
            string Mobile = "07123456789";
            string DateOfBirth = Convert.ToString(DateTime.Now.Date);
            //invoke the method 
            OK = ACustomer.Valid(Address, Forename, Postcode, Surname, Town, Mobile, DateOfBirth);
            //test to see that the results are correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void SurnameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test method for the method to pass
            string Address = "Field Lane";
            string Forename = "Muniza";
            string Postcode = "LE15SP";
            string Surname = "";
            string Town = "Leicester";
            string Mobile = "07123456789";
            string DateOfBirth = "11/08/1996";
            //invoke the method 
            OK = ACustomer.Valid(Address, Forename, Postcode, Surname, Town, Mobile, DateOfBirth);
            //test to see that the results are correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void SurnameMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test method for the method to pass
            string Address = "Field Lane";
            string Forename = "Muniza";
            string Postcode = "LE15SP";
            string Surname = "M";
            string Town = "Leicester";
            string Mobile = "07123456789";
            string DateOfBirth = Convert.ToString(DateTime.Now.Date);
            //invoke the method 
            OK = ACustomer.Valid(Address, Forename, Postcode, Surname, Town, Mobile, DateOfBirth);
            //test to see that the results are correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void SurnameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test method for the method to pass
            string Address = "Field Lane";
            string Forename = "Muniza";
            string Postcode = "LE15SP";
            string Surname = "Ma";
            string Town = "Leicester";
            string Mobile = "07123456789";
            string DateOfBirth = Convert.ToString(DateTime.Now.Date);
            //invoke the method 
            OK = ACustomer.Valid(Address, Forename, Postcode, Surname, Town, Mobile, DateOfBirth);
            //test to see that the results are correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void SurnameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test method for the method to pass
            string Address = "Field Lane";
            string Forename = "Muniza";
            string Postcode = "LE15SP";
            string Surname = "MalamjiMalamji";
            string Town = "Leicester";
            string Mobile = "07123456789";
            string DateOfBirth = Convert.ToString(DateTime.Now.Date);
            //invoke the method 
            OK = ACustomer.Valid(Address, Forename, Postcode, Surname, Town, Mobile, DateOfBirth);
            //test to see that the results are correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void SurnameMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test method for the method to pass
            string Address = "Field Lane";
            string Forename = "Muniza";
            string Postcode = "LE15SP";
            string Surname = "MalamjiMalamjiM";
            string Town = "Leicester";
            string Mobile = "07123456789";
            string DateOfBirth = Convert.ToString(DateTime.Now.Date);
            //invoke the method 
            OK = ACustomer.Valid(Address, Forename, Postcode, Surname, Town, Mobile, DateOfBirth);
            //test to see that the results are correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void SurnameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test method for the method to pass
            string Address = "Field Lane";
            string Forename = "Muniza";
            string Postcode = "LE15SP";
            string Surname = "MalamjiMalamjiMa";
            string Town = "Leicester";
            string Mobile = "07123456789";
            string DateOfBirth = Convert.ToString(DateTime.Now.Date);
            //invoke the method 
            OK = ACustomer.Valid(Address, Forename, Postcode, Surname, Town, Mobile, DateOfBirth);
            //test to see that the results are correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void SurnameMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test method for the method to pass
            string Address = "Field Lane";
            string Forename = "Muniza";
            string Postcode = "LE15SP";
            string Surname = "Malamji";
            string Town = "Leicester";
            string Mobile = "07123456789";
            string DateOfBirth = Convert.ToString(DateTime.Now.Date);
            //invoke the method 
            OK = ACustomer.Valid(Address, Forename, Postcode, Surname, Town, Mobile, DateOfBirth);
            //test to see that the results are correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TownMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test method for the method to pass
            string Address = "Field Lane";
            string Forename = "Muniza";
            string Postcode = "LE15SP";
            string Surname = "Malamji";
            string Town = "";
            string Mobile = "07123456789";
            string DateOfBirth = "11/08/1996";
            //invoke the method 
            OK = ACustomer.Valid(Address, Forename, Postcode, Surname, Town, Mobile, DateOfBirth);
            //test to see that the results are correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void TownMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test method for the method to pass
            string Address = "Field Lane";
            string Forename = "Muniza";
            string Postcode = "LE15SP";
            string Surname = "Malamji";
            string Town = "L";
            string Mobile = "07123456789";
            string DateOfBirth = Convert.ToString(DateTime.Now.Date);
            //invoke the method 
            OK = ACustomer.Valid(Address, Forename, Postcode, Surname, Town, Mobile, DateOfBirth);
            //test to see that the results are correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TownMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test method for the method to pass
            string Address = "Field Lane";
            string Forename = "Muniza";
            string Postcode = "LE15SP";
            string Surname = "Malamji";
            string Town = "Le";
            string Mobile = "07123456789";
            string DateOfBirth = Convert.ToString(DateTime.Now.Date);
            //invoke the method 
            OK = ACustomer.Valid(Address, Forename, Postcode, Surname, Town, Mobile, DateOfBirth);
            //test to see that the results are correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TownMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test method for the method to pass
            string Address = "Field Lane";
            string Forename = "Muniza";
            string Postcode = "LE15SP";
            string Surname = "Malamji";
            string Town = "LeicesterLeicesterLeicesterLeicesterLeicesterLeic";
            string Mobile = "07123456789";
            string DateOfBirth = Convert.ToString(DateTime.Now.Date);
            //invoke the method 
            OK = ACustomer.Valid(Address, Forename, Postcode, Surname, Town, Mobile, DateOfBirth);
            //test to see that the results are correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TownMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test method for the method to pass
            string Address = "Field Lane";
            string Forename = "Muniza";
            string Postcode = "LE15SP";
            string Surname = "Malamji";
            string Town = "LeicesterLeicesterLeicesterLeicesterLeicesterLeice";
            string Mobile = "07123456789";
            string DateOfBirth = Convert.ToString(DateTime.Now.Date);
            //invoke the method 
            OK = ACustomer.Valid(Address, Forename, Postcode, Surname, Town, Mobile, DateOfBirth);
            //test to see that the results are correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TownMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test method for the method to pass
            string Address = "Field Lane";
            string Forename = "Muniza";
            string Postcode = "LE15SP";
            string Surname = "Malamji";
            string Town = "LeicesterLeicesterLeicesterLeicesterLeicesterLeices";
            string Mobile = "07123456789";
            string DateOfBirth = Convert.ToString(DateTime.Now.Date);
            //invoke the method 
            OK = ACustomer.Valid(Address, Forename, Postcode, Surname, Town, Mobile, DateOfBirth);
            //test to see that the results are correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void TownMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test method for the method to pass
            string Address = "Field Lane";
            string Forename = "Muniza";
            string Postcode = "LE15SP";
            string Surname = "Malamji";
            string Town = "LeicesterLeicesterLeicest";
            string Mobile = "07123456789";
            string DateOfBirth = Convert.ToString(DateTime.Now.Date);
            //invoke the method 
            OK = ACustomer.Valid(Address, Forename, Postcode, Surname, Town, Mobile, DateOfBirth);
            //test to see that the results are correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void MobileMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test method for the method to pass
            string Address = "Field Lane";
            string Forename = "Muniza";
            string Postcode = "LE15SP";
            string Surname = "Malamji";
            string Town = "Leicester";
            string Mobile = "";
            string DateOfBirth = "11/08/1996";
            //invoke the method 
            OK = ACustomer.Valid(Address, Forename, Postcode, Surname, Town, Mobile, DateOfBirth);
            //test to see that the results are correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void MobileMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test method for the method to pass
            string Address = "Field Lane";
            string Forename = "Muniza";
            string Postcode = "LE15SP";
            string Surname = "Malamji";
            string Town = "Leicester";
            string Mobile = "0";
            string DateOfBirth = Convert.ToString(DateTime.Now.Date);
            //invoke the method 
            OK = ACustomer.Valid(Address, Forename, Postcode, Surname, Town, Mobile, DateOfBirth);
            //test to see that the results are correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void MobileMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test method for the method to pass
            string Address = "Field Lane";
            string Forename = "Muniza";
            string Postcode = "LE15SP";
            string Surname = "Malamji";
            string Town = "Leicester";
            string Mobile = "07";
            string DateOfBirth = Convert.ToString(DateTime.Now.Date);
            //invoke the method 
            OK = ACustomer.Valid(Address, Forename, Postcode, Surname, Town, Mobile, DateOfBirth);
            //test to see that the results are correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void MobileMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test method for the method to pass
            string Address = "Field Lane";
            string Forename = "Muniza";
            string Postcode = "LE15SP";
            string Surname = "Malamji";
            string Town = "Leicester";
            string Mobile = "";
            Mobile = Mobile.PadRight(49, '1');
            string DateOfBirth = Convert.ToString(DateTime.Now.Date);
            //invoke the method 
            OK = ACustomer.Valid(Address, Forename, Postcode, Surname, Town, Mobile, DateOfBirth);
            //test to see that the results are correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void MobileMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test method for the method to pass
            string Address = "Field Lane";
            string Forename = "Muniza";
            string Postcode = "LE15SP";
            string Surname = "Malamji";
            string Town = "Leicester";
            string Mobile = "";
            Mobile = Mobile.PadRight(50, '1');
            string DateOfBirth = Convert.ToString(DateTime.Now.Date);
            //invoke the method 
            OK = ACustomer.Valid(Address, Forename, Postcode, Surname, Town, Mobile, DateOfBirth);
            //test to see that the results are correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void MobileMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test method for the method to pass
            string Address = "Field Lane";
            string Forename = "Muniza";
            string Postcode = "LE15SP";
            string Surname = "Malamji";
            string Town = "Leicester";
            string Mobile = "";
            Mobile = Mobile.PadRight(51, '1');
            string DateOfBirth = Convert.ToString(DateTime.Now.Date);
            //invoke the method 
            OK = ACustomer.Valid(Address, Forename, Postcode, Surname, Town, Mobile, DateOfBirth);
            //test to see that the results are correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void MobileMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test method for the method to pass
            string Address = "Field Lane";
            string Forename = "Muniza";
            string Postcode = "LE15SP";
            string Surname = "Malamji";
            string Town = "Leicester";
            string Mobile = "";
            Mobile = Mobile.PadRight(25, '1');
            string DateOfBirth = Convert.ToString(DateTime.Now.Date);
            //invoke the method 
            OK = ACustomer.Valid(Address, Forename, Postcode, Surname, Town, Mobile, DateOfBirth);
            //test to see that the results are correct
            Assert.IsTrue(OK);
        }
    }
}
