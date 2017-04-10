﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntegrationAPI.Models
{
    public class Party
    {
        public Int32 PartyID { get; set; }
        public Int32 InstanceID { get; set; }
        public Int32 UserID { get; set; }
        public string PartyName { get; set; }
        public string CivilNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public Int32 Status { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}