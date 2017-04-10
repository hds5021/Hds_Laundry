using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntegrationAPI.Models
{
    /// <summary>
    /// Created : 30/08/2016
    /// Below class use for  Customer Details .This field return from SP_CustomerDetails
    /// </summary>
    public class Customer
    {
         public string CustomerNumber  { get; set; }
         public string CustomerName  { get; set; }
         public string BusinessType { get; set; }    
         public string Address1 { get; set; }
         public string Address2 { get; set; }
         public string City { get; set; }
         public string County { get; set; }
         public string Country { get; set; }
         public string Phone { get; set; }
         public string ContactPerson { get; set; }

    
    }
}