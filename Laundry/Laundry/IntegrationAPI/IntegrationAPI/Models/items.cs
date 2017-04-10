using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntegrationAPI.Models
{
    public class items
    {
        public Int32 ItemID { get; set; }
        public Int32 InstanceID { get; set; }
        public Int32 UserID { get; set; }
        public Int32 CustomerID { get; set; }
        public string ItemName { get; set; }
        public string ItemLocalName { get; set; }
        public string PriceRate { get; set; }
        public Int32 Status { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}