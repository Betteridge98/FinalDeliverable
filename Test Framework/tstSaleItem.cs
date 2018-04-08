using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Test_Framework
{
    [TestClass]
    public class tstSaleItem
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsSaleItem ASaleItem = new clsSaleItem();
            //test to see that it exists
            Assert.IsNotNull(ASaleItem);
        }

        [TestMethod]
        public void ItemIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsSaleItem ASaleItem = new clsSaleItem();
            //create some test data to assign to the property
            int SomeItemID = 1;
            //assign the data to the property
            ASaleItem.ItemID = SomeItemID;
            //test to see that the two values are the same
            Assert.AreEqual(ASaleItem.ItemID, SomeItemID);
        }

        [TestMethod]
        public void ItemPricePropertyOK()
        {
            //create an instance of the class we want to create
            clsSaleItem ASaleItem = new clsSaleItem();
            //create some test data to assign to the property
            decimal SomeItemPrice = 1.99m;
            //assign the data to the property
            ASaleItem.ItemPrice = SomeItemPrice;
            //test to see that the two values are the same
            Assert.AreEqual(ASaleItem.ItemPrice, SomeItemPrice);
        }

        [TestMethod]
        public void QuantityPropertyOK()
        {
            //create an instance of the class we want to create
            clsSaleItem ASaleItem = new clsSaleItem();
            //create some test data to assign to the property
            int SomeQuantity = 2;
            //assign the data to the property
            ASaleItem.Quantity = SomeQuantity;
            //test to see that the two values are the same
            Assert.AreEqual(ASaleItem.Quantity, SomeQuantity);
        }

        [TestMethod]
        public void SaleIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsSaleItem ASaleItem = new clsSaleItem();
            //create some test data to assign to the property
            int SomeSaleID = 1;
            //assign the data to the property
            ASaleItem.SaleID = SomeSaleID;
            //test to see that the two values are the same
            Assert.AreEqual(ASaleItem.SaleID, SomeSaleID);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            clsSaleItem ASaleItem = new clsSaleItem();
            //create some test data to assign to the property
            DateTime SomeDateAdded = Convert.ToDateTime("05/04/2018");
            //assign the data to the property
            ASaleItem.DateAdded = SomeDateAdded;
            //test
            //test to see that the two values are the same
            Assert.AreEqual(ASaleItem.DateAdded, SomeDateAdded);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsSaleItem ASaleItem = new clsSaleItem();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            int ItemID = 1;
            decimal ItemPrice = 1.99m;
            int Quantity = 2;
            int SaleID = 1;
            DateTime DateAdded = DateTime.Now.Date;
            //invoke the method
            Error = ASaleItem.Valid(ItemID, ItemPrice, Quantity, SaleID, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemIDExtremeMin()
        {
            //create an instance of the class we want to create
            clsSaleItem ASaleItem = new clsSaleItem();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            int ItemID = -4875478;
            decimal ItemPrice = 1.99m;
            int Quantity = 2;
            int SaleID = 1;
            DateTime DateAdded = DateTime.Now.Date;
            //invoke the method
            Error = ASaleItem.Valid(ItemID, ItemPrice, Quantity, SaleID, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemIDMinMinusOne()
        {
            //create an instance of the class we want to create
            clsSaleItem ASaleItem = new clsSaleItem();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            int ItemID = 0;
            decimal ItemPrice = 1.99m;
            int Quantity = 2;
            int SaleID = 1;
            DateTime DateAdded = DateTime.Now.Date;
            //invoke the method
            Error = ASaleItem.Valid(ItemID, ItemPrice, Quantity, SaleID, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemIDMin()
        {
            //create an instance of the class we want to create
            clsSaleItem ASaleItem = new clsSaleItem();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            int ItemID = 1;
            decimal ItemPrice = 1.99m;
            int Quantity = 2;
            int SaleID = 1;
            DateTime DateAdded = DateTime.Now.Date;
            //invoke the method
            Error = ASaleItem.Valid(ItemID, ItemPrice, Quantity, SaleID, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemIDMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSaleItem ASaleItem = new clsSaleItem();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            int ItemID = 2;
            decimal ItemPrice = 1.99m;
            int Quantity = 2;
            int SaleID = 1;
            DateTime DateAdded = DateTime.Now.Date;
            //invoke the method
            Error = ASaleItem.Valid(ItemID, ItemPrice, Quantity, SaleID, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemIDMid()
        {
            //create an instance of the class we want to create
            clsSaleItem ASaleItem = new clsSaleItem();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            int ItemID = 500000001;
            decimal ItemPrice = 1.99m;
            int Quantity = 2;
            int SaleID = 1;
            DateTime DateAdded = DateTime.Now.Date;
            //invoke the method
            Error = ASaleItem.Valid(ItemID, ItemPrice, Quantity, SaleID, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemIDMaxMinusOne()
        {
            //create an instance of the class we want to create
            clsSaleItem ASaleItem = new clsSaleItem();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            int ItemID = 999999999;
            decimal ItemPrice = 1.99m;
            int Quantity = 2;
            int SaleID = 1;
            DateTime DateAdded = DateTime.Now.Date;
            //invoke the method
            Error = ASaleItem.Valid(ItemID, ItemPrice, Quantity, SaleID, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemIDMax()
        {
            //create an instance of the class we want to create
            clsSaleItem ASaleItem = new clsSaleItem();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            int ItemID = 1000000000;
            decimal ItemPrice = 1.99m;
            int Quantity = 2;
            int SaleID = 1;
            DateTime DateAdded = DateTime.Now.Date;
            //invoke the method
            Error = ASaleItem.Valid(ItemID, ItemPrice, Quantity, SaleID, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemIDMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsSaleItem ASaleItem = new clsSaleItem();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            int ItemID = 1000000001;
            decimal ItemPrice = 1.99m;
            int Quantity = 2;
            int SaleID = 1;
            DateTime DateAdded = DateTime.Now.Date;
            //invoke the method
            Error = ASaleItem.Valid(ItemID, ItemPrice, Quantity, SaleID, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemIDExtremeMax()
        {
            //create an instance of the class we want to create
            clsSaleItem ASaleItem = new clsSaleItem();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            int ItemID = 2147483647;
            decimal ItemPrice = 1.99m;
            int Quantity = 2;
            int SaleID = 1;
            DateTime DateAdded = DateTime.Now.Date;
            //invoke the method
            Error = ASaleItem.Valid(ItemID, ItemPrice, Quantity, SaleID, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemPriceExtremeMin()
        {
            //create an instance of the class we want to create
            clsSaleItem ASaleItem = new clsSaleItem();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            int ItemID = 1;
            decimal ItemPrice = -28573625.65m;
            int Quantity = 2;
            int SaleID = 1;
            DateTime DateAdded = DateTime.Now.Date;
            //invoke the method
            Error = ASaleItem.Valid(ItemID, ItemPrice, Quantity, SaleID, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemPriceMinMinusOne()
        {
            //create an instance of the class we want to create
            clsSaleItem ASaleItem = new clsSaleItem();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            int ItemID = 1;
            decimal ItemPrice = -1.00m;
            int Quantity = 2;
            int SaleID = 1;
            DateTime DateAdded = DateTime.Now.Date;
            //invoke the method
            Error = ASaleItem.Valid(ItemID, ItemPrice, Quantity, SaleID, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemPriceMin()
        {
            //create an instance of the class we want to create
            clsSaleItem ASaleItem = new clsSaleItem();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            int ItemID = 1;
            decimal ItemPrice = 0;
            int Quantity = 2;
            int SaleID = 1;
            DateTime DateAdded = DateTime.Now.Date;
            //invoke the method
            Error = ASaleItem.Valid(ItemID, ItemPrice, Quantity, SaleID, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemPriceMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSaleItem ASaleItem = new clsSaleItem();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            int ItemID = 1;
            decimal ItemPrice = 1;
            int Quantity = 2;
            int SaleID = 1;
            DateTime DateAdded = DateTime.Now.Date;
            //invoke the method
            Error = ASaleItem.Valid(ItemID, ItemPrice, Quantity, SaleID, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemPriceMid()
        {
            //create an instance of the class we want to create
            clsSaleItem ASaleItem = new clsSaleItem();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            int ItemID = 1;
            decimal ItemPrice = 50000;
            int Quantity = 2;
            int SaleID = 1;
            DateTime DateAdded = DateTime.Now.Date;
            //invoke the method
            Error = ASaleItem.Valid(ItemID, ItemPrice, Quantity, SaleID, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemPriceMaxMinusOne()
        {
            //create an instance of the class we want to create
            clsSaleItem ASaleItem = new clsSaleItem();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            int ItemID = 1;
            decimal ItemPrice = 99999;
            int Quantity = 2;
            int SaleID = 1;
            DateTime DateAdded = DateTime.Now.Date;
            //invoke the method
            Error = ASaleItem.Valid(ItemID, ItemPrice, Quantity, SaleID, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemPriceMax()
        {
            //create an instance of the class we want to create
            clsSaleItem ASaleItem = new clsSaleItem();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            int ItemID = 1;
            decimal ItemPrice = 100000;
            int Quantity = 2;
            int SaleID = 1;
            DateTime DateAdded = DateTime.Now.Date;
            //invoke the method
            Error = ASaleItem.Valid(ItemID, ItemPrice, Quantity, SaleID, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemPriceMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsSaleItem ASaleItem = new clsSaleItem();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            int ItemID = 1;
            decimal ItemPrice = 100001;
            int Quantity = 2;
            int SaleID = 1;
            DateTime DateAdded = DateTime.Now.Date;
            //invoke the method
            Error = ASaleItem.Valid(ItemID, ItemPrice, Quantity, SaleID, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemPriceExtremeMax()
        {
            //create an instance of the class we want to create
            clsSaleItem ASaleItem = new clsSaleItem();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            int ItemID = 1;
            decimal ItemPrice = 2479257253970;
            int Quantity = 2;
            int SaleID = 1;
            DateTime DateAdded = DateTime.Now.Date;
            //invoke the method
            Error = ASaleItem.Valid(ItemID, ItemPrice, Quantity, SaleID, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemPriceMinBoundaryNotOK()
        {
            //create an instance of the class we want to create
            clsSaleItem ASaleItem = new clsSaleItem();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            int ItemID = 1;
            decimal ItemPrice = -0.01m;
            int Quantity = 2;
            int SaleID = 1;
            DateTime DateAdded = DateTime.Now.Date;
            //invoke the method
            Error = ASaleItem.Valid(ItemID, ItemPrice, Quantity, SaleID, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemPriceMinBoundaryOK()
        {
            //create an instance of the class we want to create
            clsSaleItem ASaleItem = new clsSaleItem();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            int ItemID = 1;
            decimal ItemPrice = 0.01m;
            int Quantity = 2;
            int SaleID = 1;
            DateTime DateAdded = DateTime.Now.Date;
            //invoke the method
            Error = ASaleItem.Valid(ItemID, ItemPrice, Quantity, SaleID, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemPriceMaxBoundaryNotOK()
        {
            //create an instance of the class we want to create
            clsSaleItem ASaleItem = new clsSaleItem();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            int ItemID = 1;
            decimal ItemPrice = 100000.01m;
            int Quantity = 2;
            int SaleID = 1;
            DateTime DateAdded = DateTime.Now.Date;
            //invoke the method
            Error = ASaleItem.Valid(ItemID, ItemPrice, Quantity, SaleID, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemPriceMaxBoundaryOK()
        {
            //create an instance of the class we want to create
            clsSaleItem ASaleItem = new clsSaleItem();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            int ItemID = 1;
            decimal ItemPrice = 99999.99m;
            int Quantity = 2;
            int SaleID = 1;
            DateTime DateAdded = DateTime.Now.Date;
            //invoke the method
            Error = ASaleItem.Valid(ItemID, ItemPrice, Quantity, SaleID, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemPriceMoreThanTwoDecimalPlaces()
        {
            //create an instance of the class we want to create
            clsSaleItem ASaleItem = new clsSaleItem();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            int ItemID = 1;
            decimal ItemPrice = 5.345m;
            int Quantity = 2;
            int SaleID = 1;
            DateTime DateAdded = DateTime.Now.Date;
            //invoke the method
            Error = ASaleItem.Valid(ItemID, ItemPrice, Quantity, SaleID, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityExtremeMin()
        {
            //create an instance of the class we want to create
            clsSaleItem ASaleItem = new clsSaleItem();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            int ItemID = 1;
            decimal ItemPrice = 1.99m;
            int Quantity = -4875478;
            int SaleID = 1;
            DateTime DateAdded = DateTime.Now.Date;
            //invoke the method
            Error = ASaleItem.Valid(ItemID, ItemPrice, Quantity, SaleID, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinMinusOne()
        {
            //create an instance of the class we want to create
            clsSaleItem ASaleItem = new clsSaleItem();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            int ItemID = 1;
            decimal ItemPrice = 1.99m;
            int Quantity = 0;
            int SaleID = 1;
            DateTime DateAdded = DateTime.Now.Date;
            //invoke the method
            Error = ASaleItem.Valid(ItemID, ItemPrice, Quantity, SaleID, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMin()
        {
            //create an instance of the class we want to create
            clsSaleItem ASaleItem = new clsSaleItem();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            int ItemID = 1;
            decimal ItemPrice = 1.99m;
            int Quantity = 1;
            int SaleID = 1;
            DateTime DateAdded = DateTime.Now.Date;
            //invoke the method
            Error = ASaleItem.Valid(ItemID, ItemPrice, Quantity, SaleID, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSaleItem ASaleItem = new clsSaleItem();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            int ItemID = 1;
            decimal ItemPrice = 1.99m;
            int Quantity = 2;
            int SaleID = 1;
            DateTime DateAdded = DateTime.Now.Date;
            //invoke the method
            Error = ASaleItem.Valid(ItemID, ItemPrice, Quantity, SaleID, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMid()
        {
            //create an instance of the class we want to create
            clsSaleItem ASaleItem = new clsSaleItem();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            int ItemID = 1;
            decimal ItemPrice = 1.99m;
            int Quantity = 51;
            int SaleID = 1;
            DateTime DateAdded = DateTime.Now.Date;
            //invoke the method
            Error = ASaleItem.Valid(ItemID, ItemPrice, Quantity, SaleID, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxMinusOne()
        {
            //create an instance of the class we want to create
            clsSaleItem ASaleItem = new clsSaleItem();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            int ItemID = 1;
            decimal ItemPrice = 1.99m;
            int Quantity = 99;
            int SaleID = 1;
            DateTime DateAdded = DateTime.Now.Date;
            //invoke the method
            Error = ASaleItem.Valid(ItemID, ItemPrice, Quantity, SaleID, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMax()
        {
            //create an instance of the class we want to create
            clsSaleItem ASaleItem = new clsSaleItem();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            int ItemID = 1;
            decimal ItemPrice = 1.99m;
            int Quantity = 100;
            int SaleID = 1;
            DateTime DateAdded = DateTime.Now.Date;
            //invoke the method
            Error = ASaleItem.Valid(ItemID, ItemPrice, Quantity, SaleID, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsSaleItem ASaleItem = new clsSaleItem();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            int ItemID = 1;
            decimal ItemPrice = 1.99m;
            int Quantity = 101;
            int SaleID = 1;
            DateTime DateAdded = DateTime.Now.Date;
            //invoke the method
            Error = ASaleItem.Valid(ItemID, ItemPrice, Quantity, SaleID, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityExtremeMax()
        {
            //create an instance of the class we want to create
            clsSaleItem ASaleItem = new clsSaleItem();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            int ItemID = 1;
            decimal ItemPrice = 1.99m;
            int Quantity = 2147483647;
            int SaleID = 1;
            DateTime DateAdded = DateTime.Now.Date;
            //invoke the method
            Error = ASaleItem.Valid(ItemID, ItemPrice, Quantity, SaleID, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SaleIDExtremeMin()
        {
            //create an instance of the class we want to create
            clsSaleItem ASaleItem = new clsSaleItem();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            int ItemID = 1;
            decimal ItemPrice = 1.99m;
            int Quantity = 2;
            int SaleID = -4875478;
            DateTime DateAdded = DateTime.Now.Date;
            //invoke the method
            Error = ASaleItem.Valid(ItemID, ItemPrice, Quantity, SaleID, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SaleIDMinMinusOne()
        {
            //create an instance of the class we want to create
            clsSaleItem ASaleItem = new clsSaleItem();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            int ItemID = 1;
            decimal ItemPrice = 1.99m;
            int Quantity = 2;
            int SaleID = 0;
            DateTime DateAdded = DateTime.Now.Date;
            //invoke the method
            Error = ASaleItem.Valid(ItemID, ItemPrice, Quantity, SaleID, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SaleIDMin()
        {
            //create an instance of the class we want to create
            clsSaleItem ASaleItem = new clsSaleItem();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            int ItemID = 1;
            decimal ItemPrice = 1.99m;
            int Quantity = 2;
            int SaleID = 1;
            DateTime DateAdded = DateTime.Now.Date;
            //invoke the method
            Error = ASaleItem.Valid(ItemID, ItemPrice, Quantity, SaleID, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SaleIDMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSaleItem ASaleItem = new clsSaleItem();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            int ItemID = 1;
            decimal ItemPrice = 1.99m;
            int Quantity = 2;
            int SaleID = 2;
            DateTime DateAdded = DateTime.Now.Date;
            //invoke the method
            Error = ASaleItem.Valid(ItemID, ItemPrice, Quantity, SaleID, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SaleIDMid()
        {
            //create an instance of the class we want to create
            clsSaleItem ASaleItem = new clsSaleItem();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            int ItemID = 1;
            decimal ItemPrice = 1.99m;
            int Quantity = 2;
            int SaleID = 500000001;
            DateTime DateAdded = DateTime.Now.Date;
            //invoke the method
            Error = ASaleItem.Valid(ItemID, ItemPrice, Quantity, SaleID, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SaleIDMaxMinusOne()
        {
            //create an instance of the class we want to create
            clsSaleItem ASaleItem = new clsSaleItem();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            int ItemID = 1;
            decimal ItemPrice = 1.99m;
            int Quantity = 2;
            int SaleID = 999999999;
            DateTime DateAdded = DateTime.Now.Date;
            //invoke the method
            Error = ASaleItem.Valid(ItemID, ItemPrice, Quantity, SaleID, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SaleIDMax()
        {
            //create an instance of the class we want to create
            clsSaleItem ASaleItem = new clsSaleItem();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            int ItemID = 1;
            decimal ItemPrice = 1.99m;
            int Quantity = 2;
            int SaleID = 1000000000;
            DateTime DateAdded = DateTime.Now.Date;
            //invoke the method
            Error = ASaleItem.Valid(ItemID, ItemPrice, Quantity, SaleID, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SaleIDMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsSaleItem ASaleItem = new clsSaleItem();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            int ItemID = 1;
            decimal ItemPrice = 1.99m;
            int Quantity = 2;
            int SaleID = 1000000001;
            DateTime DateAdded = DateTime.Now.Date;
            //invoke the method
            Error = ASaleItem.Valid(ItemID, ItemPrice, Quantity, SaleID, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SaleIDExtremeMax()
        {
            //create an instance of the class we want to create
            clsSaleItem ASaleItem = new clsSaleItem();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            int ItemID = 1;
            decimal ItemPrice = 1.99m;
            int Quantity = 2;
            int SaleID = 2147483647;
            DateTime DateAdded = DateTime.Now.Date;
            //invoke the method
            Error = ASaleItem.Valid(ItemID, ItemPrice, Quantity, SaleID, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsSaleItem ASaleItem = new clsSaleItem();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            int ItemID = 1;
            decimal ItemPrice = 1.99m;
            int Quantity = 2;
            int SaleID = 1;
            DateTime DateAdded = (DateTime.Now.Date).AddYears(-100);
            //invoke the method
            Error = ASaleItem.Valid(ItemID, ItemPrice, Quantity, SaleID, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinMinusOne()
        {
            //create an instance of the class we want to create
            clsSaleItem ASaleItem = new clsSaleItem();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            int ItemID = 1;
            decimal ItemPrice = 1.99m;
            int Quantity = 2;
            int SaleID = 1;
            DateTime DateAdded = (DateTime.Now.Date).AddDays(-1);
            //invoke the method
            Error = ASaleItem.Valid(ItemID, ItemPrice, Quantity, SaleID, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsSaleItem ASaleItem = new clsSaleItem();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            int ItemID = 1;
            decimal ItemPrice = 1.99m;
            int Quantity = 2;
            int SaleID = 1;
            DateTime DateAdded = DateTime.Now.Date;
            //invoke the method
            Error = ASaleItem.Valid(ItemID, ItemPrice, Quantity, SaleID, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSaleItem ASaleItem = new clsSaleItem();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            int ItemID = 1;
            decimal ItemPrice = 1.99m;
            int Quantity = 2;
            int SaleID = 1;
            DateTime DateAdded = (DateTime.Now.Date).AddDays(1);
            //invoke the method
            Error = ASaleItem.Valid(ItemID, ItemPrice, Quantity, SaleID, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsSaleItem ASaleItem = new clsSaleItem();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            int ItemID = 1;
            decimal ItemPrice = 1.99m;
            int Quantity = 2;
            int SaleID = 1;
            DateTime DateAdded = (DateTime.Now.Date).AddYears(100);
            //invoke the method
            Error = ASaleItem.Valid(ItemID, ItemPrice, Quantity, SaleID, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
