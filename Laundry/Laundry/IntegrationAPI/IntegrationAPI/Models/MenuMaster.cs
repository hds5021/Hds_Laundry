using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntegrationAPI.Models
{
    public class MenuMaster
    {
        public Int32 Menuid { get; set; }
        public string MenuName { get; set; }
        public string MenuDesc { get; set; }
        public string Status { get; set; }
    }
}