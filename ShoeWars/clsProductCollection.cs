using System.Collections.Generic;

namespace ShoeWars
{
    public class clsProductCollection

    {
        //private data memeber for the list
        List<clsProduct> mProductList = new List<clsProduct>();

        public int Count
        {
            get
            {
                //return the count of the list
                return mProductList.Count;
            }
            set
            {
                //we shall worry later about this
            }
        }
        public List<clsProduct> ProductList
        {
            get
            {
                //return the priate data
                return mProductList;
            }
            set
            {
                //set the private data
                mProductList = value;
            }
        }
        public clsProduct ThisProduct { get; set; }

    
        public void clsProductsCollection()
        {
            //creat an instance of the test data
            clsProduct TestItem = new clsProduct();
            //set the properties
            TestItem.ProductID = 1;
            TestItem.ProductColour = "Red";
            TestItem.ProductName = "Addidas";
            TestItem.ProductType = "Male";
            TestItem.ProductPrice = "49.99";
            TestItem.ProductSize = 10;
            //add initialise to the test line
            mProductList.Add(TestItem);

            TestItem.ProductID = 5;
            TestItem.ProductColour = "Red";
            TestItem.ProductName = "Addidas";
            TestItem.ProductType = "Male";
            TestItem.ProductPrice = "49.99";
            TestItem.ProductSize = 10;
            mProductList.Add(TestItem);
        }
    }
}

  

   
  


