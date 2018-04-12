using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OurClassLibrary;
using System.Collections.Generic;

namespace TheTestFrameWork
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //this creates an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //test to see if it exists
            Assert.IsNotNull(AllStock);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            //this creates an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign the property
            Int32 SomeCount = 4;
            //assign data to the property
            AllStock.Count = SomeCount;
            //test to see if it exists
            Assert.AreEqual(AllStock.Count, SomeCount);
        }

        [TestMethod]
        public void StockListOK()
        {
            //this creates an instance of the class we want to create
            clsStockCollection Stock = new clsStockCollection();
            //create some test data to assign the property
            //this time it needs to be a list type of data
            List<clsStock> TestStockList = new List<clsStock>();
            //add an item to the list
            //create the item of test data
            clsStock TestItem = new clsStock();
            //set the properties
            TestItem.ItemNo = 1;
            TestItem.ItemName = "Overwatch";
            TestItem.Genre = "First Person Shooter";
            TestItem.AgeRating = 13;
            TestItem.Condition = "Good";
            //add the item to the test list
            TestStockList.Add(TestItem);
            //assign the data to the property
            Stock.AllStock = TestStockList;
            //test to see if it exists
            Assert.AreEqual(Stock.Count, TestStockList.Count);
        }

        //[TestMethod]
        //public void TwoStockItemsPresent()
        //{
        //    //this creates an instance of the class we want to create
        //    clsStockCollection AllStock = new clsStockCollection();
        //    //test to see if the values are the same
        //    Assert.AreEqual(AllStock.Count, 2);
        //}

    }
}
