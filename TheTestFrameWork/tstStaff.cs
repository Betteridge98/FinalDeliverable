using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OurClassLibrary;

namespace TheTestFrameWork
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //test to see if that exists
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void FirstnameOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign the propert
            string SomeFirstName = "Sam";
            //assign the data to the property
            AStaff.FirstName = SomeFirstName;
            //test to see if the first two values are the same
            Assert.AreEqual(AStaff.FirstName, SomeFirstName);
        }

        [TestMethod]
        public void LastNameOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string SomeLastName = "Betteridge";
            //assign the data to the property
            AStaff.LastName = SomeLastName;
            // test to see if the first two values are the same 
            Assert.AreEqual(AStaff.LastName, SomeLastName);
        }

        [TestMethod]
        public void EmailOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string SomeEmail = "abcde@gmail.com";
            //assign the data to the property
            AStaff.Email = SomeEmail;
            //test to see if the first two values are the same
            Assert.AreEqual(AStaff.Email, SomeEmail);
        }

        [TestMethod]
        public void PhoneNoOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 PhoneNo = 1;
            //assign the data to the property
            AStaff.PhoneNo = PhoneNo;
            //test to see that the two values are the same 
            Assert.AreEqual(AStaff.PhoneNo, PhoneNo);
        }

        [TestMethod]
        public void StaffNoOK()
        {
            //creat an instance of the class we want to create 
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 StaffNo = 1;
            //assign the data to the property
            AStaff.StaffNo = StaffNo;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffNo, StaffNo);
        }
    }
}
