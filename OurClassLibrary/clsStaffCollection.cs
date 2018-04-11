using System.Collections.Generic;

namespace OurClassLibrary
{
    public class clsStaffCollection
    {
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
                //add the name to the private list of names
                mStaffList.Add(AStaff);
                //re initialise the AStaff object to accept a new item
                AStaff = new clsStaff();
                //set the name to Bob
                AStaff.FirstName = "Bob";
                //add the second county to the private list of staff members
                mStaffList.Add(AStaff);
            }
            
            //the private list now contains two staff members
        }
    }
}