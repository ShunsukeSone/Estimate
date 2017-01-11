using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Estimate.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CONFIRM(FormCollection _FormCollction)
        {
            return View();

        }

        public ActionResult COMPLETE()
        {
            return View();
        }

    }
}