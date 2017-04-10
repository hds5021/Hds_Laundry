using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntegrationAPI.Models
{
    public class UserMaster
    {
        ///<summary>
        ///UserMaster
        /// </summary>
      
        public Int32 Userid { get; set; }
        public string Umusername { get; set; }
        public string Umpassword { get; set; }
        public Int32 Empid { get; set; }
        public Int32 Rollid { get; set; }
        public string RollLocation { get; set; }
        public DateTime CreateDateTime { get; set; }
        public bool IsRetired { get; set; }
        public bool IsDeleted { get; set; }
        public string InsertedBy { get; set; }
        public string CreatedBy { get; set; }
        public string DeleteBy { get; set; }
        public string ViewedBy { get; set; }
        public string Status { get; set; }
    }
}