using System;

namespace ShoeWars
{
    public class clsPayment
    {
        //private data memeber for the OrderID property
        private Int32 mOrderID;
        private String mCardDetails;
        private String mCardType;
        private Int32 mPaymentID;
        private Int32 mCustomerID;
        private Int32 mTotal;
        private DateTime mDatePurchased;
        

        //public property for the CardDetails
        public String CardDetails 
        {
            get
            {
                //return the private data
                return mCardDetails;
            }
            set
            {
                //set the value of the private data memeber
                mCardDetails = value;
            }
        }

        //public property for the CardType
        public string CardType
        {
            get
            {
                //return the private data
                return mCardType;
            }
            set
            {
                //set the value of the private data memeber
                mCardType = value;
            }
        }

        //public property for the CustomerID
        public int CustomerID
        {
            get
            {
                //return the private data
                return mCustomerID;
            }
            set
            {
                //set the value of the private data memeber
                mCustomerID = value;
            }
        }

        //public property for the DatePurchased
        public DateTime DatePurchased
        {
            get
            {
                //return the private data
                return mDatePurchased;
            }
            set
            {
                //set the value of the private data memeber
                mDatePurchased = value;
            }
        }
        
        //public property for the OrderID
        public int OrderID
        {
            get
            {
                //return the private data
                return mOrderID;
            }
            set
            {
                //set the value of the private data memeber
                mOrderID = value;
            }
        }

        //public property for the PaymentID
        public int PaymentID
        {
            get
            {
                //return the private data
                return mPaymentID;
            }
            set
            {
                //set the value of the private data memeber
                mPaymentID = value;
            }
        }

        public string SomeCardType { get; private set; }

        //public property for the Total
        public int Total
        {
            get
            {
                //return the private data
                return mTotal;
            }
            set
            {
                //set the value of the private data memeber
                mTotal = value;
            }
        }

        public int PaymentNo { get; set; }

        public bool Find(int PaymentID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the PaymentID to search for
            DB.AddParameter("@PaymentID", PaymentID);
            //execute the stored procedure
            DB.Execute("sproc_tblPayments_FilterByPaymentID");
            //if one record is found (their should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mPaymentID = Convert.ToInt32(DB.DataTable.Rows[0]["PaymentID"]);
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mCardDetails = Convert.ToString(DB.DataTable.Rows[0]["CardDetails"]);
                mCardType = Convert.ToString(DB.DataTable.Rows[0]["CardType"]);
                mDatePurchased = Convert.ToDateTime(DB.DataTable.Rows[0]["DatePurchased"]);
                mTotal = Convert.ToInt32(DB.DataTable.Rows[0]["Total"]);
                //return that everything worked ok
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }                        
        }

               
        public bool Valid(clsPayment aPayment)
        {
            //if the name of the Card type is blank
            if (SomeCardType != "")
            {
            //return true
            return true;
            }
            //otherwise return false
            else
            {
             //return false
            return false;
            }
        }

        public bool Valid(string CardDetails, string CardType, string DatePurchased)
        {
            //create a Boolean variable to flag the rror
            Boolean OK = true;
            //create a temporary variable to store date values
            DateTime DateTemp;
            //if the Card Details is blank
            if (CardDetails.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the card details has greater than 16
            if (CardDetails.Length > 16)
            {
                //set the flag OK to false
                OK = false;
            }
            //try the date validation assuming the data is a valid date
            try
            {
                //copy the DateAdded value to the DateTemp varibale
                DateTemp = Convert.ToDateTime(DatePurchased);
                //check to see if the date is less than todays date
                if (DateTemp < DateTime.Now.Date)
                {
                    //set the flag OK to false
                    OK = false;
                }
                //check to see if the date is greater than todays date
                if (DateTemp > DateTime.Now.Date)
                {
                    //set the flag OK to false
                    OK = false;
                }
            }
            //the data was not a date so flag an error
            catch
            {
                //set the flag OK to false
                OK = false;
            }
            //is the card type blank
            if (CardType.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the card type is too long
            if (CardType.Length > 10)
            {
                //set the flag OK to false
                OK = false;
            }
            //return the value of OK
            return OK;
        }
    }
}
