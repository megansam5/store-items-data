using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentShopLibrary
{
    public class Vender
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Commission { get; set; }
        public decimal PaymentDue { get; set; }

        public string Display
        {
            get
            {
                return string.Format("{0} {1} - £{2}", FirstName, LastName, PaymentDue);
            }
        }
        public Vender()
        {
            Commission = 0.5;
        }
    }
}
