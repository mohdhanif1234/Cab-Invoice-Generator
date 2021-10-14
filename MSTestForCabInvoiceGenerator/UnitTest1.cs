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
        //Given number of rides should return total invoice summary
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
        // UC-3: Given multiple rides should show total no of rides, total fare, average fare per ride
        // UC-3: Given multiple rides should return average fare
        [TestMethod]
        public void ReturnAverageFare()
        {
            InvoiceGenerator invoice = new InvoiceGenerator(RideType.NORMAL);
            Ride[] rides = { new Ride(3.0, 5), new Ride(0.1, 1) };
            InvoiceSummary summary = new InvoiceSummary(2, 40.0);
            InvoiceSummary expected = invoice.CalculateFare(rides);
            Assert.AreEqual(expected.averageFare,summary.averageFare);
        }
        // UC:3- Given multiple rides should returns number of rides 
        [TestMethod]
        public void ReturnNumberofRides()
        {
            InvoiceGenerator invoice = new InvoiceGenerator(RideType.NORMAL);
            Ride[] rides = { new Ride(3.0, 5), new Ride(0.1, 1) };

            InvoiceSummary summary = new InvoiceSummary(2, 40.0);
            InvoiceSummary expected = invoice.CalculateFare(rides);
            Assert.AreEqual(expected.noOfRides, summary.noOfRides);
        }

        // UC-3: given multiple rides should returns Total fare
        [TestMethod]
        public void ReturnTotalFare()
        {
            InvoiceGenerator invoice = new InvoiceGenerator(RideType.NORMAL);
            Ride[] rides = { new Ride(3.0, 5), new Ride(0.1, 1) };

            InvoiceSummary summary = new InvoiceSummary(2, 40.0);
            InvoiceSummary expected = invoice.CalculateFare(rides);
            Assert.AreEqual(expected.totalFare, summary.totalFare);
        }
    }
}
