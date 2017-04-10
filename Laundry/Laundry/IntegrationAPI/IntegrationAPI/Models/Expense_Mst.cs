using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntegrationAPI.Models
{
    public class Expense_Mst
    {
        public Int32 ExpenseItemID { get; set; }
        public Int32 InstanceID { get; set; }
        public string ItemName { get; set; }
        public Int32 Status { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}