using System.Collections.Generic;

namespace OurClassLibrary
{
    public class clsStockCollection
    {
        //public constructor for the class.
        public clsStockCollection()
        {
            //create an instance of the stock class to store an item
            clsStock AStock = new clsStock();
            //set the stock to overwatch
            AStock.ItemName = "Overwatch";
            //add add the item to the private list of stock
            mAllStock.Add(AStock);
            //re initialise the Astock object to accept a new item
            AStock = new clsStock();
            //set the item to Call Of Duty
            AStock.ItemName = "Call Of Duty";
            //add the second item to the private list of stock
            mAllStock.Add(AStock);
            //the private list contains two items
        }
        
               
        //creates a private data memeber for the AllStock list
        private List<clsStock> mAllStock = new List<clsStock>();

        //public property for count
        public int Count
        {
            get
            {
                //returns the count property to the private list
                return mAllStock.Count;
            }
            set
            {
                //
            }
        }

        //public property for allstock
        public List<clsStock> AllStock
        {
            //getter sends data to requesting code
            get
            {
                //return the private data member
                return mAllStock;
            }
            //setter accepts data from other objects
            set
            {
                //assign the incoming value to the private data member
                mAllStock = value;
            }
        }


    }
}