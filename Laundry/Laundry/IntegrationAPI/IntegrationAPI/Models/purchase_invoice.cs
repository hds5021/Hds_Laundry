using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntegrationAPI.Models
{
    public class purchase_invoice
    {
        public Int32 InvoiceID { get; set; }
        public Int32 InstanceID { get; set; }
        public Int32 UserID { get; set; }
        public Int32 OfficeBranchID { get; set; }
        public string BranchName { get; set; }
        public Int32 SupplierID { get; set; }
        public string Contact { get; set; }
        public Int32 TotalQuantity { get; set; }
        public decimal TotalAmount { get; set; }
        public string Type { get; set; }
        public string Narration { get; set; }
        public string QuotationNo { get; set; }
        public DateTime QuotationDate { get; set; }
        public string ReferenceNo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public Int32 IsDeleted { get; set; }
        public DateTime DeletedDateTime { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}