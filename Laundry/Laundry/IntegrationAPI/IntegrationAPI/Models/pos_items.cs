using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntegrationAPI.Models
{
    public class pos_items
    {
        public Int32 PosItemID { get; set; }
        public Int32 PosID { get; set; }
        public Int32 ItemID { get; set; }
        public Int32 GroupID { get; set; }
        public decimal ItemWidth { get; set; }
        public decimal ItemLength { get; set; }
        public string PriceRate { get; set; }
        public decimal Price { get; set; }
        public Int32 Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}