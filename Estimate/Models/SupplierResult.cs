using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Estimate.Models
{
    public class SupplierResult
    {
        public string CD { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string Ryakusyou { get; set; }
        public string Kana { get; set; }
        public string Zip { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string TEL { get; set; }
        public string FAX { get; set; }
        public string Notes { get; set; }

        //コンストラクター
        public SupplierResult() { }
        public SupplierResult(string _CD, string _Name1, string _Name2, string _Ryakusyou,
            string _Kana, string _Zip, string _Address1, string _Address2,
            string _TEL, string _FAX, string _Notes)
        {
            this.CD = _CD;
            this.Name1 = _Name1;
            this.Name2 = _Name2;
            this.Ryakusyou = _Ryakusyou;
            this.Kana = _Kana;
            this.Zip = _Zip;
            this.Address1 = _Address1;
            this.Address2 = _Address2;
            this.TEL = _TEL;
            this.FAX = _FAX;
            this.Notes = _Notes;
        }
    }
}