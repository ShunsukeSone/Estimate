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

        public ActionResult MakeEstimate(FormCollection _FormCollection)
        {
            List<Estimates> _return = new List<Estimates>();
            List<Meisai> _Meisai = new List<Meisai>();
       
            char[] SP = new char[] { ',' };
            string[] _Name = _FormCollection["GetValue"].ToString().Split(SP);
            string[] _Suryo = _FormCollection["Suryo"].Split(SP);
            string[] _Tanka = _FormCollection["Tanka"].Split(SP);

            _Name.Select((v, i) => new { v, i }).ToList().ForEach(x =>
            {
                if (!string.IsNullOrEmpty(x.v))
                {
                    _Meisai.Add(new Meisai()
                    {
                        Name = x.v,
                        No = 0,
                        Seq = "",
                        Suryo = Convert.ToDecimal(_Suryo[x.i]),
                        Tanka = Convert.ToDecimal(_Tanka[x.i]),
                    });
                }
            });


            var abc = 1;

            //_Meisai.Add(new Meisai()
            //{
            //Name = _FormCollection["GetValue"].ToString().Split(SP),
            //Suryo = Convert.ToDecimal(_FormCollection["Suryo"].ToString().Split(SP)),
            //Tanka = Convert.ToDecimal(_FormCollection["Tanka"].ToString().Split(SP)) 
            //});

            _return.Add(new Estimates()
            {
                Estimate_No = _FormCollection["hiddenNo"],
                Estimate_Zip = _FormCollection["hiddenZip"],
                Estimate_Pref = _FormCollection["hiddenPref"],
                Estimate_City = _FormCollection["hiddenCity"],
                Estimate_Name = _FormCollection["hiddenName"],
                Meisai = _Meisai
            });

            return View();
        }

        private List<Company> SampleCompany()
        {
            List<Company> _return = new List<Company>()
            {
               new Company()
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