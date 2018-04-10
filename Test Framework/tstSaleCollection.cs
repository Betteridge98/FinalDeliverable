using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;

namespace Test_Framework
{
    [TestClass]
    public class tstSaleCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsSaleCollection AllSales = new clsSaleCollection();
            //test to see that it exists
            Assert.IsNotNull(AllSales);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsSaleCollection AllSales = new clsSaleCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 0;
            //assign the data to the property
            AllSales.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllSales.Count, SomeCount);
        }

        [TestMethod]
        public void AllSalesOK()
        {
            //create an instance of the class we want to creeate
            clsSaleCollection Sales = new clsSaleCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsSaleItem> TestList = new List<clsSaleItem>();
            //add an item to the list
            //create the item of test data
            clsSaleItem TestItem = new clsSaleItem();
            //set its properties
            TestItem.ItemID = 1;
            TestItem.ItemPrice = 1.99m;
            TestItem.Quantity = 1;
            TestItem.SaleID = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            //Sales.AllSales = TestList;
            //test to see that the two values are the same
            //Assert.AreEqual(Sales.AllSales, TestList);
        }
    }
}
