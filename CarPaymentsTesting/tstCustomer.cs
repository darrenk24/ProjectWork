using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarPaymentsLibrary;

namespace CarPaymentsTesting
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {

            //create an instance of the class to create
            clsCustomer ACustomer = new clsCustomer();
            //test to see what exists here
            Assert.IsNotNull(ACustomer);
        }
        [TestMethod]
        public void Customer_No()
        {

            //create an instance of the class to create
            clsCustomer ACustomer = new clsCustomer();
            //Creating test data to assign 
            Int32 TestData = 5;
            //assign the data
            ACustomer.Customer_No = TestData;
            //test to see if values are the same
            Assert.AreEqual(ACustomer.Customer_No, TestData);
        }

        [TestMethod]
        public void Customer_NameOK()

        {
            //create an instance of the class to create
            clsCustomer ACustomer = new clsCustomer();
            //Creating test data to assign 
            String TestData = "John";
            //test to see if values are the same
            Assert.AreEqual(ACustomer.Customer_Name, TestData);
        }
    }
}
