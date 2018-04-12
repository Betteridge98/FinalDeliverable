using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurClassLibrary
{


    public class clsSaleItem
    {
        //private data members for the class
        private Int32 itemID;
        private decimal itemPrice;
        private Int32 quantity;
        private Int32 saleID;
        private DateTime dateAdded;
        clsDataConnection myDB = new clsDataConnection();

        //public properties
        public Int32 ItemID
        {
            get
            {
                return itemID;
            }
            set
            {
                itemID = value;
            }
        }

        public decimal ItemPrice
        {
            get
            {
                return itemPrice;
            }
            set
            {
                itemPrice = value;
            }
        }

        public Int32 Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }

        public Int32 SaleID
        {
            get
            {
                return saleID;
            }
            set
            {
                saleID = value;
            }
        }

        public DateTime DateAdded
        {
            get
            {
                return dateAdded;
            }
            set
            {
                dateAdded = value;
            }
        }

        ///public find method
        public Boolean Find(Int32 ItemID)
        {
            //re set the connection to the database
            myDB = new clsDataConnection();
            //pass the parameter to the stored procedure
            myDB.AddParameter("@ItemID", ItemID);
            //execute the stored procedure
            myDB.Execute("sproc_tblSaleItem_FilterByItemID");
            //check to see if we found anything
            if (myDB.Count == 1)
            {
                //set the private data members with the data from the database
                //private Int32 itemID;
                itemID = Convert.ToInt32(myDB.DataTable.Rows[0]["ItemID"]);
                //private decimal itemPrice;
                itemPrice = Convert.ToDecimal(myDB.DataTable.Rows[0]["ItemPrice"]);
                //private Int32 quantity;
                quantity = Convert.ToInt32(myDB.DataTable.Rows[0]["Quantity"]);
                //private string saleID;
                saleID = Convert.ToInt32(myDB.DataTable.Rows[0]["SaleID"]);
                //private DateTime dateAdded
                dateAdded = Convert.ToDateTime(myDB.DataTable.Rows[0]["DateAdded"]);
                //return success
                return true;
            }
            else //user no was invalid
            {
                //return that there was a problem
                return false;
            }
        }

        public bool Valid(int SomeItemID)
        {
            //if the ItemID isn't 0
            if (SomeItemID != 0)
            {
                //return true
                return true;
            }
            //otherwise return false
            {
                //return false
                return false;
            }
        }

        public string Valid(int itemID, decimal itemPrice, int quantity, int saleID, DateTime dateAdded)
        {
            //create a string variable to store the error
            String Error = "";
            //if the ItemID is less than 1
            if (itemID < 1)
            {
                //record the error
                Error = Error + "The ItemID may not be less than 1";
            }
            //if the ItemID is more than 1000000000
            if (itemID > 1000000000)
            {
                //record the error
                Error = Error + "The ItemID may not be more than 1000000000";
            }
            //if the ItemPrice is less than 0
            if (itemPrice < 0)
            {
                //record the error
                Error = Error + "The ItemPrice may not be less than 0";
            }
            //if the ItemPrice is more than 100000
            if (itemPrice > 100000)
            {
                //record the error
                Error = Error + "The ItemPrice may not be more than 100000";
            }
            //if the ItemPrice has more than two decimal places
            if (Decimal.Round(itemPrice, 2) != itemPrice)
            {
                //record the error
                Error = Error + "The ItemPrice may not have more than two decimal places";
            }
            //if the Quantity is less than 1
            if (quantity < 1)
            {
                //record the error
                Error = Error + "The Quantity may not be less than 1";
            }
            //if the Quantity is more than 100
            if (quantity > 100)
            {
                //record the error
                Error = Error + "The Quantity may not be more than 100";
            }
            //if the SaleID is less than 1
            if (saleID < 1)
            {
                //record the error
                Error = Error + "The SaleID may not be less than 1";
            }
            //if the SaleID is more than 1000000000
            if (saleID > 1000000000)
            {
                //record the error
                Error = Error + "The SaleID may not be more than 1000000000";
            }
            //if the DateAdded is before today
            if (dateAdded < DateTime.Now.Date)
            {
                //record the error
                Error = Error + "The date can't be in the past";
            }
            //if the DateAdded is after today
            if (dateAdded > DateTime.Now.Date)
            {
                //record the error
                Error = Error + "The date can't be in the future";
            }
            //return any error messages
            return Error;
        }
    }
}
