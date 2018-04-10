using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OurClassLibrary;

namespace TheTestFrameWork
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStock TheStock = new clsStock();
            //test to see if it exists
            Assert.IsNotNull(TheStock);
        }

        //
        [TestMethod]
        public void ItemNamePropertyOK()
        {
            //create an instance of the property we want to create
            clsStock TheStock = new clsStock();
            //creating the test data to assign the this property
            string SomeItem = "Overwatch";
            //assign the data to the property
            TheStock.ItemName = SomeItem;
            //test to see if it exists
            Assert.AreEqual(TheStock.ItemName, SomeItem);
        }

        [TestMethod]
        public void ItemNoPropertyOK()
        {
            //create an instance of the property we want to create
            clsStock TheStock = new clsStock();
            //creating the test data to assign the this property
            Int32 ItemNo = 13;
            //assign the data to the property
            TheStock.ItemNumber = ItemNo;
            //test to see if it exists
            Assert.AreEqual(TheStock.ItemNumber, ItemNo);
        }

        [TestMethod]
        public void GenrePropertyOK()
        {
            //create an instance of the property we want to create
            clsStock TheStock = new clsStock();
            //creating the test data to assign the this property
            string SomeGenre = "First Person Shooter";
            //assign the data to the property
            TheStock.Genre = SomeGenre;
            //test to see if it exists
            Assert.AreEqual(TheStock.Genre, SomeGenre);
        }

        [TestMethod]
        public void AgeRatingPropertyOK()
        {
            //create an instance of the property we want to create
            clsStock TheStock = new clsStock();
            //creating the test data to assign the this property
            Int32 AgeRate = 13;
            //assign the data to the property
            TheStock.AgeRating = AgeRate;
            //test to see if it exists
            Assert.AreEqual(TheStock.AgeRating, AgeRate);
        }

        [TestMethod]
        public void ConditionPropertyOK()
        {
            //create an instance of the property we want to create
            clsStock TheStock = new clsStock();
            //creating the test data to assign the this property
            string SomeCondition = "Good";
            //assign the data to the property
            TheStock.Condition = SomeCondition;
            //test to see if it exists
            Assert.AreEqual(TheStock.Condition, SomeCondition);
        }

        [TestMethod]
        public void InStockPropertyOK()
        {
            //create an instance of the property we want to create
            clsStock TheStock = new clsStock();
            //creating the test data to assign the this property
            Boolean SomeStock = true;
            //assign the data to the property
            TheStock.InStock = SomeStock;
            //test to see if it exists
            Assert.AreEqual(TheStock.InStock, SomeStock);
        }

        //
        [TestMethod]
        public void ValidItemNameOK()
        {
            //create an instance of the Method we want to create
            clsStock TheStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean ItemOK = false;
            //create some test data to assign to the property
            string SomeItem = "Overwatch";
            //invoke the method
            ItemOK = TheStock.Valid(SomeItem);
            //test to see that the result is correct
            Assert.IsTrue(ItemOK);
        }

        //
        [TestMethod]
        public void ItemNameMinLessOne()
        {
            //create an instance of the Method we want to create
            clsStock TheStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean ItemOK = false;
            //create some test data to assign to the property
            string SomeItem = "";
            //invoke the method
            ItemOK = TheStock.Valid(SomeItem);
            //test to see that the result is correct
            Assert.IsFalse(ItemOK);
        }

        [TestMethod]
        public void ItemNameMinBoundary()
        {
            //create an instance of the Method we want to create
            clsStock TheStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean ItemOK = false;
            //create some test data to assign to the property
            string SomeItem = "a";
            //invoke the method
            ItemOK = TheStock.Valid(SomeItem);
            //test to see that the result is correct
            Assert.IsTrue(ItemOK);
        }

        [TestMethod]
        public void ItemNameMinPlusOne()
        {
            //create an instance of the Method we want to create
            clsStock TheStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean ItemOK = false;
            //create some test data to assign to the property
            string SomeItem = "aa";
            //invoke the method
            ItemOK = TheStock.Valid(SomeItem);
            //test to see that the result is correct
            Assert.IsTrue(ItemOK);
        }

        [TestMethod]
        public void ItemNameMaxLessOne()
        {
            //create an instance of the Method we want to create
            clsStock TheStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean ItemOK = false;
            //create some test data to assign to the property
            string SomeItem = "abcdefghijklmnopqrstuvwx";
            //invoke the method
            ItemOK = TheStock.Valid(SomeItem);
            //test to see that the result is correct
            Assert.IsTrue(ItemOK);
        }

        [TestMethod]
        public void ItemNameMaxBoundary()
        {
            //create an instance of the Method we want to create
            clsStock TheStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean ItemOK = false;
            //create some test data to assign to the property
            string SomeItem = "abcdefghijklmnopqrstuvwxy";
            //invoke the method
            ItemOK = TheStock.Valid(SomeItem);
            //test to see that the result is correct
            Assert.IsTrue(ItemOK);
        }

        [TestMethod]
        public void ItemNameMaxPlusOne()
        {
            //create an instance of the Method we want to create
            clsStock TheStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean ItemOK = false;
            //create some test data to assign to the property
            string SomeItem = "abcdefghijklmnopqrstuvwxyz";
            //invoke the method
            ItemOK = TheStock.Valid(SomeItem);
            //test to see that the result is correct
            Assert.IsFalse(ItemOK);
        }

        [TestMethod]
        public void ItemNameMiddle()
        {
            //create an instance of the Method we want to create
            clsStock TheStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean ItemOK = false;
            //create some test data to assign to the property
            string SomeItem = "abcdefghijklm";
            //invoke the method
            ItemOK = TheStock.Valid(SomeItem);
            //test to see that the result is correct
            Assert.IsTrue(ItemOK);
        }

        [TestMethod]
        public void ItemNameExtremeMax()
        {
            //create an instance of the Method we want to create
            clsStock TheStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean ItemOK = false;
            //create some test data to assign to the property
            string SomeItem = "";
            //pad thew string with a characters
            SomeItem = SomeItem.PadRight(500, 'a');
            //invoke the method
            ItemOK = TheStock.Valid(SomeItem);
            //test to see that the result is correct
            Assert.IsFalse(ItemOK);
        }

    }
}
