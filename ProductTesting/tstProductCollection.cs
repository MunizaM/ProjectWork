using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoeWars;
using System.Collections.Generic;

namespace ShoeWars
{
    [TestClass]
    public class tstProductCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProduct = new clsProductCollection();
            //test to see that it exists
            Assert.IsNotNull(AllProduct);
        }
        [TestMethod]
        public void ProductListOK()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProduct = new clsProductCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsProduct> TestList = new List<clsProduct>();
            //add an item of test data
            //create the item of test data
            clsProduct TestItem = new clsProduct();
            //set its properties
            TestItem.ProductID = 5;
            TestItem.ProductColour = "Red";
            TestItem.ProductName = "Addidas";
            TestItem.ProductType = "Male";
            TestItem.ProductPrice = "49.99";
            TestItem.ProductSize = 10;
            //add the item to the test data
            TestList.Add(TestItem);
            //assign the data to the propery
            AllProduct.ProductList = TestList;
            //test to see that it exists
            Assert.AreEqual(AllProduct.ProductList, TestList);
        }
        [TestMethod]
        public void CountProperty()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProduct = new clsProductCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 0;
            //assign the data to the property
            AllProduct.Count = SomeCount;
            //test to see that two values are the same
            Assert.AreEqual(AllProduct.Count, SomeCount);
        }
        [TestMethod]
        public void ThisProductPropertyOK()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProduct = new clsProductCollection();
            //create some test data to assign to the property
            clsProduct TestProduct = new clsProduct();
            //set its properties
            TestProduct.ProductID = 5;
            TestProduct.ProductColour = "Red";
            TestProduct.ProductName = "Addidas";
            TestProduct.ProductType = "Male";
            TestProduct.ProductPrice = "49.99";
            TestProduct.ProductSize = 10;
            //assign the data to the propery
            AllProduct.ThisProduct = TestProduct;
            //test to see that it exists
            Assert.AreEqual(AllProduct.ThisProduct, TestProduct);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProduct = new clsProductCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsProduct> TestList = new List<clsProduct>();
            //add an item of test data
            //create the item of test data
            clsProduct TestItem = new clsProduct();
            //set its properties
            TestItem.ProductID = 5;
            TestItem.ProductColour = "Red";
            TestItem.ProductName = "Addidas";
            TestItem.ProductType = "Male";
            TestItem.ProductPrice = "49.99";
            TestItem.ProductSize = 10;
            //here
            //add the item to the test data
            TestList.Add(TestItem);
            //assign the data to the propery
            AllProduct.ProductList = TestList;
            //test to see that it exists
            Assert.AreEqual(AllProduct.Count, TestList.Count);
        }
        [TestMethod]
        public void TwoRecordPresent()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProduct = new clsProductCollection();
            //test to see that the two values are the same
            Assert.AreEqual(AllProduct.Count, 0);
        }
    }
}



        

     