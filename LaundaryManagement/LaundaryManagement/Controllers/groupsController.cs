using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LaundaryManagement.Controllers
{
    public class groupsController : ApiController
    {
        public IEnumerable<clsgroups> GetgroupsDetail()
        {
            return new List<clsgroups>
            {
                new clsgroups{GroupID=1,GroupName="Arun",GroupCode="9th Street",ColorCode="Erode"},
                new clsgroups{GroupID=2,GroupName="Mohan",GroupCode="Main Road",ColorCode="Namakkal"},
                new clsgroups{GroupID=3,GroupName="Prapbu",GroupCode="SKV Street",ColorCode="Salem"},
            };
        }
    }
}
