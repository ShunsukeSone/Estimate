using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Estimate.Models;
using System.Configuration;

namespace Estimate.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LoginCheck(FormCollection _FormCollection)
        {
            string ConnectString = ConfigurationManager.ConnectionStrings["EstimateConnectionString"].ConnectionString;
            using (var db = new DataClasses1DataContext(ConnectString))
            {
                try
                {
                    bool any = db.M_Account.Any(x => x.ID == _FormCollection["ID"] && x.Passwd == _FormCollection["Passwd"]);

                    if (any)
                    {
                        return RedirectToAction("Index", "Top");
                    }
                    else
                    {
                        return RedirectToAction("Index", "Login");
                    }
                }
                catch(Exception e) { return View(); }   
            }
        }

        //private List<Account> Sample()
        //{
        //    List<Account> _return = new List<Account>();
        //    Enumerable.Range(0, 20).ToList().ForEach(x =>
        //    {
        //        _return.Add(new Account()
        //        {
        //            ID = string.Format("{0}", (x + 1)),
        //            Passwd = string.Format("{0}", (x + 1)),
        //            FirstName = string.Format("名_{0}",(x + 1)),
        //            LastName = string.Format("姓_{0}", (x + 1))
        //        });
        //    });
        //    return _return;
        //}
    }

}