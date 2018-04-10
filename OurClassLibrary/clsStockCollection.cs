using System.Collections.Generic;

namespace OurClassLibrary
{
    public class clsStockCollection
    {
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