using System;

namespace OurClassLibrary
{
    public class clsStaff
    {
        //private members for the class
        private Int32 staffNo;
        private string firstName;
        private string lastName;
        private string email;
        private string phoneNo;
        clsDataConnection myDB = new clsDataConnection();

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public string PhoneNo
        {
            get
            {
                return phoneNo;
            }
            set
            {
                phoneNo = value;
            }
        }
        public Int32 StaffNo
        {
            get
            {
                return staffNo;
            }
            set
            {
                staffNo = value;
            }
        }

        public bool Valid(string SomeFirstName)
        {
            //boolean flag to indicate that all is OK
            Boolean OK = true;
            //if first name is blank
            if (SomeFirstName == "")
            {
                //flag an error
                OK = false;
            }
            //if the first name is more than 20 characters
            if (SomeFirstName.Length > 20)
            {
                //flag an error
                OK = false;
            }
            return OK;
        }

        //find method
        public Boolean Find(Int32 StaffNo)
        {
            //re set the connection to the database
            myDB = new clsDataConnection();
            //pass the parameter to the stored procedure
            myDB.AddParameter("@StaffNo", StaffNo);
            //execute the stored procedure
            myDB.Execute("sproc_tblStaff_FilterByStaffNo");
            //check to see if it found anything
            if (myDB.Count == 1)
            {
                //set the private data members with the data from the database
                //private Int32 staffNo;
                staffNo = Convert.ToInt32(myDB.DataTable.Rows[0]["StaffNo"]);
                //private string firstName
                firstName = Convert.ToString(myDB.DataTable.Rows[0]["FirstName"]);
                //private string lastName
                lastName = Convert.ToString(myDB.DataTable.Rows[0]["LastName"]);
                //private string email
                email = Convert.ToString(myDB.DataTable.Rows[0]["Email"]);
                //private string phoneNo
                phoneNo = Convert.ToString(myDB.DataTable.Rows[0]["PhoneNo"]);
                //return success
                return true;
            }
            else //staff no was invalid
            {
                //return that there was a problem
                return false;
            }
        }
        public bool LastNameValid(string SomeLastName)
        {
            //boolean flag to indicate that all is OK
            Boolean OK = true;
            //if first name is blank
            if (SomeLastName == "")
            {
                //flag an error
                OK = false;
            }
            //if the first name is more than 20 characters
            if (SomeLastName.Length > 20)
            {
                //flag an error
                OK = false;
            }
            return OK;
        }

        public bool EmailValid(string SomeEmail)
        {
            //boolean flag to indicate that all is OK
            Boolean OK = true;
            //if first name is blank
            if (SomeEmail == "")
            {
                //flag an error
                OK = false;
            }
            //if the first name is more than 40 characters
            if (SomeEmail.Length > 40)
            {
                //flag an error
                OK = false;
            }
            return OK;
        }

        public bool PhoneNoValid(String SomePhoneNo)
        {
            //boolean flag to indicate that all is OK
            Boolean OK = true;
            //if first name is blank
            if (SomePhoneNo == "")
            {
                //flag an error
                OK = false;
            }
            //if the first name is more than 14 characters
            if (SomePhoneNo.Length > 14)
            {
                //flag an error
                OK = false;
            }
            return OK;
        }
    }
}