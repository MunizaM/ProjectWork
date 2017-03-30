using System;
using System.Collections.Generic;

namespace ShoeWars
{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();


        //constructor for the class
        public clsCustomerCollection()
        {
            //Create the items of the test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerID = 1;
            TestItem.Forename = "Susan";
            TestItem.Surname = "Hill";
            TestItem.Address = "High Place";
            TestItem.Town = "Bradford";
            TestItem.Postcode = "BD72HQ";
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.Mobile = "07323232323";
            TestItem.Active = true;
            //add the item to the test list 
            mCustomerList.Add(TestItem);
            //re initialise the object for some new data
            TestItem = new clsCustomer();
            //set its properties
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
            mCustomerList.Add(TestItem);
            

        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mCustomerList.Count;
            }
            set
            {
                //later...
            }
        }

        // public property for the customer list
        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }
        
        public clsCustomer ThisCustomer { get; set; }
    }
}