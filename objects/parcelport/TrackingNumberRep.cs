using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tools.objects.parcelport
{
    class TrackingNumberRep
    {
        /// <summary>
        /// 
        /// </summary>
        public string consignment_ref { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string client_name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string client_phone { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string date_added { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string branch_code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_rural { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string carrier_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string carrier_method_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string traking_ref { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string label_ref { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string statusColor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Sender_address sender_address { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Recipient_address recipient_address { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string cancel_flag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string status_description { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string statusLastDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> consignmentTracking { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ItemsItem> items { get; set; }
    }

    public class Sender_address
    {
        /// <summary>
        /// 
        /// </summary>
        public string company_name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string contact_name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string address_body { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string address_suburb { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string address_city { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string address_post_code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string contact_number { get; set; }
    }

    public class Recipient_address
    {
        /// <summary>
        /// 
        /// </summary>
        public string contact_name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string address_body { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string address_suburb { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string address_city { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string address_post_code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string contact_number { get; set; }
    }

    public class ItemsItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string custom_pack_name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string customref { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int item_no { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double price_net { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double price_gst { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int vol_declared { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int weight_declared { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string custom_pack_kind { get; set; }
    }
}
