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
            DateTime DateAdded = Convert.ToDateTime("05/04/2018");
            //invoke the method
            Error = ASaleItem.Valid(ItemID, ItemPrice, Quantity, SaleID, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}
