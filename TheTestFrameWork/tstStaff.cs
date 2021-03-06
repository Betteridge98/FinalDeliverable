﻿using System;
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
            string PhoneNo = "1";
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

        [TestMethod]
        public void ValidFirstNameOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean FirstNameOK = false;
            //create some test data to assign to the property
            string SomeFirstName = "Sam";
            //invoke the method
            FirstNameOK = AStaff.Valid(SomeFirstName);
            //test to see if the result is correct
            Assert.IsTrue(FirstNameOK);
        }

        [TestMethod]

        public void ValidLastNameOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean LastNameOK = false;
            //create some test data to assign to the property
            string SomeLastName = "Betteridge";
            //invoke the method
            LastNameOK = AStaff.LastNameValid(SomeLastName);
            //test to see if the result is correct
            Assert.IsTrue(LastNameOK);
        }

        [TestMethod]

        public void ValidEmailOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean EmailOK = false;
            //create some test data to assign to the property
            string SomeEmail = "abcde@gmail.com";
            //invoke the method
            EmailOK = AStaff.EmailValid(SomeEmail);
            //test to see if the result is correct
            Assert.IsTrue(EmailOK);
        }

        [TestMethod]

        public void ValidPhoneNoOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean PhoneNoOK = false;
            //create some test data to assign to the property
            String SomePhoneNo = "1";
            //invoke the method
            PhoneNoOK = AStaff.PhoneNoValid(SomePhoneNo);
            //test to see if the result is correct
            Assert.IsTrue(PhoneNoOK);
        }

        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //create an instance of the class we want to create 
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean FirstNameOK = false;
            //create some test data to assign the property
            string SomeFirstName = "";
            //invoke the method 
            FirstNameOK = AStaff.Valid(SomeFirstName);
            //test to see if the result is correct 
            Assert.IsFalse(FirstNameOK);
        }

        [TestMethod]
        public void FirstNameBoundary()
        {
            //create an instance of the class we want to create 
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean FirstNameOK = false;
            //create some test data to assign the property
            string SomeFirstName = "a";
            //invoke the method 
            FirstNameOK = AStaff.Valid(SomeFirstName);
            //test to see if the result is correct 
            Assert.IsTrue(FirstNameOK);
        }

        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean FirstNameOK = false;
            //create some test data to assign the property
            string SomeFirstName = "aa";
            //invoke the method 
            FirstNameOK = AStaff.Valid(SomeFirstName);
            //test to see if the result is correct 
            Assert.IsTrue(FirstNameOK);
        }

        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean FirstNameOK = false;
            //create some test data to assign the property
            string SomeFirstName = "asdrgftrecgtbhnimkh";
            //invoke the method 
            FirstNameOK = AStaff.Valid(SomeFirstName);
            //test to see if the result is correct 
            Assert.IsTrue(FirstNameOK);
        }

        [TestMethod]
        public void FirstNameMaxBoundary()
        {
            //create an instance of the class we want to create 
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean FirstNameOK = false;
            //create some test data to assign the property
            string SomeFirstName = "adcbgtfsdbcthgybjkli";
            //invoke the method 
            FirstNameOK = AStaff.Valid(SomeFirstName);
            //test to see if the result is correct 
            Assert.IsTrue(FirstNameOK);
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean FirstNameOK = false;
            //create some test data to assign the property
            string SomeFirstName = "asbhytvhnihujkloiyuth";
            //invoke the method 
            FirstNameOK = AStaff.Valid(SomeFirstName);
            //test to see if the result is correct 
            Assert.IsFalse(FirstNameOK);
        }

        [TestMethod]
        public void FirstNameMid()
        {
            //create an instance of the class we want to create 
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean FirstNameOK = false;
            //create some test data to assign the property
            string SomeFirstName = "anhthyhjuk";
            //invoke the method 
            FirstNameOK = AStaff.Valid(SomeFirstName);
            //test to see if the result is correct 
            Assert.IsTrue(FirstNameOK);
        }

        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean FirstNameOK = false;
            //create some test data to assign to the property
            string SomeFirstName = "";
            //pad the string with characters
            SomeFirstName = SomeFirstName.PadRight(300, 'a');
            //invoke the method
            FirstNameOK = AStaff.Valid(SomeFirstName);
            //test to see if that result is correct
            Assert.IsFalse(FirstNameOK);
        }

        [TestMethod]
        public void LastNameMinLessOne()
        {
            //create an instance of the class we want to create 
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean LastNameOK = false;
            //create some test data to assign the property
            string SomeLastName = "";
            //invoke the method 
            LastNameOK = AStaff.LastNameValid(SomeLastName);
            //test to see if the result is correct 
            Assert.IsFalse(LastNameOK);
        }

        [TestMethod]
        public void LastNameBoundary()
        {
            //create an instance of the class we want to create 
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean LastNameOK = false;
            //create some test data to assign the property
            string SomeLastName = "a";
            //invoke the method 
            LastNameOK = AStaff.LastNameValid(SomeLastName);
            //test to see if the result is correct 
            Assert.IsTrue(LastNameOK);
        }

        [TestMethod]
        public void LastNameMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean LastNameOK = false;
            //create some test data to assign the property
            string SomeLastName = "aa";
            //invoke the method 
            LastNameOK = AStaff.LastNameValid(SomeLastName);
            //test to see if the result is correct 
            Assert.IsTrue(LastNameOK);
        }

        [TestMethod]
        public void LastNameMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean LastNameOK = false;
            //create some test data to assign the property
            string SomeLastName = "asdrgftrecgtbhnimkh";
            //invoke the method 
            LastNameOK = AStaff.LastNameValid(SomeLastName);
            //test to see if the result is correct 
            Assert.IsTrue(LastNameOK);
        }

        [TestMethod]
        public void LastNameMaxBoundary()
        {
            //create an instance of the class we want to create 
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean LastNameOK = false;
            //create some test data to assign the property
            string SomeLastName = "adcbgtfsdbcthgybjkli";
            //invoke the method 
            LastNameOK = AStaff.LastNameValid(SomeLastName);
            //test to see if the result is correct 
            Assert.IsTrue(LastNameOK);
        }

        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean LastNameOK = false;
            //create some test data to assign the property
            string SomeLastName = "asbhytvhnihujkloiyuth";
            //invoke the method 
            LastNameOK = AStaff.LastNameValid(SomeLastName);
            //test to see if the result is correct 
            Assert.IsFalse(LastNameOK);
        }

        [TestMethod]
        public void LastNameMid()
        {
            //create an instance of the class we want to create 
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean LastNameOK = false;
            //create some test data to assign the property
            string SomeLastName = "anhthyhjuk";
            //invoke the method 
            LastNameOK = AStaff.LastNameValid(SomeLastName);
            //test to see if the result is correct 
            Assert.IsTrue(LastNameOK);
        }

        [TestMethod]
        public void LastNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean LastNameOK = false;
            //create some test data to assign to the property
            string SomeLastName = "";
            //pad the string with characters
            SomeLastName = SomeLastName.PadRight(300, 'a');
            //invoke the method
            LastNameOK = AStaff.LastNameValid(SomeLastName);
            //test to see if that result is correct
            Assert.IsFalse(LastNameOK);
        }

        [TestMethod]
        public void EmailMinLessOne()
        {
            //create an instance of the class we want to create 
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean EmailOK = false;
            //create some test data to assign the property
            string SomeEmail = "";
            //invoke the method 
            EmailOK = AStaff.EmailValid(SomeEmail);
            //test to see if the result is correct 
            Assert.IsFalse(EmailOK);
        }


        [TestMethod]
        public void EmailBoundary()
        {
            //create an instance of the class we want to create 
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean EmailOK = false;
            //create some test data to assign the property
            string SomeEmail = "a";
            //invoke the method 
            EmailOK = AStaff.EmailValid(SomeEmail);
            //test to see if the result is correct 
            Assert.IsTrue(EmailOK);
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean EmailOK = false;
            //create some test data to assign the property
            string SomeEmail = "aa";
            //invoke the method 
            EmailOK = AStaff.EmailValid(SomeEmail);
            //test to see if the result is correct 
            Assert.IsTrue(EmailOK);
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean EmailOK = false;
            //create some test data to assign the property
            string SomeEmail = "asghnchyghbhnchjkloithgfdtsuchnjuhytgst";
            //invoke the method 
            EmailOK = AStaff.EmailValid(SomeEmail);
            //test to see if the result is correct 
            Assert.IsTrue(EmailOK);
        }

        [TestMethod]
        public void EmailMaxBoundary()
        {
            //create an instance of the class we want to create 
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean EmailOK = false;
            //create some test data to assign the property
            string SomeEmail = "asghnchyghbhnchjkloithgfdtsuchnjuhytgstg";
            //invoke the method 
            EmailOK = AStaff.EmailValid(SomeEmail);
            //test to see if the result is correct 
            Assert.IsTrue(EmailOK);
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean EmailOK = false;
            //create some test data to assign the property
            string SomeEmail = "asghnchyghbhnchjkloithgfdtsuchnjuhytgstgg";
            //invoke the method 
            EmailOK = AStaff.EmailValid(SomeEmail);
            //test to see if the result is correct 
            Assert.IsFalse(EmailOK);
        }

        [TestMethod]
        public void EmailMid()
        {
            //create an instance of the class we want to create 
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean EmailOK = false;
            //create some test data to assign the property
            string SomeEmail = "ahsytghdnvjkiuthjghy";
            //invoke the method 
            EmailOK = AStaff.EmailValid(SomeEmail);
            //test to see if the result is correct 
            Assert.IsTrue(EmailOK);
        }

        [TestMethod]
        public void EmailExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean EmailOK = false;
            //create some test data to assign to the property
            string SomeEmail = "";
            //pad the string with characters
            SomeEmail = SomeEmail.PadRight(300, 'a');
            //invoke the method
            EmailOK = AStaff.LastNameValid(SomeEmail);
            //test to see if that result is correct
            Assert.IsFalse(EmailOK);
        }

        [TestMethod]
        public void PhoneNoMinLessOne()
        {
            //create an instance of the class we want to create 
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean PhoneNoOK = false;
            //create some test data to assign the property
            string SomePhoneNo = "";
            //invoke the method 
            PhoneNoOK = AStaff.PhoneNoValid(SomePhoneNo);
            //test to see if the result is correct 
            Assert.IsFalse(PhoneNoOK);
        }

        [TestMethod]
        public void PhoneNoBoundary()
        {
            //create an instance of the class we want to create 
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean PhoneNoOK = false;
            //create some test data to assign the property
            string SomePhoneNo = "1";
            //invoke the method 
            PhoneNoOK = AStaff.PhoneNoValid(SomePhoneNo);
            //test to see if the result is correct 
            Assert.IsTrue(PhoneNoOK);
        }

        [TestMethod]
        public void PhoneNoMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean PhoneNoOK = false;
            //create some test data to assign the property
            string SomePhoneNo = "12";
            //invoke the method 
            PhoneNoOK = AStaff.PhoneNoValid(SomePhoneNo);
            //test to see if the result is correct 
            Assert.IsTrue(PhoneNoOK);
        }

        [TestMethod]
        public void PhoneNoMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean PhoneNoOK = false;
            //create some test data to assign the property
            string SomePhoneNo = "1234567891234";
            //invoke the method 
            PhoneNoOK = AStaff.PhoneNoValid(SomePhoneNo);
            //test to see if the result is correct 
            Assert.IsTrue(PhoneNoOK);
        }

        [TestMethod]
        public void PhoneNoMaxBoundary()
        {
            //create an instance of the class we want to create 
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean PhoneNoOK = false;
            //create some test data to assign the property
            string SomePhoneNo = "12345678912345";
            //invoke the method 
            PhoneNoOK = AStaff.EmailValid(SomePhoneNo);
            //test to see if the result is correct 
            Assert.IsTrue(PhoneNoOK);
        }

        [TestMethod]
        public void PhoneNoMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean PhoneNoOK = false;
            //create some test data to assign the property
            string SomePhoneNo = "123456789123456";
            //invoke the method 
            PhoneNoOK = AStaff.PhoneNoValid(SomePhoneNo);
            //test to see if the result is correct 
            Assert.IsFalse(PhoneNoOK);
        }

        [TestMethod]
        public void PhoneNoMid()
        {
            //create an instance of the class we want to create 
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean PhoneNoOK = false;
            //create some test data to assign the property
            string SomePhoneNo = "1234567";
            //invoke the method 
            PhoneNoOK = AStaff.PhoneNoValid(SomePhoneNo);
            //test to see if the result is correct 
            Assert.IsTrue(PhoneNoOK);
        }

        [TestMethod]
        public void PhoneNoExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean PhoneNoOK = false;
            //create some test data to assign to the property
            string SomePhoneNo = "";
            //pad the string with characters
            SomePhoneNo = SomePhoneNo.PadRight(300, '1');
            //invoke the method
            PhoneNoOK = AStaff.LastNameValid(SomePhoneNo);
            //test to see if that result is correct
            Assert.IsFalse(PhoneNoOK);
        }
    }
}
