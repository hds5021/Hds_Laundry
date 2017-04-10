using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntegrationAPI.Models
{
    public class EmployeeMaster
    {
        public Int32 Empid { get; set; }
        public string EmpName { get; set; }
        public string EmpAdd { get; set; }
        public string EmpMobile { get; set; }
        public string EmpPhoneno { get; set; }
        public string EmpemailId { get; set; }
        public string IsRetired { get; set; }
        public string IsDeleted { get; set; }
        public string Status { get; set; }
    }
}