using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    

    public class clsSaleCollection
    {
        public clsSaleCollection()
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure to get a list of data
            DB.Execute("sproc_tblSaleItem_SelectAll");
            //get the count of records
            Int32 RecordCount = DB.Count;
            //set up the index for the loop
            Int32 Index = 0;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a new instance of the saleitem class
                clsSaleItem SaleItem = new clsSaleItem();
                //get the saleitem ItemID
                SaleItem.ItemID = Convert.ToInt32(DB.DataTable.Rows[Index]["ItemID"]);
                //add the saleitem to the private data member
                mSaleItems.Add(SaleItem);
                //increment the index
                Index++;
            }
        }
        //private data member that stores the count of records found
        private Int32 recordCount;
        //create a private list data member to store the data from the database
        private List<clsSaleItem> mSaleItems = new List<clsSaleItem>();
        //private data members for the class
        private Int32 saleID;
        private decimal thisSale;
        //private data member to connect to the database
        private clsDataConnection myDB = new clsDataConnection();

        //public property returning the count of records
        public Int32 Count
        {
            get
            {
                //return record count;
                //return recordCount;
                return mSaleItems.Count;
            }
            set
            {

            }
        }

        //public list of users
        public List<clsSaleItem> SaleItems
        {
            //getter sends data to requesting code
            get
            {
                //return the list of users
                return mSaleItems;
            }
            //setter accepts data from other objects
            set
            {
                //assign the incoming value to the private data member
                mSaleItems = value;
            }
        }

        //public properties
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

        public decimal ThisSale
        {
            get
            {
                return thisSale;
            }
            set
            {
                thisSale = value;
            }
        }

        public List<clsSaleItem> AllSales { get; set; }

        public void FindAllSaleItems()
        {
            //re-set the connection
            myDB = new clsDataConnection();
            //var to store the index
            Int32 Index = 0;
            //var to store the user number of the current record
            Int32 ItemID;
            //var to flag that user was found
            Boolean SaleItemFound;
            //execute the stored procedure
            myDB.Execute("sproc_tblSaleItem_SelectAll");
            //get the count of records
            recordCount = myDB.Count;
            //while there are still records to process
            while (Index < myDB.Count)
            {
                //create an instance of the user class
                clsSaleItem NewSaleItem = new clsSaleItem();
                //get the user number from the database
                ItemID = Convert.ToInt32(myDB.DataTable.Rows[Index]["ItemID"]);
                //find the user by invoking the find method
                SaleItemFound = NewSaleItem.Find(ItemID);
                if (SaleItemFound == true)
                {
                    //add the user to the list
                    mSaleItems.Add(NewSaleItem);
                }
                //increment the index
                Index++;
            }
        }


    }
}
