using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace OurClassLibrary
{
    public class clsStockCollection
    {
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
                AStock.ItemNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["ItemNo"]);
                //add the item the the private data member
                mAllStock.Add(AStock);
                //increment the index
                Index++;
            }
        }
        
               


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