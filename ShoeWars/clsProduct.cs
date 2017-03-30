using System;

namespace ShoeWars
{
    public class clsProduct
    {
        private Int32 mProductID;
        private string mProductColour;
        private string mProductName;
        private Int32 mProductSize;
        private string mProductType;
        private string mProductPrice;
        public bool Active { get; set; }

        public string ProductColour
        {
            get
            {
                return mProductColour;
            }
            set
            {
                mProductColour = value;
            }
        }
        public int ProductID
        {
            get
            {
                return mProductID;
            }
            set
            {
                mProductID = value;
            }
        }
        public string ProductName
        {
            get
            {
                return mProductName;
            }
            set
            {
                mProductName = value;
            }
        }
        public string ProductPrice
        {
            get
            {
                return mProductPrice;
            }
            set
            {
                mProductPrice = value;
            }
        }
        public Int32 ProductSize
        {
            get
            {
                return mProductSize;
            }
            set
            {
                mProductSize = value;
            }
        }
        public string ProductType
        {
            get
            {
                return mProductType;
            }
            set
            {
                mProductType = value;
            }
        }

        public bool Find(int ProductID)
        {
            {
                //create an instance of the dtaa connection
                clsDataConnection DB = new clsDataConnection();
                //add the paramter
                DB.AddParameter("@ProductID", ProductID);
                //execute 
                DB.Execute("sproc_tblProducts_FilterByProductID");
                //if on record is found  (there be either one or zero)
                if (DB.Count == 1)
                {
                    //copy the data from the database to the private data members
                    mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                    mProductColour = Convert.ToString(DB.DataTable.Rows[0]["ProductColour"]);
                    mProductName = Convert.ToString(DB.DataTable.Rows[0]["ProductName"]);
                    mProductSize = Convert.ToInt32(DB.DataTable.Rows[0]["ProductSize"]);
                    mProductType = Convert.ToString(DB.DataTable.Rows[0]["ProductType"]);
                    mProductPrice = Convert.ToString(DB.DataTable.Rows[0]["ProductPrice"]);
                    //return that everything is ok
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool Valid(string ProductName, string ProductColour, string ProductType, string ProductPrice)
        {
            Boolean OK = true;
            //if the productName is blank
            if (ProductName.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the ProductName is greater than 10
            if (ProductName.Length > 10)
            {
                OK = false;
            }

            //*******************************************************

            if (ProductColour.Length == 0)
            {
                //set the flad OK to false
                OK = false;
            }
            //if the ProductName is greater than 10
            if (ProductColour.Length > 10)
            {
                OK = false;
            }
            //*************************************************

            if (ProductType.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the ProductName is greater than 10
            if (ProductType.Length > 10)
            {
                OK = false;
            }
            //*************************************************
            if (ProductPrice.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the ProductName is greater than 10
            if (ProductPrice.Length > 100)
            {
                OK = false;
            }
            //return Value of OK
            return OK;
        }
    }
}

















