using System;

namespace ShoeWars
{
    public class clsCustomer
    {
        //private data member for the AddressNo property
        private Int32 mCustomerID;
        //private data for Address
        private string mAddress;
        //private data of member date of birth
        private DateTime mDateOfBirth;
        //private data member for active
        private Boolean mActive;
        //private data member for Forename
        private string mForename;
        //private data member for Mobile
        private String mMobile;
        //private data member for PostCode
        private string mPostcode;
        //private data member for Surname
        private string mSurname;
        //private data member for Town
        private string mTown;
        public bool Active
        {
            get
            {
                //return the private data
                return mActive;
            }
            set
            {
                //set the private data
                mActive = value;
            }
        }
        public string Address
        {
            get
            {
                //return the private data
                return mAddress;
            }
            set
            {
                //set the private data
                mAddress = value;
            }
        }
        public int CustomerID
        {
            get
            {
                //return the private data 
                return mCustomerID;
            }
            set
            {
                //set the value of the private data member
                mCustomerID = value;
            }
        }
        public DateTime DateOfBirth
        {
            get
            {
                //return the private data
                return mDateOfBirth;
            }
            set
            {
                //set the private data
                mDateOfBirth = value;
            }
        }
        public string Forename
        {
            get
            {
                //return the private data
                return mForename;
            }
            set
            {
                //set the private data 
                mForename = value;
            }
        }
        public String Mobile
        {
            get
            {
                //return the private data
                return mMobile;
            }
            set
            { //set the private data
                mMobile = value;
            }
        }
        public string Postcode
        {
            get
            {
                //return the private data
                return mPostcode;
            }
            set
            {
                //set the private data
                mPostcode = value;
            }
        }
        public string Surname
        {
            get
            {
                //return the private data
                return mSurname;
            }
            set
            {
                //set the private data
                mSurname = value;
            }
        }
        public string Town
        {
            get
            {
                //return the private data
                return mTown;
            }
            set
            {
                //set the private data
                mTown = value;
            }
        }

        public bool Find(int customerID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the CustomerID to search for
            DB.AddParameter("@CustomerID", customerID);
            //execute the stored procedure
            DB.Execute("sproc_tbl_Customers_FilterByCustomerID");
            //          sproc_tbl_Customers_FilterByCustomerID
            //if one record is found there should be either one or zero
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mForename = Convert.ToString(DB.DataTable.Rows[0]["Forename"]);
                mSurname = Convert.ToString(DB.DataTable.Rows[0]["Surname"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mTown = Convert.ToString(DB.DataTable.Rows[0]["Town"]);
                mPostcode = Convert.ToString(DB.DataTable.Rows[0]["Postcode"]);
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                mMobile = Convert.ToString(DB.DataTable.Rows[0]["Mobile"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                //return that everthing worked OK
                return true;
            }
            //if no record was found 
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public bool Valid(string Address, string Forename, string Postcode, string Surname, string Town, string Mobile, string DateOfBirth)
        {
            //create a Boolean variable to flag the error
            Boolean OK = true;
            //create a temporary variable to store date values
            DateTime DateTemp;
            //if the Address is blank
            if (Address.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the Address is greater than 50 characters
            if (Address.Length > 50)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the Forename is blank
            if (Forename.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the Forename is greater than 10 characters
            if (Forename.Length > 10)
            {
                //set the flag OK to false
                OK = false; 
            }
            //if the Postcode is blank
            if (Postcode.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the Postcode is greater than 6 characters
            if (Postcode.Length > 6)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the Surname is blank 
            if (Surname.Length ==0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the Surname is greater than 15 characters
            if (Surname.Length > 15)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the Town is blank 
            if (Town.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the Town is greater than 50 characters
            if (Town.Length > 50)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the Mobile is blank 
            if (Mobile.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the Mobile is greater than 50 characters
            if (Mobile.Length > 50)
            {
                //set the flag OK to false
                OK = false;
            }
            //try the date validation assuming the data is a valid date 
            try
            {
                //copy the DateOfBirth value to the DateTemp variable
                DateTemp = Convert.ToDateTime(DateOfBirth);
                //check to see if the date is less than today's date
                if (DateTemp < DateTime.Now.Date)
                {
                    //set the flag OK to false
                    OK = false;
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //set the flag OK to false
                    OK = false;
                }
            }
            //the data was not a date so flag an error
            catch
            {
                //set the flag Ok to false
                OK = false; 
            }
                //return the value of OK
                return OK;
            }
    }
}

  