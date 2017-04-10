using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LaundaryManagement.Models
{
    public class GroupMasterModel
    {
        public Int32 GroupID { get; set; }
        public Int32 InstanceID { get; set; }
        public Int32 UserID { get; set; }
        public string GroupName { get; set; }
        public string GroupCode { get; set; }
        public string ColorCode { get; set; }
        public Int32 Status { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}