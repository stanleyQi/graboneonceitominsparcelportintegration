using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tools.objects.parcelport
{
    class ShippingReq
    {
        public List<Parcel> parcels { get; set; }
        public DeliveryAddress DeliveryAddress { get; set; }
        public PickupAddress PickupAddress { get; set; }
    }

    public class DeliveryAddress
    {
        public string company_name { get; set; }
        public string contact_name { get; set; }
        public string email { get; set; }
        public string instruction { get; set; }
        public string address_body { get; set; }
        public string address_city { get; set; }
        public string address_country { get; set; }
        public string address_postcode { get; set; }
        public string address_number { get; set; }
        public string address_street { get; set; }
        public string address_suburb { get; set; }
    }

    public class PickupAddress
    {
        public string company_name { get; set; }
        public string contact_name { get; set; }
        public string email { get; set; }
        public string instruction { get; set; }
        public string phone { get; set; }
        public string address_body { get; set; }
        public string address_city { get; set; }
        public string address_country { get; set; }
        public string address_postcode { get; set; }
        public string address_number { get; set; }
        public string address_street { get; set; }
        public string address_suburb { get; set; }
    }
}

#region json
//{
//  "parcels": [
//    {
//      "length": 10,
//      "height": 10,
//      "width": 10,
//      "weight": 10,
//    }
//  ],
//  "DeliveryAddress": {
//    "address_body": "5/218 Captain Springs Road",
//    "address_city": "Auckland",
//    "address_country": "NZ",
//    "address_postcode": 1061,
//    "address_number": "218",
//    "address_street": "Captain Springs Road",
//    "address_suburb": "Onehunga"
//  },
//  "PickupAddress": {
//    "address_body": "4/1 Cebel Place",
//    "address_city": "Auckland",
//    "address_country": "NZ",
//    "address_postcode": 0632,
//    "address_number": "1",
//    "address_street": "Cebel Place",
//    "address_suburb": "Rosedale"
//  }
//}
#endregion
