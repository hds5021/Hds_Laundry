using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntegrationAPI.Models
{
    public class RollMaster
    {
        ///<summary>
        ///RollMaster
        /// </summary>
         public Int32 Rollid { get; set; }
        public string RollName { get; set; }
        public string RollDesc { get; set; }
        public string Status { get; set; }

    }
}