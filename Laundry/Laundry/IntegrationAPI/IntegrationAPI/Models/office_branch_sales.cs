using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntegrationAPI.Models
{
    public class office_branch_sales
    {
        public Int32 BranchSalesID { get; set; }
        public Int32 InstanceID { get; set; }
        public Int32 UserID { get; set; }
        public Int32 OfficeBranchID { get; set; }
        public decimal Amount { get; set; }
        public DateTime BillDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}