using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LaundaryManagement.Controllers
{
    public class stmMyProfileController : Controller
    {
        // GET: stmMyProfile
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
    }
}