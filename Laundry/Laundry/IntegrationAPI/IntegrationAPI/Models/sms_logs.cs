using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntegrationAPI.Models
{
    public class sms_logs
    {
        ///<summary>
        ///smslogs
        /// </summary>
        ///  
        public Int32 SmsLogID { get; set; }
        public Int32 UserID { get; set; }
        public Int32 InstanceID { get; set; }
        public Int32 CustomerID { get; set; }
        public Int32 SmsID { get; set; }
        public string TemplateName { get; set; }
        public string CountryCode { get; set; }
        public string FromNumber { get; set; }
        public string ToNumber { get; set; }
        public string Details { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }
       
    }
}