using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntegrationAPI.Models
{
    public class ModuleMaster
    {
        public Int32 Moduleid { get; set; }
        public string ModuleName { get; set; }
        public string ModuleDesc { get; set; }
        public string Status { get; set; }
    }
}