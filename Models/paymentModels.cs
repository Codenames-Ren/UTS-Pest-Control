using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTS_Pest_Control.Models
{
    public class Payment
    {
        public int PaymentID { get; set; }
        public int ClientID { get; set; }
        public Client Client { get; set; }
        public int PackageID { get; set; }
        public Package Package { get; set; }
        public DateTime PaymentDate { get; set; } = DateTime.Now;
        public string PaymentMethod { get; set; }
        public decimal TotalAmount { get; set; }
        public string PaymentStatus { get; set; }
        public DateTime ServiceDate { get; set; }

    }
}
