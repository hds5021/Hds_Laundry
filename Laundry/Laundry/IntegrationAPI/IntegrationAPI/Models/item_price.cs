using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntegrationAPI.Models
{
    public class item_price
    {
        public Int32 ItemPriceID { get; set; }
        public Int32 ItemID { get; set; }
        public Int32 GroupID { get; set; }
        public decimal Price { get; set; }
    }
}