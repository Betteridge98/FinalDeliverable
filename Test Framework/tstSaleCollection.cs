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
            clsSaleCollection SaleItems = new clsSaleCollection();
            //test to see that it exists
            Assert.IsNotNull(SaleItems);
        }

        [TestMethod]
        public void SaleItemsOK()
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
            Sales.SaleItems = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Sales.SaleItems, TestList);
        }

        [TestMethod]
        public void CountMatchesList()
        {
            //create an instance of the class we want to create
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
            Sales.SaleItems = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Sales.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to creeate
            clsSaleCollection Sales = new clsSaleCollection();
            //create the item of test data
            clsSaleItem TestItem = new clsSaleItem();
            //var to store the primary key
            Int32 PrimaryKey = 1;
            //set its properties
            TestItem.ItemID = 3;
            TestItem.ItemPrice = 1.99m;
            TestItem.Quantity = 1;
            TestItem.SaleID = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            //set ThisSale to the testdata
            Sales.ThisSale = TestItem;
            //add the record
            PrimaryKey = Sales.Add();
            //set the primary key of the test data
            TestItem.ItemID = PrimaryKey;
            //find the record
            Sales.ThisSale.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(Sales.ThisSale, TestItem);
        }
    }
}
