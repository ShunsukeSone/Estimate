using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Estimate.Models
{
    public class CustomerResult
    {
        public string CustemerName1 { get; set; }           /*得意先名1 */
        public string CustemerName2 { get; set; }           /*得意先名2 */
        public string Ryakusyou { get; set; }               /*得意先略称 */
        public string Kana { get; set; }                    /*カタカナ名 */
        public string Zip { get; set; }                     /*郵便番号 */
        public string Address1 { get; set; }                /*住所1 */
        public string Address2 { get; set; }                /*住所2 */
        public string TEL { get; set; }                     /*電話番号 */
        public string FAX { get; set; }                     /*FAX番号 */
        public string Bill_CD { get; set; }                 /*請求先CD */
        public string Bill_Name1 { get; set; }              /*請求先名1 */
        public string Bill_Name2 { get; set; }              /*請求先名2 */
        public string Bill_Zip { get; set; }                /*請求先郵便番号 */
        public string Bill_Address1 { get; set; }           /*請求先住所1 */
        public string Bill_Address2 { get; set; }           /*請求先住所2 */
        public string Bill_TEL { get; set; }                /*請求先電話番号 */
        public string Bill_FAX { get; set; }                /*請求先FAX番号 */
        public int Bill_Kubun { get; set; }                 /*請求先区分 */
        public string Bill_Kind { get; set; }               /*請求先種別 */
        public int Tax_Kubun1 { get; set; }                 /*消費税区分1 */
        public int Tax_Kubun2 { get; set; }                 /*消費税区分2 */
        public int Tax_Kubun3 { get; set; }                 /*消費税区分3 */
        public int Bad_Dabt_Kubun { get; set; }             /*不良債権区分 */
        public string Bill_Close_Day1 { get; set; }         /*請求締日1*/
        public string Bill_Close_Day2 { get; set; }         /*請求締日2*/
        public string Money_Collect_Kubun1 { get; set; }    /*集金区分1*/
        public string Money_Collect_Kubun2 { get; set; }    /*集金区分2*/
        public string Money_Collect_Day1 { get; set; }      /*集金日1*/
        public string Money_Collect_Day2 { get; set; }      /*集金日2*/
        public string Sales_Tantou_CD { get; set; }         /*営業担当者CD*/
        public string Sales_Division { get; set; }          /*営業担当者部署*/
        public string Deve_Tantou_CD { get; set; }          /*開設担当者CD*/
        public string Deve_Division { get; set; }           /*開設担当者部署*/
        public string Delivery_kubun { get; set; }          /*配達区分*/
        public string Delivery_Line { get; set; }           /*配送ライン*/
        public string Delivery_Day { get; set; }            /*納品日*/
        public string Delivery_Day_Sign { get; set; }       /*納品日符号*/
        public string Rank { get; set; }                    /*ランク*/
        public string Factory_Kubun { get; set; }           /*工場区分*/
        public string Express { get; set; }                 /*運送便*/
        public decimal Margin { get; set; }                 /*西村便手数料*/
        public string Total_Start_Day { get; set; }         /*総額開始日*/
        public int Picking { get; set; }                    /*ピッキング*/
        public string Trade_Start_Day { get; set; }         /*取引開始日*/
        public string Latest_Sell_Day { get; set; }         /*最新売上日*/
        public string Notes { get; set; }                   /*備考*/

        //コンストラクター
        public CustomerResult() { }
        public CustomerResult(string _CustemerName1, string _CustemerName2, string _Ryakusyou,
            string _Kana, string _Zip, string _Address1, string _Address2, string _TEL, string _FAX,
            string _Bill_CD, string _Bill_Name1, string _Bill_Name2, string _Bill_Zip,
            string _Bill_Address1, string _Bill_Address2, string _Bill_TEL, string _Bill_FAX,
            int _Bill_Kubun, string _Bill_Kind, int _Tax_Kubun1, int _Tax_Kubun2, int _Tax_Kubun3,
            int _Bad_Dabt_Kubun, string _Bill_Close_Day1, string _Bill_Close_Day2,
            string _Money_Collect_Kubun1, string _Money_Collect_Kubun2, string _Money_Collect_Day1, string _Money_Collect_Day2,
            string _Sales_Tantou_CD, string _Sales_Division, string _Deve_Tantou_CD, string _Deve_Division,
            string _Delivery_kubun, string _Delivery_Line, string _Delivery_Day, string _Delivery_Day_Sign, string _Rank,
            string _Factory_Kubun, string _Express, decimal _Margin, string _Total_Start_Day,
            int _Picking, string _Trade_Start_Day, string _Latest_Sell_Day, string _Notes)
        {
            this.CustemerName1 = _CustemerName1;
            this.CustemerName2 = _CustemerName2;
            this.Ryakusyou = _Ryakusyou;
            this.Kana = _Kana;
            this.Zip = _Zip;
            this.Address1 = _Address1;
            this.Address2 = _Address2;
            this.TEL = _TEL;
            this.FAX = _FAX;
            this.Bill_CD = _Bill_CD;
            this.Bill_Name1 = _Bill_Name1;
            this.Bill_Name2 = _Bill_Name2;
            this.Bill_Zip = _Bill_Zip;
            this.Bill_Address1 = _Bill_Address1;
            this.Bill_Address2 = _Bill_Address2;
            this.Bill_TEL = _Bill_TEL;
            this.Bill_FAX = _Bill_FAX;
            this.Bill_Kubun = _Bill_Kubun;
            this.Bill_Kind = _Bill_Kind;
            this.Tax_Kubun1 = _Tax_Kubun1;
            this.Tax_Kubun2 = _Tax_Kubun2;
            this.Tax_Kubun3 = _Tax_Kubun3;
            this.Bad_Dabt_Kubun = _Bad_Dabt_Kubun;
            this.Bill_Close_Day1 = _Bill_Close_Day1;
            this.Bill_Close_Day2 = _Bill_Close_Day2;
            this.Money_Collect_Kubun1 = _Money_Collect_Kubun1;
            this.Money_Collect_Kubun2 = _Money_Collect_Kubun2;
            this.Money_Collect_Day1 = _Money_Collect_Day1;
            this.Money_Collect_Day2 = _Money_Collect_Day2;
            this.Sales_Tantou_CD = _Sales_Tantou_CD;
            this.Sales_Division = _Sales_Division;
            this.Deve_Tantou_CD = _Deve_Tantou_CD;
            this.Deve_Division = _Deve_Division;
            this.Delivery_kubun = _Delivery_kubun;
            this.Delivery_Line = _Delivery_Line;
            this.Delivery_Day = _Delivery_Day;
            this.Delivery_Day_Sign = _Delivery_Day_Sign;
            this.Rank = _Rank;
            this.Factory_Kubun = _Factory_Kubun;
            this.Express = _Express;
            this.Margin = _Margin;
            this.Total_Start_Day = _Total_Start_Day;
            this.Picking = _Picking;
            this.Trade_Start_Day = _Trade_Start_Day;
            this.Latest_Sell_Day = _Latest_Sell_Day;
            this.Notes = _Notes;

        }
    }
}