using System;

namespace OurClassLibrary
{
    public class clsStock
    {
        public int AgeRating { get; set; }
        public string Condition { get; set; }
        public string Genre { get; set; }
        public bool InStock { get; set; }
        public string ItemName { get; set; }
        public int ItemNumber { get; set; }

        public bool Valid(string SomeItem)
        {
            //boolean flag to indicate all is okay
            Boolean OK = true;
            //if the name of the item is blank, then its false
            if (SomeItem == "")
            {
                //flag an error
                OK = false;
            }
            //if the name of the item is more than 50 characters
            if (SomeItem.Length > 25)         
            {
                //flag an error
                OK = false;
            }
            return OK;
        }
    }
}