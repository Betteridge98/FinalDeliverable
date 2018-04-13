using System;

namespace OurClassLibrary
{
    public class clsStock
    {
        //private members for the class
        private Int32 itemNo;
        private string itemName;
        private Int32 ageRating;
        private string genre;
        private string condition;
        clsDataConnection myDB = new clsDataConnection();

        public string ItemName
        {
            get
            {
                return itemName;
            }
            set
            {
                itemName = value;
            }
        }

        public string Genre
        {
            get
            {
                return genre;
            }
            set
            {
                genre = value;
            }
        }
        public string Condition
        {
            get
            {
                return condition;
            }
            set
            {
                condition = value;
            }
        }
        public Int32 AgeRating
        {
            get
            {
                return ageRating;
            }
            set
            {
                ageRating = value;
            }
        }
        public Int32 ItemNo
        {
            get
            {
                return itemNo;
            }
            set
            {
                itemNo = value;
            }
        }

        public string AllDetails
        {
            get
            {
                return "ItemName:  " + ItemName + "  AgeRating:  " + AgeRating + "  Genre:  " + Genre + "  Condition:  " + Condition;
            }
        
        }
        public bool Valid(string SomeItemName)
        {
            //boolean flag to indicate that all is OK
            Boolean OK = true;
            //if Item name is blank
            if (SomeItemName == "")
            {
                //flag an error
                OK = false;
            }
            //if the Item name is more than 20 characters
            if (SomeItemName.Length > 25)
            {
                //flag an error
                OK = false;
            }
            return OK;
        }

        //find method
        public Boolean Find(Int32 ItemNo)
        {
            //re set the connection to the database
            myDB = new clsDataConnection();
            //pass the parameter to the stored procedure
            myDB.AddParameter("@ItemNo", ItemNo);
            //execute the stored procedure
            myDB.Execute("sproc_tblStock_FilterByItemNo");
            //check to see if it found anything
            if (myDB.Count == 1)
            {
                //set the private data members with the data from the database
                //private Int32 itemNo;
                itemNo = Convert.ToInt32(myDB.DataTable.Rows[0]["ItemNo"]);
                //private string itemName
                itemName = Convert.ToString(myDB.DataTable.Rows[0]["ItemName"]);
                //private string genre
                genre = Convert.ToString(myDB.DataTable.Rows[0]["Genre"]);
                //private string condition
                condition = Convert.ToString(myDB.DataTable.Rows[0]["Condition"]);
                //private Int32 ageRating
                ageRating = Convert.ToInt32(myDB.DataTable.Rows[0]["AgeRating"]);
                //return success
                return true;
            }
            else //stock no was invalid
            {
                //return that there was a problem
                return false;
            }
        }
        public bool GenreValid(string SomeGenre)
        {
            //boolean flag to indicate that all is OK
            Boolean OK = true;
            //if Genre is blank
            if (SomeGenre == "")
            {
                //flag an error
                OK = false;
            }
            //if the Genre is more than 15 characters
            if (SomeGenre.Length > 15)
            {
                //flag an error
                OK = false;
            }
            return OK;
        }

        public bool ConditionValid(string SomeCondition)
        {
            //boolean flag to indicate that all is OK
            Boolean OK = true;
            //if Condition is blank
            if (SomeCondition == "")
            {
                //flag an error
                OK = false;
            }
            //if the Condition is more than 10 characters
            if (SomeCondition.Length > 10)
            {
                //flag an error
                OK = false;
            }
            return OK;
        }

        public bool AgeRatingValid(Int32 SomeAgeRating)
        {
            //boolean flag to indicate that all is OK
            Boolean OK = true;
            //if AgeRating is less than 1
            if (SomeAgeRating < 1)
            {
                //flag an error
                OK = false;
            }
            //if the AgeRating is more than 18
            if (SomeAgeRating > 18)
            {
                //flag an error
                OK = false;
            }
            return OK;
        }
    }
}