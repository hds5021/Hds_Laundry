using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntegrationAPI.Models
{
    public class PageMaster
    {
        public Int32 Pageid { get; set; }
        public string PageName { get; set; }
        public string PageDesc { get; set; }
        public Int32 Moduleid { get; set; }
        public string Status { get; set; }
    }
}