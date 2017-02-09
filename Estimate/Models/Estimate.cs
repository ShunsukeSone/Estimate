using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Estimate.Models
{
    public class Estimates
    {
        public decimal Estimate_Zip { get; set; }                   /*見積先郵便番号*/
        public string Estimate_Pref { get; set; }                   /*見積先都道府県*/
        public string Estimate_City { get; set; }                   /*見積先市町村*/
        public string Estimate_Address { get; set; }                /*見積先番地*/
        public string Estimate_Name { get; set; }                   /*見積先名*/
        public decimal Comp_Zip { get; set; }                       /*郵便番号*/
        public string Comp_Pref { get; set; }                       /*都道府県*/
        public string Comp_City { get; set; }                       /*市町村*/
        public string Comp_Address { get; set; }                    /*番地*/
        public string Comp_Name { get; set; }                       /*名前*/
        public string TEL { get; set; }                             /*電話番号*/
        public string FAX { get; set; }                             /*FAX番号*/
        public List<Meisai> Meisai { get; set; }                    /*明細リスト*/

        public Estimates() { }
        public Estimates(
            decimal _Estimate_Zip,
            string _Estimate_Pref,
            string _Estimate_City,
            string _Estimate_Address,
            string _Estimate_Name,
            decimal _Comp_Zip,
            string _Comp_Pref,
            string _Comp_City,
            string _Comp_Address,
            string _Comp_Name,
            string _TEL,
            string _FAX,
            List<Meisai> _Meisai)
        {
            this.Estimate_Zip = _Estimate_Zip;
            this.Estimate_Pref = _Estimate_Pref;
            this.Estimate_City = _Estimate_City;
            this.Estimate_Address = _Estimate_Address;
            this.Estimate_Name = _Estimate_Name;
            this.Estimate_Name = _Estimate_Name;
            this.Comp_Zip = _Comp_Zip;
            this.Comp_Pref = _Comp_Pref;
            this.Comp_City = _Comp_City;
            this.Comp_Address = _Comp_Address;
            this.Comp_Name = _Comp_Name;
            this.TEL = _TEL;
            this.FAX = _FAX;
            this.Meisai = _Meisai;
        }
    }

    public class Meisai
    {
        public string Seq { get; set; }
        public decimal No { get; set; }                             /*商品番号*/
        public string Name { get; set; }                            /*商品名*/
        public decimal Suryo { get; set; }                          /*数量*/
        public decimal Tanka { get; set; }                          /*税込み単価*/

        public Meisai() { }
        public Meisai(string _Seq, decimal _No, string _Name, decimal _Suryo, decimal _Tanka)
        {
            this.Seq = _Seq;
            this.No = _No;
            this.Name = _Name;
            this.Suryo = _Suryo;
            this.Tanka = _Tanka;
        }
    }
}