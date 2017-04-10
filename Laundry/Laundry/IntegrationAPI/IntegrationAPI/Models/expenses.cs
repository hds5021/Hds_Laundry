using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntegrationAPI.Models
{
    public class expenses
    {
        public Int32 ExpenseID { get; set; }
        public Int32 InstanceID { get; set; }
        public Int32 UserID { get; set; }
        public Int32 OfficeBranchID { get; set; }
        public Int32 ExpenseItemID { get; set; }
        public Int32 ItemId { get; set; }
        public decimal Amount { get; set; }
        public string Details { get; set; }
        public Int32 PaidBy { get; set; }
        public Int32 PartyId { get; set; }
        public DateTime BillDate { get; set; }
        public Int32 IsDeleted { get; set; }
        public DateTime DeletedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}