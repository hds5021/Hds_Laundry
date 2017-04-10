using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntegrationAPI.Models
{
    public class pos
    {
        public Int32 PosID { get; set; }
        public Int32 InstanceID { get; set; }
        public Int32 UserID { get; set; }
        public Int32 BillNo { get; set; }
        public Int32 CustomerID { get; set; }
        public Int32 CustomerBranchID { get; set; }
        public string Type { get; set; }
        public Int32 TotalQuantity { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalPayable { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal ReturnAmount { get; set; }
        public Int32 IsPaid { get; set; }
        public Int32 PaidBy { get; set; }
        public string PaymentDateTime { get; set; }
        public Int32 Status { get; set; }
        public string Comment { get; set; }
        public Int32 HangerQuantity { get; set; }
        public decimal HangerRate { get; set; }
        public decimal HangerAmount { get; set; }
        public string IsClothCollected { get; set; }
        public Int32 IsCarpetInvoice { get; set; }
        public DateTime BillDate { get; set; }
        public DateTime BillTime { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime DeliveryTime { get; set; }
        public Int32 IsDeleted { get; set; }
        public string DeletedDateTime { get; set; }
        public string CreatedDate { get; set; }
    }
}