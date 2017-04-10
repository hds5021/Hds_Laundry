using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntegrationAPI.Models
{
    public class SubMenuMaster
    {
        ///<summary>
        ///SubMenuMaster
        /// </summary>
       
        public Int32 Submenuid { get; set; }
        public string SubmenuName { get; set; }
        public string SubmenuDesc { get; set; }
        public Int32 Menuid { get; set; }
        public string Status { get; set; }
    }
}