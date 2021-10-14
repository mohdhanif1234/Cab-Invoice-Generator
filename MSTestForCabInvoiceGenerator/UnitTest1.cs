using CabInvoiceGenerator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestForCabInvoiceGenerator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        // UC-1: Given total distance and time should calculate and return total fare (NORMAL) of the journey 
        [TestCategory("Fare")]
        public void GivenDistanceAndTimeShouldReturnNormalFare()
        {
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double distance = 2.0;
            int time = 5;
            //Calculating Fare
            double fare = invoiceGenerator.CalculateFare(distance, time);
            double expected = 25;
            Assert.AreEqual(expected, fare);
        }
        // UC-2: Calculate total fare for multiple rides
        //Given number of rides should return total invoice summery
        [TestMethod]
        [TestCategory("Fare")]
        public void GivenMultipleRidesShouldReturnInvoiceSummary()
        {
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.PREMIUM);
            Ride[] ride = { new Ride(2.0, 5), new Ride(0.1, 1) };
            InvoiceSummary actual = invoiceGenerator.CalculateFare(ride);
            InvoiceSummary expected = new InvoiceSummary(2, 60.0);
            Assert.AreEqual(expected, actual);
        }
    }
}
