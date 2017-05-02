using System;
using System.Collections.Generic;

namespace ShoeWars
{
    public class clsPaymentCollection
    {
        //constructor for the class
        public clsPaymentCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblPayments_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create blank payment
                clsPayment AnPayment = new clsPayment();
                //read in the fields from the current record
                AnPayment.CardDetails = Convert.ToString(DB.DataTable.Rows[Index]["CardDetails"]);
                AnPayment.CardType = Convert.ToString(DB.DataTable.Rows[Index]["CardType"]);
                AnPayment.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnPayment.DatePurchased = Convert.ToDateTime(DB.DataTable.Rows[Index]["DatePurchased"]);
                AnPayment.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnPayment.PaymentID = Convert.ToInt32(DB.DataTable.Rows[Index]["PaymentID"]);
                AnPayment.Total = Convert.ToInt32(DB.DataTable.Rows[Index]["Total"]);
                mPaymentList.Add(AnPayment);
                //point at the next record
                Index++;
            }
        }

        //private data member for the lists
        List<clsPayment> mPaymentList = new List<clsPayment>();
        //private data member thispayment
        clsPayment mThisPayment = new clsPayment();

        //public property for the address list
        public List<clsPayment> PaymentList
        {
            get
            {
                //return the private data
                return mPaymentList;
            }
            set
            {
                //set the private data 
                mPaymentList = value;
            }
         }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mPaymentList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        //public property for ThisPayment
        public clsPayment ThisPayment
        {
            get
            {
                //return the private data
                return mThisPayment;
            }
            set
            {
                //set the private data 
                mThisPayment = value;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the value of ThisPayment
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedures
            DB.AddParameter("@CardDetails", mThisPayment.CardDetails);
            DB.AddParameter("@CardType", mThisPayment.CardType);
            DB.AddParameter("@CustomerID", mThisPayment.CustomerID);
            DB.AddParameter("@DatePurchased", mThisPayment.DatePurchased);
            DB.AddParameter("@OrderID", mThisPayment.OrderID);
            DB.AddParameter("@PaymentID", mThisPayment.PaymentID);
            DB.AddParameter("@Total", mThisPayment.Total);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblPayments_Insert");
        }
    }
}