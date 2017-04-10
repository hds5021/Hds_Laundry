using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntegrationAPI.Models
{
    public class instances
    {
        public Int32 InstanceID { get; set; }
        public string InstanceName { get; set; }
        public string Telephone { get; set; }
        public string MobileNo { get; set; }
        public string Version { get; set; }
        public string Logo { get; set; }
        public DateTime LastUpdateDateTime { get; set; }
        public DateTime LastBackupDate { get; set; }
        public DateTime LastRestoreDate { get; set; }
        public DateTime LastRestoreUpto { get; set; }
        public DateTime LastResetDate { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}