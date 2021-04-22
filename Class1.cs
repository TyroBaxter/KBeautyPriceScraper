using System;
using System.Collections.Generic;
using System.Text;

namespace KBeautyPriceScraper
{

    public class Rootobject
    {
        public Dictionary<string, ItemDetails> ItemDetails { get; set; }
        public float iTotalAddSalePrice { get; set; }
        public float iTotalOrderPrice { get; set; }
       // public bool display_prd_vat_separately { get; set; }
    }

    public class ItemDetails
    {
        public int product_no { get; set; }
        public string quantity { get; set; }
        public string item_code { get; set; }
        public string option_id { get; set; }
        public string product_price { get; set; }
        //public int opt_price { get; set; }
        //public string product_tax_type { get; set; }
        public string register_date { get; set; }
        public string pis_ins_timestamp { get; set; }
        public string pis_upd_timestamp { get; set; }
        public string pis_latest_display_datetime { get; set; }
        //public int prd_tax_type_per { get; set; }
        //public bool display_vat_separately { get; set; }
        //public object compare_tax_type { get; set; }
        //public object compare_tax_percent { get; set; }
        //public string is_subscription { get; set; }
        //public string basket_type { get; set; }
        //public object set_product_name { get; set; }
        //public string ori_product_price { get; set; }
        //public int ori_opt_price { get; set; }
        //public float ori_item_price { get; set; }
        //public float ori_item_quantity_price { get; set; }
        public float item_price { get; set; }
        //public int item_about_sale { get; set; }
        //public int instant_sale_price { get; set; }
        //public int set_sale_price { get; set; }
        //public float item_quantity_price { get; set; }
        //public float sub_total_price { get; set; }
        //public float vat_product_price { get; set; }
        //public int vat_opt_price { get; set; }
        //public float vat_sub_total_price { get; set; }
        //public bool product_sale_price_display { get; set; }
        //public bool product_discount_price_display { get; set; }
        //public bool total_product_sale_price_display { get; set; }
        //public int product_unit_benefit_price { get; set; }
        //public int product_benefit_price { get; set; }
        //public float product_sale_price { get; set; }
        //public float sub_total_sale_price { get; set; }
        //public float add_sale { get; set; }
        //public float benefit_add_sale { get; set; }
        //public float add_sale_related_qty { get; set; }
        //public int add_sale_not_related_qty { get; set; }
        //public Sale_Calc_Param sale_calc_param { get; set; }
        //public float unit_add_sale { get; set; }
        //public float total_unit_add_sale { get; set; }
        //public int unit_rebuysale { get; set; }
        //public int unit_bulksale { get; set; }
        //public object unit_livelinkonsale { get; set; }
        //public float unit_periodsale { get; set; }
        //public int unit_membersale { get; set; }
        //public int unit_newproductsale { get; set; }
        //public int unit_setproductsale { get; set; }
        //public int unit_subscriptionpayseqsale { get; set; }
        //public int unit_shipfeesale { get; set; }
        //public int unit_subscriptionshipfeesale { get; set; }
        //public string bp_prd_extra { get; set; }
        //public string mileage_used_type { get; set; }
        //public string global_mileage { get; set; }
        //public string mileage_type { get; set; }
        //public string mileage_value { get; set; }
        //public int mileage_generate_calc { get; set; }
        //public int single_mileage_generate { get; set; }
        //public int mileage_generate { get; set; }
        //public object[] mileage_generate_info { get; set; }
    }

    public class Sale_Calc_Param
    {
        //public object ReBuySale { get; set; }
        //public object BulkSale { get; set; }
        //public object LiveLinkOnSale { get; set; }
        //public Periodsale PeriodSale { get; set; }
        //public object MemberSale { get; set; }
        //public object NewProductSale { get; set; }
        //public object SetProductSale { get; set; }
        //public object SubscriptionPayseqSale { get; set; }
        //public object ShipFeeSale { get; set; }
        //public object SubscriptionShipfeeSale { get; set; }
    }

    public class Periodsale
    {
        //public string sMode { get; set; }
        //public string iVal { get; set; }
        //public string sLimit { get; set; }
        //public string sLimitFlag { get; set; }
        //public string sIsRelatedPurchasingQuantity { get; set; }
        //public object sExcludeBulkBuyBenefit { get; set; }
        //public float item_price { get; set; }
        //public float total_price { get; set; }
        //public string iUnitQuantity { get; set; }
        //public int benefit_no { get; set; }
        //public object benefit_item_type { get; set; }
        //public string[] aCalcStr { get; set; }
    }

}
