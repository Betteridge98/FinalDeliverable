using System;

namespace OurClassLibrary
{
    public class clsStock
    {
        public int AgeRating { get; set; }
        public string Condition { get; set; }
        public string Genre { get; set; }
        public string ItemName { get; set; }

        public bool Valid(string someItem)
        {
           //if the name of the item is blank, then its false
           if (ItemName != "")
            {
                //returns as true
                return true;
            }
           //otherweise return it as false
           else
            {
                //returns it as false
                return false;
            }
        }

    }
}