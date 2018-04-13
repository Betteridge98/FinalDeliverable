using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OurClassLibrary;
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
            TestItem.SaleID = 2;
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
            TestItem.SaleID = 2;
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
            TestItem.SaleID = 2;
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

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsSaleCollection Sales = new clsSaleCollection();
            //create the item of test data
            clsSaleItem TestItem = new clsSaleItem();
            //var to store the primary key
            Int32 PrimaryKey = 1;
            //set its properties
            TestItem.ItemID = 4;
            TestItem.ItemPrice = 1.99m;
            TestItem.Quantity = 1;
            TestItem.SaleID = 2;
            TestItem.DateAdded = DateTime.Now.Date;
            //set ThisSale to the testdata
            Sales.ThisSale = TestItem;
            //add the record
            PrimaryKey = Sales.Add();
            //set the primary key of the test data
            TestItem.ItemID = PrimaryKey;
            //find the record
            Sales.ThisSale.Find(PrimaryKey);
            //delete the record
            Sales.Delete();
            //now find the record
            Boolean Found = Sales.ThisSale.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsSaleCollection Sales = new clsSaleCollection();
            //create the item of test data
            clsSaleItem TestItem = new clsSaleItem();
            //var to store the primary key
            Int32 PrimaryKey = 1;
            //set its properties
            TestItem.ItemID = 5;
            TestItem.ItemPrice = 1.99m;
            TestItem.Quantity = 1;
            TestItem.SaleID = 2;
            TestItem.DateAdded = DateTime.Now.Date;
            //set ThisSale to the testdata
            Sales.ThisSale = TestItem;
            //add the record
            PrimaryKey = Sales.Add();
            //set the primary key of the test data
            TestItem.ItemID = PrimaryKey;
            //modify the test data
            TestItem.ItemID = 6;
            TestItem.ItemPrice = 58.99m;
            TestItem.Quantity = 3;
            TestItem.SaleID = 3;
            TestItem.DateAdded = DateTime.Now.Date;
            //set the record based on the new test data
            Sales.ThisSale = TestItem;
            //update the record
            Sales.Update();
            //find the record
            Sales.ThisSale.Find(PrimaryKey);
            //test to see ThisSale matches the test data
            Assert.AreEqual(Sales.ThisSale, TestItem);
        }

        //[TestMethod]
        //public void FilterBySaleIDOK()
        //{
        //    //create an instance of the class containing unfiltered results
        //    clsSaleCollection Sales = new clsSaleCollection();
        //    //create an instance of the filtered data
        //    clsSaleCollection FilteredSales = new clsSaleCollection();
        //    //apply a blank string (should return all records)
        //    //FilteredSales.FilterBySaleID(Convert.ToInt32(null));
        //    FilteredSales.FilterBySaleID(1);
        //    //test to see that the two values are the same
        //    Assert.AreEqual(Sales.Count, FilteredSales.Count);
            
        //}

        [TestMethod]
        public void FilterBySaleIDNoneFound()
        {

            //create an instance of the filtered data
            clsSaleCollection FilteredSales = new clsSaleCollection();
            //apply a sale id that doesn't exist
            FilteredSales.FilterBySaleID(0);
            //test to see that there are no records
            Assert.AreEqual(0, FilteredSales.Count);
        }

        [TestMethod]
        public void FilterBySaleIDTestDataFound()
        {
            //create an instance of the filtered data
            clsSaleCollection FilteredSales = new clsSaleCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a sale id that doesn't exist
            FilteredSales.FilterBySaleID(1);
            //check that the correct number of records are found
            if (FilteredSales.Count == 2)
            {
                //check that the first record is ID 1
                if (FilteredSales.SaleItems[0].ItemID != 1)
                {
                    OK = false;
                }
                //check that the second record is ID 2
                if (FilteredSales.SaleItems[1].ItemID != 2)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see there are no records
            Assert.IsTrue(OK);
        }
    }
}
