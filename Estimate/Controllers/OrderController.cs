using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Estimate.Models;
using System.Configuration;

namespace Estimate.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Search(FormCollection _FormCollection) {

            string ConnectString = ConfigurationManager.ConnectionStrings["EstimateConnectionString"].ConnectionString;
            using (var db = new DataClasses1DataContext(ConnectString))
            {
                M発注先 _ = new M発注先();
                try {
                    var _result = db.M発注先.First(x => x.発注先親CD == _FormCollection["Code"]);

                    _ = new M発注先()
                    {
                        発注先親CD = _result.発注先親CD,
                        発注先名1 = _result.発注先名1,
                        発注先名2 = _result.発注先名2,
                        発注先略称 = _result.発注先略称,
                        カタカナ名 = _result.カタカナ名,
                        郵便番号 = _result.郵便番号,
                        住所1 = _result.住所1,
                        住所2 = _result.住所2,
                        電話番号 = _result.電話番号,
                        FAX番号 = _result.FAX番号,
                        自動FAX番号 = _result.自動FAX番号,
                        備考 = _result.備考
                    };
                }
                catch { }
                return PartialView("Detail", _);

            }
        }
    }
}