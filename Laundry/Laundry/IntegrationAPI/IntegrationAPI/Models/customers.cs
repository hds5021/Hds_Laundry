using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntegrationAPI.Models
{
    public class customers
    {

        /// <summary>
        /// Created : 21/02/2017
        /// Below class use for  Customer Details .This field return from SP_CustomerDetails
        /// </summary>
        public Int32 CustomerID
        {
            get;
            set;
        }


        public Int32 InstanceID
        {
            get;
            set;
        }


        public Int32 UserID
        {
            get;
            set;
        }


        public string CustomerName
        {
            get;
            set;
        }


        public string CivilNumber
        {
            get;
            set;
        }


        public string Email
        {
            get;
            set;
        }


        public string Address
        {
            get;
            set;
        }


        public decimal Balance
        {
            get;
            set;
        }


        public string Contact
        {
            get;
            set;
        }


        public Int32 Status
        {
            get;
            set;
        }


        public DateTime CreatedDate
        {
            get;
            set;
        }
    }
}