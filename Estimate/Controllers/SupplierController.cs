using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Estimate.Models;
using System.Configuration;

namespace Estimate.Controllers
{
    public class SupplierController : Controller
    {
        // GET: Supplier
        public ActionResult Index()
        {
            ViewBag.Details = new SupplierResult();
            return View();
        }

        [HttpPost]
        public ActionResult Search(FormCollection _FormCollection)
        {
//            if ( Request.IsAjaxRequest( ))
//            {

            string ConnectString = ConfigurationManager.ConnectionStrings["EstimateConnectionString"].ConnectionString;
            using (var db = new DataClasses1DataContext(ConnectString))
            {
                SupplierResult _li = new SupplierResult();
                try
                {
                    var _result = db.M仕入先.First(x => x.仕入先親CD == _FormCollection["Code"]);

                    _li = new SupplierResult()
                    {
                        Name1 = _result.仕入先名1,
                        Name2 = _result.仕入先名2,
                        Ryakusyou = _result.仕入先略称,
                        Kana = _result.カタカナ名,
                        Zip = _result.郵便番号,
                        Address1 = _result.住所1,
                        Address2 = _result.住所2,
                        TEL = _result.電話番号,
                        FAX = _result.FAX番号,
                        Notes = _result.備考
                    };
                }
                catch { }

                return PartialView("Detail", _li);
            }

//            }
//            return new EmptyResult();
        }
    }
}