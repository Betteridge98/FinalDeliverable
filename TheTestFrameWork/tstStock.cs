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

        [TestMethod]
        public void ValidGenreOK()
        {
            //create an instance of the Method we want to create
            clsStock TheStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean GenreOK = false;
            //create some test data to assign to the property
            string SomeGenre = "First Person Shooter";
            //invoke the method
            GenreOK = TheStock.Valid(SomeGenre);
            //test to see that the result is correct
            Assert.IsTrue(GenreOK);
        }

        [TestMethod]
        public void ValidAgeRatingOK()
        {
            //create an instance of the Method we want to create
            clsStock TheStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean AgeRateOK = false;
            //create some test data to assign to the property
            Int32 SomeAge = 13;
            //invoke the method
            AgeRateOK = TheStock.AgeRatingValid(SomeAge);
            //test to see that the result is correct
            Assert.IsTrue(AgeRateOK);
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

        [TestMethod]
        public void GenreMinLessOne()
        {
            //create an instance of the Method we want to create
            clsStock TheStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean GenreOK = false;
            //create some test data to assign to the property
            string SomeGenre = "";
            //invoke the method
            GenreOK = TheStock.GenreValid(SomeGenre);
            //test to see that the result is correct
            Assert.IsFalse(GenreOK);
        }

        [TestMethod]
        public void GenreMinBoundary()
        {
            //create an instance of the Method we want to create
            clsStock TheStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean GenreOK = false;
            //create some test data to assign to the property
            string SomeGenre = "a";
            //invoke the method
            GenreOK = TheStock.GenreValid(SomeGenre);
            //test to see that the result is correct
            Assert.IsTrue(GenreOK);
        }

        [TestMethod]
        public void GenreMinPlusOne()
        {
            //create an instance of the Method we want to create
            clsStock TheStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean GenreOK = false;
            //create some test data to assign to the property
            string SomeGenre = "aa";
            //invoke the method
            GenreOK = TheStock.GenreValid(SomeGenre);
            //test to see that the result is correct
            Assert.IsTrue(GenreOK);
        }

        [TestMethod]
        public void GenreMiddle()
        {
            //create an instance of the Method we want to create
            clsStock TheStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean GenreOK = false;
            //create some test data to assign to the property
            string SomeGenre = "qwertyu";
            //invoke the method
            GenreOK = TheStock.GenreValid(SomeGenre);
            //test to see that the result is correct
            Assert.IsTrue(GenreOK);
        }

        [TestMethod]
        public void GenreMaxPlusOne()
        {
            //create an instance of the Method we want to create
            clsStock TheStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean GenreOK = false;
            //create some test data to assign to the property
            string SomeGenre = "qwertyuiopasdfgh";
            //invoke the method
            GenreOK = TheStock.GenreValid(SomeGenre);
            //test to see that the result is correct
            Assert.IsFalse(GenreOK);
        }

        [TestMethod]
        public void GenreMaxBoundary()
        {
            //create an instance of the Method we want to create
            clsStock TheStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean GenreOK = false;
            //create some test data to assign to the property
            string SomeGenre = "qwertyuiopasdfg";
            //invoke the method
            GenreOK = TheStock.GenreValid(SomeGenre);
            //test to see that the result is correct
            Assert.IsTrue(GenreOK);
        }

        [TestMethod]
        public void GenreMaxLessOne()
        {
            //create an instance of the Method we want to create
            clsStock TheStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean GenreOK = false;
            //create some test data to assign to the property
            string SomeGenre = "qwertyuiopasdf";
            //invoke the method
            GenreOK = TheStock.GenreValid(SomeGenre);
            //test to see that the result is correct
            Assert.IsTrue(GenreOK);
        }

        [TestMethod]
        public void GenreExtremeMax()
        {
            //create an instance of the Method we want to create
            clsStock TheStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean GenreOK = false;
            //create some test data to assign to the property
            string SomeGenre = "";
            //pad thew string with a characters
            SomeGenre = SomeGenre.PadRight(500, 'a');
            //invoke the method
            GenreOK = TheStock.GenreValid(SomeGenre);
            //test to see that the result is correct
            Assert.IsFalse(GenreOK);

        }

        [TestMethod]
        public void AgeRatingMinLessOne()
        {
            //create an instance of the Method we want to create
            clsStock TheStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean AgeOK = false;
            //create some test data to assign to the property
            Int32 SomeAge = 0;
            //invoke the method
            AgeOK = TheStock.AgeRatingValid(SomeAge);
            //test to see that the result is correct
            Assert.IsFalse(AgeOK);
        }

        [TestMethod]
        public void AgeRatingMinBoundary()
        {
            //create an instance of the Method we want to create
            clsStock TheStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean AgeOK = false;
            //create some test data to assign to the property
            Int32 SomeAge = 1;
            //invoke the method
            AgeOK = TheStock.AgeRatingValid(SomeAge);
            //test to see that the result is correct
            Assert.IsTrue(AgeOK);
        }

        [TestMethod]
        public void AgeRatingMinPlusOne()
        {
            //create an instance of the Method we want to create
            clsStock TheStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean AgeOK = false;
            //create some test data to assign to the property
            Int32 SomeAge = 2;
            //invoke the method
            AgeOK = TheStock.AgeRatingValid(SomeAge);
            //test to see that the result is correct
            Assert.IsTrue(AgeOK);
        }

        [TestMethod]
        public void AgeRatingMaxLessOne()
        {
            //create an instance of the Method we want to create
            clsStock TheStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean AgeOK = false;
            //create some test data to assign to the property
            Int32 SomeAge = 17;
            //invoke the method
            AgeOK = TheStock.AgeRatingValid(SomeAge);
            //test to see that the result is correct
            Assert.IsTrue(AgeOK);
        }

        [TestMethod]
        public void AgeRatingMaxBoundary()
        {
            //create an instance of the Method we want to create
            clsStock TheStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean AgeOK = false;
            //create some test data to assign to the property
            Int32 SomeAge = 18;
            //invoke the method
            AgeOK = TheStock.AgeRatingValid(SomeAge);
            //test to see that the result is correct
            Assert.IsTrue(AgeOK);
        }

        [TestMethod]
        public void AgeRatingMaxPlusOne()
        {
            //create an instance of the Method we want to create
            clsStock TheStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean AgeOK = false;
            //create some test data to assign to the property
            Int32 SomeAge = 19;
            //invoke the method
            AgeOK = TheStock.AgeRatingValid(SomeAge);
            //test to see that the result is correct
            Assert.IsFalse(AgeOK);
        }

        [TestMethod]
        public void AgeRatingMiddle()
        {
            //create an instance of the Method we want to create
            clsStock TheStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean AgeOK = false;
            //create some test data to assign to the property
            Int32 SomeAge = 9;
            //invoke the method
            AgeOK = TheStock.AgeRatingValid(SomeAge);
            //test to see that the result is correct
            Assert.IsTrue(AgeOK);
        }

        [TestMethod]
        public void AgeRatingExtremeMax()
        {
            //create an instance of the Method we want to create
            clsStock TheStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean AgeOK = false;
            //create some test data to assign to the property
            Int32 SomeAge = 5000;
            //invoke the method
            AgeOK = TheStock.AgeRatingValid(SomeAge);
            //test to see that the result is correct
            Assert.IsFalse(AgeOK);
        }

    }
}

