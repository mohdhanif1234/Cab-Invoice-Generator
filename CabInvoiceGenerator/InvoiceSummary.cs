using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class InvoiceSummary
    {
        public int noOfRides;
        public double totalFare;
        public double averageFare;

        public InvoiceSummary(int noOfRides, double totalFare)
        {
            this.noOfRides = noOfRides;
            this.totalFare = totalFare;
            this.averageFare = totalFare/noOfRides;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is InvoiceSummary))
            {
                return false;
            }
            InvoiceSummary inputObj = (InvoiceSummary)obj;
            return this.noOfRides == inputObj.noOfRides && this.totalFare == inputObj.totalFare && this.averageFare == inputObj.averageFare;
        }
    }
}
