using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace OurClassLibrary
{


    public class clsSaleCollection
    {
        //not needed anymore
        //public clsSaleCollection()
        //{
        //    ////private data member for the list
        //    //List<clsSaleItem> mSaleItem = new List<clsSaleItem>();
        //    ////private data member thisSale
        //    //clsSaleItem mThisSale = new clsSaleItem();
        //    //create an instance of the data connection
        //    clsDataConnection DB = new clsDataConnection();
        //    //execute the stored procedure to get a list of data
        //    DB.Execute("sproc_tblSaleItem_SelectAll");
        //    //populate the array list with the data table
        //    //PopulateArray(DB);
        //    //get the count of records
        //    Int32 RecordCount = DB.Count;
        //    //set up the index for the loop
        //    Int32 Index = 0;
        //    //while there are records to process
        //    while (Index < RecordCount)
        //    {
        //        //create a new instance of the saleitem class
        //        clsSaleItem SaleItem = new clsSaleItem();
        //        //get the saleitem ItemID
        //        SaleItem.ItemID = Convert.ToInt32(DB.DataTable.Rows[Index]["ItemID"]);
        //        //add the saleitem to the private data member
        //        mSaleItems.Add(SaleItem);
        //        //increment the index
        //        Index++;
        //    }
        //}
        //private data member that stores the count of records found
        private Int32 recordCount;
        //create a private list data member to store the data from the database
        private List<clsSaleItem> mSaleItems = new List<clsSaleItem>();
        //private data members for the class
        private Int32 saleID;
        private clsSaleItem mThisSale;
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

        //public list of sale items
        public List<clsSaleItem> SaleItems
        {
            //getter sends data to requesting code
            get
            {
                //return the list of sale items
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

        public clsSaleItem ThisSale
        {
            get
            {
                return mThisSale;
            }
            set
            {
                mThisSale = value;
            }
        }

        public List<clsSaleItem> AllSales { get; set; }

        public void FindAllSaleItems()
        {
            //re-set the connection
            myDB = new clsDataConnection();
            //var to store the index
            Int32 Index = 0;
            //var to store the sale number of the current record
            Int32 ItemID;
            //var to flag that sale was found
            Boolean SaleItemFound;
            //execute the stored procedure
            myDB.Execute("sproc_tblSaleItem_SelectAll");
            //get the count of records
            recordCount = myDB.Count;
            //while there are still records to process
            while (Index < myDB.Count)
            {
                //create an instance of the sale class
                clsSaleItem NewSaleItem = new clsSaleItem();
                //get the ItemID from the database
                ItemID = Convert.ToInt32(myDB.DataTable.Rows[Index]["ItemID"]);
                //find the sale by invoking the find method
                SaleItemFound = NewSaleItem.Find(ItemID);
                if (SaleItemFound == true)
                {
                    //add the sale to the list
                    mSaleItems.Add(NewSaleItem);
                }
                //increment the index
                Index++;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisSale
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ItemID", mThisSale.ItemID);
            DB.AddParameter("@ItemPrice", mThisSale.ItemPrice);
            DB.AddParameter("@Quantity", mThisSale.Quantity);
            DB.AddParameter("@SaleID", mThisSale.SaleID);
            DB.AddParameter("@DateAdded", mThisSale.DateAdded);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblSaleItem_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisSale
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters of the stored procedure
            DB.AddParameter("@ItemID", mThisSale.ItemID);
            //execute the stored procedure
            DB.Execute("sproc_tblSaleItem_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of thisSale
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ItemID", mThisSale.ItemID);
            DB.AddParameter("@ItemPrice", mThisSale.ItemPrice);
            DB.AddParameter("@Quantity", mThisSale.Quantity);
            DB.AddParameter("@SaleID", mThisSale.SaleID);
            DB.AddParameter("@DateAdded", mThisSale.DateAdded);
            //execute the  stored procedure
            DB.Execute("sproc_tblSaleItem_Update");

        }

        public void FilterBySaleID(int SaleID)
        {
            //filters the records based on a SaleID
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the SaleID parameter to the database
            DB.AddParameter("@SaleID", SaleID);
            //execute the stored procedure
            DB.Execute("sproc_tblSaleItem_FilterBySaleID");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for thje index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mSaleItems = new List<clsSaleItem>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank sale
                clsSaleItem ASaleItem = new clsSaleItem();
                //read in the fields from the current record
                ASaleItem.ItemID = Convert.ToInt32(DB.DataTable.Rows[Index]["ItemID"]);
                ASaleItem.ItemPrice = Convert.ToDecimal(DB.DataTable.Rows[Index]["ItemPrice"]);
                ASaleItem.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                ASaleItem.SaleID = Convert.ToInt32(DB.DataTable.Rows[Index]["SaleID"]);
                ASaleItem.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                //add the record to the private data member
                mSaleItems.Add(ASaleItem);
                //point at the next record
                Index++;
            }
        }
    }
}
