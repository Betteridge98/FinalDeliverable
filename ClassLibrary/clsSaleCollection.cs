using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    

    public class clsSaleCollection
    {
        //private data member that stores the count of records found
        private Int32 recordCount;
        //create a private list data member to store the data from the database
        private List<clsSaleItem> saleItemList = new List<clsSaleItem>();
        //private data member to connect to the database
        private clsDataConnection myDB = new clsDataConnection();

        //public property returning the count of records
        public Int32 Count
        {
            get
            {
                //return record count;
                return recordCount;
            }
        }

        //public list of users
        public List<clsSaleItem> SaleItems
        {
            //getter for the property
            get
            {
                //return the list of users
                return saleItemList;
            }
        }

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
                    saleItemList.Add(NewSaleItem);
                }
                //increment the index
                Index++;
            }
        }
    }
}
