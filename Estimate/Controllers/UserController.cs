using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Estimate.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CONFIRM(FormCollection _FormCollection)
        {
            return View();

        }

        public ActionResult COMPLETE()
        {
            return View();
        }
    }
}