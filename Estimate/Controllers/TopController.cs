using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Estimate.Controllers
{
    public class TopController : Controller
    {
        // GET: Top
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult User(FormCollection _FormCollection)
        {
            return RedirectToAction("Index", "User");
        }

        public ActionResult Estimate(FormCollection _FormCollection)
        {
            return RedirectToAction("Index", "Estimate");
        }

        public ActionResult Supplier(FormCollection _FormCollection)
        {
            return RedirectToAction("Index", "Supplier");
        }

        public ActionResult Order(FormCollection _FormCollection)
        {
            return RedirectToAction("Index", "Order");
        }

        public ActionResult Product(FormCollection _FormCollection)
        {
            return RedirectToAction("Index", "Product");   
        }

        public ActionResult Customer(FormCollection _FormCollection)
        {
            return RedirectToAction("Index", "Customer");
        }
    }
}