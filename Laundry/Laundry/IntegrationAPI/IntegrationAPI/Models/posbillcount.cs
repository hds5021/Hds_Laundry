using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntegrationAPI.Models
{
    public class posbillcount
    {
        public Int32 PosBillCountID { get; set; }
        public Int32 InstanceID { get; set; }
        public Int32 TotalBills { get; set; }
        public DateTime BillDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}