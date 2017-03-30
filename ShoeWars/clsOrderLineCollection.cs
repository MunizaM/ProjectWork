using System;
using System.Collections.Generic;

namespace ShoeWars
{
    public class clsOrderLineCollection
    {
        //private data member for the OrderLineList
        private List<clsOrderLine> mOrderLineList = new List<clsOrderLine>();
        //public property for count
        public int Count
        {
            get
            {
                //return the count property of the private list
                return mOrderLineList.Count;
            }
            set
            {
                //we will look at this in a moment
            }
        }
        //public property for OrderLineList
        public List<clsOrderLine> OrderLineList
        {
            //getter sends the data to requesting code
           get
            {
                //return the private data member
                return mOrderLineList;
            }
            //setter accepts data from other objects
           set
            {
                //assign the incoming value to the private memebr
                mOrderLineList = value;
            }
        }

        //public constructor for the class
        public clsOrderLineCollection()
        {
            //create an instance of the dataconnection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure to get the list of data
            DB.Execute("sproc_tblOrderLine_SelectAll");
            //get the count of records
            Int32 RecordCount = DB.Count;
            //set up the index for the loop
            Int32 Index = 0;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a new instance of the OrderLine class
                clsOrderLine AnOrderLine = new clsOrderLine();
                //get the OrderID
                AnOrderLine.OrderID = DB.DataTable.Rows[Index]["OrderID"].ToString();
                //get the primary key
                AnOrderLine.OrderLineID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                //add the OrderLine to the private data member
                mOrderLineList.Add(AnOrderLine);
                //increment the index
                Index++;
            }
        }
    }
}