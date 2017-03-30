using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoeWars;

namespace FrameWork
{
    [TestClass]
    public class tstProduct
    {
        public object AnProduct { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance we want to create
            clsProduct AProduct = new clsProduct();
            Assert.IsNotNull(AProduct);
        }

        [TestMethod]
        public void ProductID()
        {
            //create an instance we want to create
            clsProduct AProduct = new clsProduct();
            Int32 TestData = 5;
            AProduct.ProductID = TestData;
            Assert.AreEqual(AProduct.ProductID, TestData);
        }
        [TestMethod]
        public void ProductColour()
        {
            //create an instance we want to create
            clsProduct AProduct = new clsProduct();
            string TestData = "Yellow";
            AProduct.ProductColour = TestData;
            Assert.AreEqual(AProduct.ProductColour, TestData);
        }
        [TestMethod]
        public void ProductName()
        {
            //create an instance we want to create
            clsProduct AProduct = new clsProduct();
            string TestData = "Adidas";
            AProduct.ProductName = TestData;
            Assert.AreEqual(AProduct.ProductName, TestData);
        }
        [TestMethod]
        public void ProductType()
        {
            //create an instance we want to create
            clsProduct AProduct = new clsProduct();
            string TestData = "Male";
            AProduct.ProductType = TestData;
            Assert.AreEqual(AProduct.ProductType, TestData);
        }
        [TestMethod]
        public void ProductSize()
        {
            //create an instance we want to create
            clsProduct AProduct = new clsProduct();
            Int32 TestData = 10;
            AProduct.ProductSize = TestData;
            Assert.AreEqual(AProduct.ProductSize, TestData);
        }
        [TestMethod]
        public void ProductPrice()
        {
            //create an instance we want to create
            clsProduct AProduct = new clsProduct();
            string TestData = "49.99";
            AProduct.ProductPrice = TestData;
            Assert.AreEqual(AProduct.ProductPrice, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsProduct AProduct = new clsProduct();
            Boolean Found = false;
            Int32 ProductID = 5;
            Found = AProduct.Find(ProductID);
            Assert.IsTrue(Found);
        }

        public void TestProductStockFound()
        {
            clsProduct AProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 5;
            Found = AProduct.Find(ProductID);
            if (AProduct.ProductID != 50)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestProductIDNoFound()
        {
            clsProduct AProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 5;
            Found = AProduct.Find(ProductID);
            if (AProduct.ProductID != 5)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestColourFound()
        {
            clsProduct AProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 5;
            Found = AProduct.Find(ProductID);
            if (AProduct.ProductColour != "Red")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestNameFound()
        {
            clsProduct AProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 5;
            Found = AProduct.Find(ProductID);
            if (AProduct.ProductName != "Adidas")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSizeFound()
        {
            clsProduct AProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 5;
            Found = AProduct.Find(ProductID);
            if (AProduct.ProductSize != 10)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestTypeFound()
        {
            clsProduct AProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 5;
            Found = AProduct.Find(ProductID);
            if (AProduct.ProductType != "Male")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPriceFound()
        {
            clsProduct AProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 5;
            Found = AProduct.Find(ProductID);
            if (AProduct.ProductPrice != "49.99")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsProduct AProduct = new clsProduct();
            Boolean OK = false;
            string ProductColour = "Red";
            string ProductName = "Adidas";
            string ProductType = "Male";
            string ProductPrice = "49.99";
            {
                OK = AProduct.Valid(ProductName, ProductColour, ProductType, ProductPrice);
            }
            Assert.IsTrue(OK);
        }
        //**********************************************************************************************************************************************
        [TestMethod]
        public void ProductNameMinLessOne()
        {
            //create an instance of the class we want to create 
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to passto the method
            string ProductColour = "Red";
            string ProductName = "";
            string ProductType = "Male";
            string ProductPrice = "49.99";
            //invoke the method
            OK = AProduct.Valid(ProductName, ProductColour, ProductType, ProductPrice);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void ProductNameMin()
        {
            //create an instance of the class we want to create 
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to passto the method
            string ProductColour = "Red";
            string ProductName = "A";
            string ProductType = "Male";
            string ProductPrice = "49.99";
            //invoke the method
            OK = AProduct.Valid(ProductName, ProductColour, ProductType, ProductPrice);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductNamePlusOne()
        {
            //create an instance of the class we want to create 
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to passto the method
            string ProductColour = "Red";
            string ProductName = "AA";
            string ProductType = "Male";
            string ProductPrice = "49.99";
            //invoke the method
            OK = AProduct.Valid(ProductName, ProductColour, ProductType, ProductPrice);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductNameMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to passto the method
            string ProductColour = "Red";
            string ProductName = "AAAAAAAAA";
            string ProductType = "Male";
            string ProductPrice = "49.99";
            //invoke the method
            OK = AProduct.Valid(ProductName, ProductColour, ProductType, ProductPrice);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ProductNameMax()
        {
            //create an instance of the class we want to create 
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to passto the method
            string ProductColour = "Red";
            string ProductName = "AAAAAAAAAA";
            string ProductType = "Male";
            string ProductPrice = "49.99";
            //invoke the method
            OK = AProduct.Valid(ProductName, ProductColour, ProductType, ProductPrice);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ProductNameMid()
        {
            //create an instance of the class we want to create 
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to passto the method
            string ProductColour = "Red";
            string ProductName = "AAAAA";
            string ProductType = "Male";
            string ProductPrice = "49.99";
            //invoke the method
            OK = AProduct.Valid(ProductName, ProductColour, ProductType, ProductPrice);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ProductNameMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to passto the method
            string ProductColour = "Red";
            string ProductName = "AAAAAAAAAAA"; // this should fail
            string ProductType = "Male";
            string ProductPrice = "49.99";
            //invoke the method
            OK = AProduct.Valid(ProductName, ProductColour, ProductType, ProductPrice);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void ProductNameExtremeMax()
        {
            //create an instance of the class we want to create 
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to passto the method
            string ProductColour = "Red";
            string ProductName = "";
            ProductName = ProductName.PadRight(500, 'A'); // this should fail
            string ProductType = "Male";
            string ProductPrice = "49.99";
            //invoke the method
            OK = AProduct.Valid(ProductName, ProductColour, ProductType, ProductPrice);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        //**************************************************************************************************
        [TestMethod]
        public void ProductColourMinLessOne()
        {
            //create an instance of the class we want to create 
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to passto the method
            string ProductColour = "";
            string ProductName = "Adidas";
            string ProductType = "Male";
            string ProductPrice = "49.99";
            //invoke the method
            OK = AProduct.Valid(ProductName, ProductColour, ProductType, ProductPrice);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void ProductColourMin()
        {
            //create an instance of the class we want to create 
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to passto the method
            string ProductColour = "R";
            string ProductName = "Adidas";
            string ProductType = "Male";
            string ProductPrice = "49.99";
            //invoke the method
            OK = AProduct.Valid(ProductName, ProductColour, ProductType, ProductPrice);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ProductColourMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to passto the method
            string ProductColour = "RR";
            string ProductName = "Adidas";
            string ProductType = "Male";
            string ProductPrice = "49.99";
            //invoke the method
            OK = AProduct.Valid(ProductName, ProductColour, ProductType, ProductPrice);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ProductColourMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to passto the method
            string ProductColour = "RRRRRRRRR";
            string ProductName = "Adidas";
            string ProductType = "Male";
            string ProductPrice = "49.99";
            //invoke the method
            OK = AProduct.Valid(ProductName, ProductColour, ProductType, ProductPrice);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ProductColourMax()
        {
            //create an instance of the class we want to create 
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to passto the method
            string ProductColour = "RRRRRRRRRR";
            string ProductName = "Adidas";
            string ProductType = "Male";
            string ProductPrice = "49.99";
            //invoke the method
            OK = AProduct.Valid(ProductName, ProductColour, ProductType, ProductPrice);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ProductColourMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to passto the method
            string ProductColour = "RRRRRRRRRRR";
            string ProductName = "Adidas"; // this should fail
            string ProductType = "Male";
            string ProductPrice = "49.99";
            //invoke the method
            OK = AProduct.Valid(ProductName, ProductColour, ProductType, ProductPrice);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void ProductColourMid()
        {
            //create an instance of the class we want to create 
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to passto the method
            string ProductColour = "RRRRRR";
            string ProductName = "Adidas";
            string ProductType = "Male";
            string ProductPrice = "49.99";
            //invoke the method
            OK = AProduct.Valid(ProductName, ProductColour, ProductType, ProductPrice);
            //test to see that the result is correct
            Assert.IsTrue(OK);
            //*****************************************************************************************************************************************************
        }
        [TestMethod]
        public void ProductTypeMinLessOne()
        {
            //create an instance of the class we want to create 
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to passto the method
            string ProductColour = "Red";
            string ProductName = "Adidas";
            string ProductType = "";
            string ProductPrice = "49.99";
            //invoke the method
            OK = AProduct.Valid(ProductName, ProductColour, ProductType, ProductPrice);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void ProductTypeMin()
        {
            //create an instance of the class we want to create 
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to passto the method
            string ProductColour = "Red";
            string ProductName = "Adias";
            string ProductType = "M";
            string ProductPrice = "49.99";
            //invoke the method
            OK = AProduct.Valid(ProductName, ProductColour, ProductType, ProductPrice);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ProductTypePlusOne()
        {
            //create an instance of the class we want to create 
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to passto the method
            string ProductColour = "Red";
            string ProductName = "Addias";
            string ProductType = "MM";
            string ProductPrice = "49.99";
            //invoke the method
            OK = AProduct.Valid(ProductName, ProductColour, ProductType, ProductPrice);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ProductTypeMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to passto the method
            string ProductColour = "Red";
            string ProductName = "Adidas";
            string ProductType = "MMMMMMMMM";
            string ProductPrice = "49.99";
            //invoke the method
            OK = AProduct.Valid(ProductName, ProductColour, ProductType, ProductPrice);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ProductTypeMax()
        {
            //create an instance of the class we want to create 
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to passto the method
            string ProductColour = "Red";
            string ProductName = "Adidas";
            string ProductType = "MMMMMMMMMM";
            string ProductPrice = "49.99";
            //invoke the method
            OK = AProduct.Valid(ProductName, ProductColour, ProductType, ProductPrice);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ProductTypeMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to passto the method
            string ProductColour = "Red";
            string ProductName = "Adidas"; // this should fail
            string ProductType = "MMMMMMMMMMM";
            string ProductPrice = "49.99";
            //invoke the method
            OK = AProduct.Valid(ProductName, ProductColour, ProductType, ProductPrice);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void ProductTypeMid()
        {
            //create an instance of the class we want to create 
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to passto the method
            string ProductColour = "Red";
            string ProductName = "Adidas";
            string ProductType = "MMMMM";
            string ProductPrice = "49.99";
            //invoke the method
            OK = AProduct.Valid(ProductName, ProductColour, ProductType, ProductPrice);
            //test to see that the result is correct
            Assert.IsTrue(OK);
            //********************************************************************************************************************************
        }
        [TestMethod]
        public void ProductPriceMinLessOne()
        {
            //create an instance of the class we want to create 
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to passto the method
            string ProductColour = "Red";
            string ProductName = "Adidas";
            string ProductType = "Male";
            string ProductPrice = "";
            //invoke the method
            OK = AProduct.Valid(ProductName, ProductColour, ProductType, ProductPrice);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void ProductPriceMin()
        {
            //create an instance of the class we want to create 
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to passto the method
            string ProductColour = "Red";
            string ProductName = "Adidas";
            string ProductType = "Male";
            string ProductPrice = "4";
            //invoke the method
            OK = AProduct.Valid(ProductName, ProductColour, ProductType, ProductPrice);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ProductPricePlusOne()
        {
            //create an instance of the class we want to create 
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to passto the method
            string ProductColour = "Red";
            string ProductName = "Adidas";
            string ProductType = "Male";
            string ProductPrice = "44";
            //invoke the method
            OK = AProduct.Valid(ProductName, ProductColour, ProductType, ProductPrice);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ProductPriceMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to passto the method
            string ProductColour = "Red";
            string ProductName = "Adidas";
            string ProductType = "Male";
            string ProductPrice = "";
            ProductPrice = ProductPrice.PadRight(99, '4');
            //invoke the method
            OK = AProduct.Valid(ProductName, ProductColour, ProductType, ProductPrice);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ProductPriceMax()
        {
            //create an instance of the class we want to create 
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to passto the method
            string ProductColour = "Red";
            string ProductName = "Adidas";
            string ProductType = "Male";
            string ProductPrice = "";
            ProductPrice = ProductPrice.PadRight(100, '4');
            //invoke the method
            OK = AProduct.Valid(ProductName, ProductColour, ProductType, ProductPrice);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ProductPriceMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to passto the method
            string ProductColour = "Red";
            string ProductName = "Adidas";
            string ProductType = "Male";
            string ProductPrice = "";
            ProductPrice = ProductPrice.PadRight(101, '4');
            //invoke the method
            OK = AProduct.Valid(ProductName, ProductColour, ProductType, ProductPrice);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void ProductPriceMid()
        {
            //create an instance of the class we want to create 
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to passto the method
            string ProductColour = "Red";
            string ProductName = "Adidas";
            string ProductType = "Male";
            string ProductPrice = "";
            ProductPrice = ProductPrice.PadRight(50, '4');
            //invoke the method
            OK = AProduct.Valid(ProductName, ProductColour, ProductType, ProductPrice);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}



