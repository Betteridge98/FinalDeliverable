using System;
using System.Collections.Generic;


namespace OurClassLibrary
{
    public class clsStockCollection
    {
        //private data member that stores the counts of records found
        private Int32 recordCount;
        //private data member to connect to the database
        private clsDataConnection myDB = new clsDataConnection();
        //private data member for the Staff list
        private List<clsStock> mStockList = new List<clsStock>();          
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

        //public constructor for the class.
        public clsStockCollection()
        {
            //create an instance of the dataconnection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure to get our list of data
            DB.Execute("sproc_tblStock_SelectAll");
            //get the count of records
            Int32 RecordCount = DB.Count;
            //set up the index for the loop 
            Int32 Index = 0;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a new intance of the stock class
                clsStock AStock = new clsStock();
                //get the item name
                AStock.ItemName = DB.DataTable.Rows[Index]["ItemName"].ToString();
                //get the primary key
                AStock.ItemNo = Convert.ToInt32(DB.DataTable.Rows[Index]["ItemNo"]);
                //add the item the the private data member
                mAllStock.Add(AStock);
                //increment the index
                Index++;
            }
        }

        public void FindAllStock()
        {
            //re-set the data connection
            myDB = new clsDataConnection();
            //var to store the index
            Int32 Index = 0;
            //var to store the stockno of the current record
            Int32 ItemNo;
            //var to flag the stockwas found
            Boolean StockFound;
            //execute the stored procedure
            myDB.Execute("sproc_tblStock_SelectAll");
            //get the count of records
            recordCount = myDB.Count;
            //while there are still records to process
            while (Index < myDB.Count)
            {
                //create an instance of the stock class
                clsStock NewStock = new clsStock();
                //get the stock from the database
                ItemNo = Convert.ToInt32(myDB.DataTable.Rows[Index]["ItemNo"]);
                //find the stock by invoking the find method
                StockFound = NewStock.Find(ItemNo);
                if (StockFound == true)
                {
                    //add the stock to the list
                    mStockList.Add(NewStock);
                }
                //increment the index
                Index++;
            }
        }


    }
}