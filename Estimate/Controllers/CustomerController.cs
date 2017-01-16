using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Estimate.Models;
using System.Configuration;

namespace Estimate.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        //検索ボタンを押すとDBから必要な要素を持ってくる
        [HttpPost]
        public ActionResult Search(FormCollection _FormCollection)
        {
            string ConnectString = ConfigurationManager.ConnectionStrings["EstimateConnectionString"].ConnectionString;
            using (var db = new DataClasses1DataContext(ConnectString))
            {
                CustomerResult _ = new CustomerResult();

                try
                {
                    var _result = db.M得意先.First(x => x.得意先親CD == _FormCollection["Code"]);

                    _ = new CustomerResult()
                    {
                        CustemerName1 = _result.得意先名1,
                        CustemerName2 = _result.得意先名2,
                        Ryakusyou =_result.得意先略称,
                        Kana = _result.カタカナ名,
                        Zip = _result.郵便番号,
                        Address1 = _result.住所1,
                        Address2 = _result.住所2,
                        TEL = _result.電話番号,
                        FAX = _result.FAX番号,
                        Bill_CD = _result.請求先CD,
                        Bill_Name1 = _result.請求先名1,
                        Bill_Name2 = _result.請求先名2,
                        Bill_Zip = _result.請求先郵便番号,
                        Bill_Address1 = _result.請求先住所1,
                        Bill_Address2 = _result.請求先住所2,
                        Bill_TEL = _result.請求先電話番号,
                        Bill_FAX = _result.請求先FAX番号,
                        Bill_Close_Day1 = _result.請求締日1,
                        Money_Collect_Kubun1 = _result.集金区分1,
                        Money_Collect_Day1 = _result.集金日1,
                        Bill_Close_Day2 = _result.請求締日2,
                        Money_Collect_Kubun2 = _result.集金区分2,
                        Money_Collect_Day2 = _result.集金日2,
                        Bill_Kubun = (int) _result.請求書区分,
                        Bill_Kind = _result.請求書種別,
                        Tax_Kubun1 = (int) _result.消費税区分1,
                        Tax_Kubun2 = (int) _result.消費税区分2,
                        Tax_Kubun3 = (int) _result.消費税区分3,
                        Bad_Dabt_Kubun = (int) _result.不良債権区分,
                        Sales_Tantou_CD = _result.営業担当者CD,
                        Deve_Tantou_CD = _result.開設担当者CD,
                        Delivery_Line = _result.配送ライン,
                        Rank = _result.ランク,
                        Factory_Kubun = _result.工場区分,
                        Picking = (int) _result.ピッキング区分,
                        Delivery_kubun =_result.配達区分,
                        Express = _result.運送便区分,
                        Delivery_Day_Sign = _result.納品日数符号,
                        Delivery_Day = _result.納品日数,
                        Trade_Start_Day = _result.取引開始日付,
                        Latest_Sell_Day = _result.最新売上日付,
                        Total_Start_Day = _result.総額開始日付,
                        Margin = (decimal)_result.西村便手数料,
                        Notes = _result.備考
                    };
                }
                catch { }

                return PartialView("Detail", _);
            }             
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