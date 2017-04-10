using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntegrationAPI.Models
{
    public class instance_settings
    {
        public Int32 InstanceID { get; set; }
        public string Tax1Name { get; set; }
        public decimal Tax1Value { get; set; }
        public string Tax2Name { get; set; }
        public decimal Tax2Value { get; set; }
        public string Tax3Name { get; set; }
        public decimal Tax3Value { get; set; }
        public Int32 BillNoReset { get; set; }
        public string EmailFrom { get; set; }
        public string Password { get; set; }
        public Int32 InstanceLogo { get; set; }
        public Int32 PosBillPrintLogo { get; set; }
        public string PosBillPrintHoliday { get; set; }
        public Int32 PosDeliveryDays { get; set; }
        public Int32 PosItemOrder { get; set; }
        public Int32 PosItemLocalNameDisplay { get; set; }
        public Int32 PosItemLocalNameBillPrint { get; set; }
        public string CountryCode { get; set; }
        public string MobileNo { get; set; }
        public string AccountSID { get; set; }
        public string AuthToken { get; set; }
        public decimal HangerRate { get; set; }
        public string MessageEndOfBill { get; set; }
        public string TnCEnglish { get; set; }
        public string TnCLocalLanguage { get; set; }
        public Int32 ItemwiseReportLocalLanguage { get; set; }
        public decimal MaxDiscountPercentage { get; set; }
    }
}