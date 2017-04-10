using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntegrationAPI.Models
{
    public class purchase_items_master
    {
        public Int32 PurchaseItemID { get; set; }
        public Int32 InstanceID { get; set; }
        public Int32 UserID { get; set; }
        public string ItemName { get; set; }
        public Int32 Status { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}