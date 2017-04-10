using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntegrationAPI.Models
{
    public class sms_templates
    {
        ///<summary>
        ///smsTemplates
        /// </summary>
       
        public Int32 SmsID { get; set; }
        public Int32 InstanceID { get; set; }
        public Int32 UserID { get; set; }
        public string TemplateName { get; set; }
        public string Details { get; set; }
        public Int32 Ismart_sms_language { get; set; }
    }
}