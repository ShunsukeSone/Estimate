using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Estimate.Models
{
    public class Account
    {
        public string ID { get; set; }
        public string Passwd { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //コンストラクター
        public Account() { }
        public Account(string _ID, string _Passwd, string _FirstName, string _LastName)
        {
            this.ID = _ID;
            this.Passwd = _Passwd;
            this.FirstName = _FirstName;
            this.LastName = _LastName;
        }
    }
}