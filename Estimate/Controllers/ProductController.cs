using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Estimate.Models;
using System.Configuration;

namespace Estimate.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Search(FormCollection _FormCollction)
        {
            string ConnectString = ConfigurationManager.ConnectionStrings["EstimateConnectionString"].ConnectionString;
            using (var db = new DataClasses1DataContext(ConnectString))
            {
                ProductResult _ = new ProductResult();
                try
                {
                    var _result = db.M商品.First(x => x.JANCD == _FormCollction["Code"]);

                    _ = new ProductResult()
                    {
                        Product_Name = _result.商品名,
                        Kana = _result.カタカナ名,
                        Maker_CD = _result.メーカーCD,
                        Supplier_CD = _result.仕入先CD,
                        Order_CD = _result.発注先CD,
                        RegistDay = _result.登録日時,
                        MAX_Kubun = (int)_result.最大区分,
                        MAX_Kikaku = _result.最大規格,
                        MAX_Tanni = _result.最大単位,
                        MAX_Keisu = (decimal)_result.最大係数,
                        MAX_Nyusu = (decimal)_result.最大入数,
                        MID_Kubun = (int)_result.中間区分, 
                        MID_Kikaku = _result.中間規格,
                        MID_Tanni =  _result.中間単位,
                        MID_Keisu = (decimal) _result.中間係数,
                        MID_Nyusu = (decimal) _result.中間入数,
                        MIN_Kubun = (int) _result.最小区分,
                        MIN_Kikaku = _result.最小規格,
                        MIN_Tanni = _result.最小単位,
                        MIN_Keisu = (decimal) _result.最小係数,
                        MIN_Nyusu = (decimal) _result.最小入数,
                        ExpirationDay = (decimal) _result.賞味期間,
                        Purchase_Tanka = (decimal) _result.仕入単価,
                        Change_Tanka = (decimal) _result.変更前単価,
                        SellDay = _result.販売期限日付,
                        ChangeDay = _result.単価変更日付,
                        Notes = _result.備考
                    };
                }
                catch { }
                return PartialView("Detail", _);
            }

        }

        //public ActionResult CONFIRM(FormCollection _FormCollction)
        //{
        //    return View();

        //}

        //public ActionResult COMPLETE()
        //{
        //    return View();
        //}

    }
}