using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntegrationAPI.Models
{
    public class PreSubMenu
    {
        public Int32 Presubmenuid { get; set; }
        public string PresubmenuName { get; set; }
        public string PresubmenuDesc { get; set; }
        public Int32 Menuid { get; set; }
        public Int32 Submenuid { get; set; }
        public string Status { get; set; }
    }
}