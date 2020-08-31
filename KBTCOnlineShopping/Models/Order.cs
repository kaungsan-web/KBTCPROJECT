using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KBTCOnlineShopping.Models
{
    public class Order
    {
        public long Id { get; set; }
        public string OrderedBy { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmt { get; set; }
        public string OrderNumber { get; set; }
        
    }
}
