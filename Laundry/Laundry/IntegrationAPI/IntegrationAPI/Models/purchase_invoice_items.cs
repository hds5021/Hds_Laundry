using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntegrationAPI.Models
{
    public class purchase_invoice_items
    {
        public Int32 InvoiceItemID { get; set; }
        public Int32 InvoiceID { get; set; }
        public Int32 PurchaseItemID { get; set; }
        public Int32 Quantity { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
    }
}