﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OurClassLibrary;
using System.Collections.Generic;

namespace TheTestFrameWork
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see if that exists
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 1;
            //assign the data to the property
            AllStaff.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, SomeCount);
        }

        [TestMethod]
        public void AllStaffOK()
        {
            //create an instance of the staff we want to create
            clsStaffCollection Staff = new clsStaffCollection();
            //create some test data to apply to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list 
            //creat the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.StaffNo = 1;
            TestItem.FirstName = "Sam";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            Staff.StaffList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(Staff.StaffList, TestList);
        }

        [TestMethod]
        public void  CountMatchesList()
        {
            //create an instance of the class we want to create
            clsStaffCollection Staff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data 
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.StaffNo = 1;
            TestItem.FirstName = "Sam";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            Staff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Staff.Count, TestList.Count);

        }

        //[TestMethod]
        //public void TwoStaffPresent()
        //{
        //    //create an instance of the class we want to create
        //    clsStaffCollection Staff = new clsStaffCollection();
        //    //test to see that the two values are the same
        //    Assert.AreEqual(Staff.Count, 2);
        //}
    }
}
