using System;

namespace OurClassLibrary
{
    public class clsStaff
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNo { get; set; }
        public int StaffNo { get; set; }

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

        public bool PhoneNoValid(string somePhoneNo)
        {
            
        }
    }
}