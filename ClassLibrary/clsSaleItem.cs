using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
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

        public string Valid(int itemID, decimal itemPrice, int quantity, int saleID, DateTime DateAdded)
        {
            return "";
        }
    }
}
