using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarPaymentsLibrary;

namespace CarPaymentsTesting
{
    [TestClass]
    public class tstPayments
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of our class clsPayments
            clsPayments Payments = new clsPayments();
            //check to see that the class is not null
            Assert.IsNotNull(Payments);
        }
    }
}
