using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntegrationAPI.Models
{
    public class UserRightsMaster
    {
        ///<summary>
        ///UserRightsMaster
        /// </summary>
       
        public Int32 Urid { get; set; }
        public Int32 Userid { get; set; }
        public Int32 Moduleid { get; set; }
        public Int32 Rollid { get; set; }
        public Int32 Pageid { get; set; }
        public Int32 Empid { get; set; }
        public bool IsDelete { get; set; }
        public bool IsView { get; set; }
        public bool IsEdit { get; set; }
        public bool IsSearch { get; set; }
        public bool IsAdd { get; set; }
        public bool IsReport { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ApplyDate { get; set; }
        public string CreatedBy { get; set; }
        public string Updatedby { get; set; }
        public string Deletedid { get; set; }
        public string Status { get; set; }
    }
}