using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntegrationAPI.Services
{
    public class customers_branch
    {
        /// <summary>
        /// Created : 21/02/2017
        /// Below class use for  Customer Branch Details .This field return from SP_Customers_Branch
        /// </summary>
        /// 
        public Int32 CustomerBranchID { get; set; }
        public Int32 InstanceID { get; set; }
        public Int32 UserID { get; set; }
        public Int32 CustomerID { get; set; }
        public string BranchName { get; set; }
        public string CivilNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public string ContactPerson { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}