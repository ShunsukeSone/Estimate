using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Estimate.Models;

namespace Estimate.Controllers
{
    public class EstimateController : Controller
    {
        // GET: Estimate
        public ActionResult Index()
        {
            ViewBag.Datas = SampleData();
            ViewBag.Company = SampleCompany();
            return View();
        }

        private List<Estimates> SampleCompany()
        {
            List<Estimates> _return = new List<Estimates>()
            {
               new Estimates()
               {
                Comp_Zip = 5620004,
                Comp_Pref = "大阪府",
                Comp_City = "箕面市西小路4丁目",
                Comp_Address = "10番26-4号",
                Comp_Name = "有限会社アップルパイカンパニー",
                TEL = "072-747-8918",
                FAX = "072-747-8918"
               }
            };
            
            return _return;
        }

        private List<Meisai> SampleData()
        {
            List<Meisai> _return = new List<Meisai>();
            Enumerable.Range(0, 3).ToList().ForEach(x =>
            {
                _return.Add(new Meisai()
                {
                    Seq = (x + 1).ToString(),
                    No = (x + 1),
                    Name = string.Format("品名{0}", (x + 1)),
                });
            });

            return _return;
        }
    }
}