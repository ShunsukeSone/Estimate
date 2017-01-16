using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Estimate.Models
{
    public class ProductResult
    {
        public string JANCD { get; set; }                   /*JANCD*/
        public string Product_Name { get; set; }            /*商品名*/
        public string Kana { get; set; }                    /*カタカナ名*/
        public string Maker_CD { get; set; }                /*メーカーCD*/
        public string Supplier_CD { get; set; }             /*仕入先CD*/
        public string Order_CD { get; set; }                /*発注先CD*/
        public int MAX_Kubun { get; set; }                  /*最大区分*/
        public string MAX_Kikaku { get; set; }              /*最大規格*/
        public string MAX_Tanni { get; set; }               /*最大単位*/
        public decimal MAX_Keisu { get; set; }              /*最大係数*/
        public decimal MAX_Nyusu { get; set; }              /*最大入数*/
        public int MID_Kubun { get; set; }                  /*中間区分*/
        public string MID_Kikaku { get; set; }              /*中間規格*/
        public string MID_Tanni { get; set; }               /*中間単位*/
        public decimal MID_Keisu { get; set; }              /*中間係数*/
        public decimal MID_Nyusu { get; set; }              /*中間入数*/
        public int MIN_Kubun { get; set; }                  /*最小区分*/
        public string MIN_Kikaku { get; set; }              /*最小規格*/
        public string MIN_Tanni { get; set; }               /*最小単位*/
        public decimal MIN_Keisu { get; set; }              /*最小係数*/
        public decimal MIN_Nyusu { get; set; }              /*最小入数*/
        public decimal ExpirationDay { get; set; }          /*賞味期限*/
        public decimal Purchase_Tanka { get; set; }         /*仕入単価*/
        public decimal Change_Tanka { get; set; }           /*変更前単価*/
        public string SellDay { get; set; }                 /*販売期限日*/
        public string ChangeDay { get; set; }               /*単価変更日*/
        public string Notes { get; set; }                   /*備考*/
        public string RegistDay { get; set; }               /*登録日*/

        //コンストラクター
        public ProductResult() { }
        public ProductResult(string _JANCD, string _Product_Name, string _Kana,
            string _Maker_CD, string _Supplier_CD, string _Order_CD, 
            int _MAX_Kubun, string _MAX_Kikaku, string _MAX_Tanni, decimal _MAX_Keisu, decimal _MAX_Nyusu,
            int _MID_Kubun, string _MID_Kikaku, string _MID_Tanni, decimal _MID_Keisu, decimal _MID_Nyusu,
            int _MIN_Kubun, string _MIN_Kikaku, string _MIN_Tanni, decimal _MIN_Keisu, decimal _MIN_Nyusu,
            decimal _ExpirationDay, decimal _Purchase_Tanka, decimal _Change_Tanka,
            string _SellDay, string _ChangeDay, string _Notes, string _RegistDay)
        {
            this.JANCD = _JANCD;
            this.Product_Name = _Product_Name;
            this.Kana = _Kana;
            this.Maker_CD = _Maker_CD;
            this.Supplier_CD = _Supplier_CD;
            this.Order_CD = _Order_CD;
            this.MAX_Kubun = _MAX_Kubun;
            this.MAX_Kikaku = _MAX_Kikaku;
            this.MAX_Tanni = _MAX_Tanni;
            this.MAX_Keisu = _MAX_Keisu;
            this.MAX_Nyusu = _MAX_Nyusu;
            this.MID_Kubun = _MID_Kubun;
            this.MID_Kikaku = _MID_Kikaku;
            this.MID_Tanni = _MID_Tanni;
            this.MID_Keisu = _MID_Keisu;
            this.MID_Nyusu = _MID_Nyusu;
            this.MIN_Kubun = _MIN_Kubun;
            this.MIN_Kikaku = _MIN_Kikaku;
            this.MIN_Tanni = _MIN_Tanni; ;
            this.MIN_Keisu = _MIN_Keisu;
            this.MIN_Nyusu = _MIN_Nyusu;
            this.ExpirationDay = _ExpirationDay;
            this.Purchase_Tanka = _Purchase_Tanka;
            this.Change_Tanka = _Change_Tanka;
            this.SellDay = _SellDay;
            this.ChangeDay = _ChangeDay;
            this.Notes = _Notes;
            this.RegistDay = _RegistDay;
        }

    }
}