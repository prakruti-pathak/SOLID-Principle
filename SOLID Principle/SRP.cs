    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principle
{
    //Single Responsibility Principle(SRP)
    //A class should have only one reason to change.
        public class Invoice
        {
            public void CalculateTotal()
            {
                // Logic to calculate the total amount
            }
        }

        public class InvoicePrinter
        {
            public void PrintInvoice(Invoice invoice)
            {
                // Logic to print the invoice
            }
        }

        public class InvoiceSaver
        {
            public void SaveToDatabase(Invoice invoice)
            {
                // Logic to save the invoice to a database
            }
        }

}
