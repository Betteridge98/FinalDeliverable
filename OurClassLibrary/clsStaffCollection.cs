using System.Collections.Generic;
using System;

namespace OurClassLibrary
{
    public class clsStaffCollection
    {
        //private data member that stores the counts of records found
        private Int32 recordCount;
        //private data member to connect to the database
        private clsDataConnection myDB = new clsDataConnection();
        //private data member for the Staff list
        private List<clsStaff> mStaffList = new List<clsStaff>();
        //public property for count
        public int Count
        {
            get
            {
                //return the count property of the private list
                return mStaffList.Count;
            }
            set
            {

            }
        }

        //public property for Staff
        public List<clsStaff> StaffList
        {
            //getter sends data to requesting code
            get
            {
                //return the private data member
                return mStaffList;
            }
            //setter accepts data from other objects
            set
            {
                //assign the incoming value to the private data member
                mStaffList = value;
            }
        }

        public void FindAllStaff()
        {
            //re-set the data connection
            myDB = new clsDataConnection();
            //var to store the index
            Int32 Index = 0;
            //var to store the staff no of the current record
            Int32 StaffNo;
            //var to flag the staff member was found
            Boolean StaffFound;
            //execute the stored procedure
            myDB.Execute("sproc_tblStaff_SelectAll");
            //get the count of records
            recordCount = myDB.Count;
            //while there are still records to process
            while (Index < myDB.Count)
            {
                //create an instance of the staff class
                clsStaff NewStaff = new clsStaff();
                //get the staff member from the database
                StaffNo = Convert.ToInt32(myDB.DataTable.Rows[Index]["StaffNo"]);
                //find the staff member by invoking the find method
                StaffFound = NewStaff.Find(StaffNo);
                if (StaffFound == true)
                {
                    //add the staff member to the list
                    mStaffList.Add(NewStaff);
                }
                //increment the index
                Index++;
            }
        }

        //public contstructor for the class
        public clsStaffCollection()
        {
            //create an instance of the dataconnection 
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure to get the list of data
            DB.Execute("sproc_tblStaff_SelectAll");
            //get the count of records
            Int32 RecordCount = DB.Count;
            //set up the index for the loop
            Int32 Index = 0;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create an instance of the staff class to store a staff member
                clsStaff AStaff = new clsStaff();
                //set the staff member to Sam
                AStaff.FirstName = DB.DataTable.Rows[Index]["FirstName"].ToString();
                //get the primary key
                AStaff.StaffNo = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffNo"]);
                //add the second county to the private list of staff members
                mStaffList.Add(AStaff);
                //increment the index
                Index++;
            }
            
            //the private list now contains two staff members
        }
    }
}