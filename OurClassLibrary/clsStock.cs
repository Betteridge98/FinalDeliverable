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

        public bool GenreValid(string SomeGenre)
        {
            //boolean flag to indicate all is okay
            Boolean OK = true;
            //if the name of the item is blank, then its false
            if (SomeGenre == "")
            {
                //flag an error
                OK = false;
            }
            //if the name of the item is more than 50 characters
            if (SomeGenre.Length > 15)
            {
                //flag an error
                OK = false;
            }
            return OK;
        }

        public bool AgeRatingValid(Int32 SomeAge)
        {
            //boolean flag to indicate all is okay
            Boolean OK = true;
            //if the age is lower than 1, then its false
            if (SomeAge < 1)
            {
                //flag an error
                OK = false;
            }
            //if the age is higher than 18, then its false.
            if (SomeAge > 18)
            {
                //flag an error
                OK = false;
            }
            return OK;
        }
    }
}