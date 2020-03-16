using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tools.objects.parcelport
{
    class ShippingRep
    {

        public object errorMessage { get; set; }
        public string quoteRequestID { get; set; }
        public DateTime expiryDate { get; set; }
        public Errors errors { get; set; }
        public List<Quote> quotes { get; set; }

        public class Errors
        {
            public List<string> cp { get; set; }
            public List<string> nw { get; set; }
        }

        public class QuoteType
        {
            public string code { get; set; }
            public string description { get; set; }
        }

        public class Type
        {
            public string code { get; set; }
            public string kind { get; set; }
            public string description { get; set; }
            public object sequence { get; set; }
        }

        public class AddOn
        {
            public int type { get; set; }
            public string code { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public double price { get; set; }
            public double gstPrice { get; set; }
        }

        public class PackageDetails
        {
            public object kind { get; set; }
            public double price_net { get; set; }
            public double price_rural { get; set; }
            public double price_sat { get; set; }
            public double price_sig { get; set; }
            public double addOnPrice_Sig { get; set; }
            public List<AddOn> addOns { get; set; }
            public double total_price { get; set; }
            public double total_tax { get; set; }
            public double price { get; set; }
            public double insuredAmount { get; set; }

            
        }

        public class Item
        {
            public int pc { get; set; }
            public double volume { get; set; }
            public double weight { get; set; }
            public object kind { get; set; }
            public object group_id { get; set; }
            public object cust_ref { get; set; }
            public object pack_name { get; set; }
            public double cost_net { get; set; }
            public double cost_rural { get; set; }
            public double cost_sat { get; set; }
            public double cost_sig { get; set; }
            public double cost { get; set; }
        }

        
        public class QuoteDetail
        {
            public Type type { get; set; }
            public Quote quote { get; set; }

            public class Quote
            {
                public string carrier_id { get; set; }
                public string carrier_method_code { get; set; }
                public string carrier_method_id { get; set; }
                public string carrier_method_name { get; set; }
                public string carrier_method_notesHtml { get; set; }
                public string carrier_method_desc { get; set; }
                public string carrier_name { get; set; }
                public string is_signature { get; set; }
                public object min_delivery_target { get; set; }
                public object max_delivery_target { get; set; }
                public double price_satchel { get; set; }
                public PackageDetails packageDetails { get; set; }
                public List<Item> items { get; set; }
                public double insurance { get; set; }
                public string tracking_included { get; set; }
                public string signature_included { get; set; }
                public object interchangeBrachCode { get; set; }
                public int interchangeType { get; set; }
                public object interchangeAddress { get; set; }
            }
        }

        public class Quote
        {
            public QuoteType quoteType { get; set; }
            public List<QuoteDetail> quoteDetails { get; set; }
        }
    }
}

#region json
//{
//    "errorMessage": null,
//    "quoteRequestID": "1391f948-6ab9-428e-ab77-550ca0d19a3d",
//    "expiryDate": "2020-03-02T22:05:23.4664499+13:00",
//    "errors": {
//        "cp": [
//            "Not available in this route"
//        ],
//        "nw": [
//            "Not available in this route"
//        ]
//    },
//    "quotes": [
//        {
//            "quoteType": {
//                "code": "D",
//                "description": "Direct - Non Stop"
//            },
//            "quoteDetails": [
//                {
//                    "type": {
//                        "code": "None",
//                        "kind": "0",
//                        "description": "None",
//                        "sequence": null
//                    },
//                    "quote": {
//                        "carrier_id": "ph",
//                        "carrier_method_code": "MS",
//                        "carrier_method_id": "phms",
//                        "carrier_method_name": "Own Packaging Local",
//                        "carrier_method_notesHtml": "<ul>\r\n<li>Delivery within the local metropolitan area</li>\r\n<li>Delivery Standard -&nbsp;Same day (pickup prior 12 noon) Overnight next business day (pickup after 12 noon)&nbsp;</li>\r\n<li>FREE Insurance covers up to $2000</li>\r\n</ul>",
//                        "carrier_method_desc": "Local",
//                        "carrier_name": "Post Haste",
//                        "is_signature": null,
//                        "min_delivery_target": null,
//                        "max_delivery_target": null,
//                        "price_satchel": 0.0,
//                        "packageDetails": {
//                            "kind": null,
//                            "price_net": 3.19,
//                            "price_rural": 0.0,
//                            "price_sat": 0.0,
//                            "price_sig": 0.0,
//                            "addOnPrice_Sig": 0.0,
//                            "addOns": [
//                                {
//                                    "type": 0,
//                                    "code": "phms",
//                                    "name": "Own Packaging Local",
//                                    "description": "<ul>\r\n<li>Delivery within the local metropolitan area</li>\r\n<li>Delivery Standard -&nbsp;Same day (pickup prior 12 noon) Overnight next business day (pickup after 12 noon)&nbsp;</li>\r\n<li>FREE Insurance covers up to $2000</li>\r\n</ul>",
//                                    "price": 3.19,
//                                    "gstPrice": 0.48
//                                },
//                                {
//                                    "type": 5,
//                                    "code": "phfaf",
//                                    "name": "Fuel Adjustment Factor",
//                                    "description": "<p>The Fuel Adjustment Factor (FAF) is a charge to Domestic and International Courier Services to off-set the current fuel volatility.&nbsp;</p>",
//                                    "price": 0.0,
//                                    "gstPrice": 0.00
//                                },
//                                {
//                                    "type": 5,
//                                    "code": "phruc",
//                                    "name": "Road User Charge RUC",
//                                    "description": "<p>Governmet Road User Charge</p>\r\n<p>Since 2007 the government have implemented increases in road user charges every year except 2011.<br /><br /> On the 18th December 2012 the Transport Minister, Gerry Brownlee, announced that road user charges will be increased on the 1st July each year until 2016 to contribute to the cost of the Roads of National Significance programme. There are seven roads of national significance some of which have not started yet so it is reasonable to assume that the government may continue to fund these projects via road user increases past July 2016. <br /><br />This surcharge will be operating separately from our existing fuel surcharge and be applied to the base price independently.</p>",
//                                    "price": 0.14,
//                                    "gstPrice": 0.02
//                                }
//                            ],
//                            "total_price": 3.33,
//                            "total_tax": 0.50,
//                            "price": 3.19,
//                            "insuredAmount": 0.0
//                        },
//                        "items": [
//                            {
//                                "pc": 1,
//                                "volume": 0.0,
//                                "weight": 10.0,
//                                "kind": null,
//                                "group_id": null,
//                                "cust_ref": null,
//                                "pack_name": null,
//                                "cost_net": 2.310,
//                                "cost_rural": 0.0,
//                                "cost_sat": 0.0,
//                                "cost_sig": 0.0,
//                                "cost": 2.310
//                            }
//                        ],
//                        "insurance": 2000.00,
//                        "tracking_included": "1",
//                        "signature_included": "1",
//                        "interchangeBrachCode": null,
//                        "interchangeType": 0,
//                        "interchangeAddress": null
//                    }
//                }
//            ]
//        },
//        {
//            "quoteType": {
//                "code": "D",
//                "description": "Direct - Non Stop"
//            },
//            "quoteDetails": [
//                {
//                    "type": {
//                        "code": "None",
//                        "kind": "0",
//                        "description": "None",
//                        "sequence": null
//                    },
//                    "quote": {
//                        "carrier_id": "NCP",
//                        "carrier_method_code": "CPOLP",
//                        "carrier_method_id": "CPOLP",
//                        "carrier_method_name": "CP Online Parcel",
//                        "carrier_method_notesHtml": null,
//                        "carrier_method_desc": null,
//                        "carrier_name": "CourierPost",
//                        "is_signature": "1",
//                        "min_delivery_target": null,
//                        "max_delivery_target": null,
//                        "price_satchel": 0.0,
//                        "packageDetails": {
//                            "kind": null,
//                            "price_net": 2.99,
//                            "price_rural": 0.0,
//                            "price_sat": 0.0,
//                            "price_sig": 0.0,
//                            "addOnPrice_Sig": 0.27,
//                            "addOns": [
//                                {
//                                    "type": 0,
//                                    "code": "CPOLP",
//                                    "name": "CP Online Parcel",
//                                    "description": "Next working day - delivery to remote or rural area's may take longer",
//                                    "price": 2.99,
//                                    "gstPrice": 0.45
//                                },
//                                {
//                                    "type": 6,
//                                    "code": "CPUVP",
//                                    "name": "FAF + RUC",
//                                    "description": "FAF + RUC",
//                                    "price": 3.89,
//                                    "gstPrice": 0.58
//                                },
//                                {
//                                    "type": 1,
//                                    "code": "CPSR",
//                                    "name": "CP Online Sig Rq",
//                                    "description": "CP Online Sig Rq",
//                                    "price": 0.27,
//                                    "gstPrice": 0.04
//                                },
//                                {
//                                    "type": 2,
//                                    "code": "CPOLSAT",
//                                    "name": "CP Online Saturday Delivery",
//                                    "description": "CP Online Saturday Delivery",
//                                    "price": 0.0,
//                                    "gstPrice": 0.0
//                                },
//                                {
//                                    "type": 6,
//                                    "code": "CPOLSED",
//                                    "name": "CP Online S/Day Evening Delivery",
//                                    "description": "CP Online S/Day Evening Delivery",
//                                    "price": 0.0,
//                                    "gstPrice": 0.0
//                                },
//                                {
//                                    "type": 6,
//                                    "code": "CPOLOED",
//                                    "name": "CP Online Overnight Evening Delivery",
//                                    "description": "CP Online Overnight Evening Delivery",
//                                    "price": 0.0,
//                                    "gstPrice": 0.0
//                                }
//                            ],
//                            "total_price": 7.15,
//                            "total_tax": 1.07,
//                            "price": 2.99,
//                            "insuredAmount": 0.0
//                        },
//                        "items": [
//                            {
//                                "pc": 1,
//                                "volume": 0.0,
//                                "weight": 10.0,
//                                "kind": null,
//                                "group_id": null,
//                                "cust_ref": null,
//                                "pack_name": null,
//                                "cost_net": 2.3,
//                                "cost_rural": 0.0,
//                                "cost_sat": 0.0,
//                                "cost_sig": 0.21,
//                                "cost": 2.51
//                            }
//                        ],
//                        "insurance": 2000.00,
//                        "tracking_included": "1",
//                        "signature_included": "1",
//                        "interchangeBrachCode": null,
//                        "interchangeType": 0,
//                        "interchangeAddress": null
//                    }
//                }
//            ]
//        },
//        {
//            "quoteType": {
//                "code": "D",
//                "description": "Direct - Non Stop"
//            },
//            "quoteDetails": [
//                {
//                    "type": {
//                        "code": "None",
//                        "kind": "0",
//                        "description": "None",
//                        "sequence": null
//                    },
//                    "quote": {
//                        "carrier_id": "til",
//                        "carrier_method_code": "TILBP",
//                        "carrier_method_id": "TILBP",
//                        "carrier_method_name": "TIL base price",
//                        "carrier_method_notesHtml": null,
//                        "carrier_method_desc": "TIL base price",
//                        "carrier_name": "TIL",
//                        "is_signature": null,
//                        "min_delivery_target": null,
//                        "max_delivery_target": null,
//                        "price_satchel": 0.0,
//                        "packageDetails": {
//                            "kind": null,
//                            "price_net": 42.9,
//                            "price_rural": 0.0,
//                            "price_sat": 0.0,
//                            "price_sig": 0.0,
//                            "addOnPrice_Sig": 0.0,
//                            "addOns": [
//                                {
//                                    "type": 0,
//                                    "code": "TILBP",
//                                    "name": "TIL",
//                                    "description": null,
//                                    "price": 42.9,
//                                    "gstPrice": 6.44
//                                },
//                                {
//                                    "type": 5,
//                                    "code": "tilfaf",
//                                    "name": "Fuel Adjustment Factor",
//                                    "description": null,
//                                    "price": 5.28,
//                                    "gstPrice": 0.79
//                                },
//                                {
//                                    "type": 5,
//                                    "code": "tilrft1",
//                                    "name": "Auckland Regional Fuel Tax (AKL - AKL)",
//                                    "description": "<p>Auckland Regional Fuel Tax</p>",
//                                    "price": 0.86,
//                                    "gstPrice": 0.13
//                                },
//                                {
//                                    "type": 5,
//                                    "code": "tilruc",
//                                    "name": "Road User Charge RUC",
//                                    "description": "<p>Governmet Road User Charge</p>\r\n<p>Since 2007 the government have implemented increases in road user charges every year except 2011.<br /><br />On the 18th December 2012 the Transport Minister, Gerry Brownlee, announced that road user charges will be increased on the 1st July each year until 2016 to contribute to the cost of the Roads of National Significance programme. There are seven roads of national significance some of which have not started yet so it is reasonable to assume that the government may continue to fund these projects via road user increases past July 2016.&nbsp;<br /><br />This surcharge will be operating separately from our existing fuel surcharge and be applied to the base price independently.</p>",
//                                    "price": 0.47,
//                                    "gstPrice": 0.07
//                                }
//                            ],
//                            "total_price": 49.51,
//                            "total_tax": 7.43,
//                            "price": 42.9,
//                            "insuredAmount": 0.0
//                        },
//                        "items": [
//                            {
//                                "pc": 1,
//                                "volume": 0.0,
//                                "weight": 0.0,
//                                "kind": null,
//                                "group_id": null,
//                                "cust_ref": null,
//                                "pack_name": null,
//                                "cost_net": 33.00,
//                                "cost_rural": 0.0,
//                                "cost_sat": 0.0,
//                                "cost_sig": 0.0,
//                                "cost": 33.00
//                            }
//                        ],
//                        "insurance": 0.0,
//                        "tracking_included": "1",
//                        "signature_included": "1",
//                        "interchangeBrachCode": null,
//                        "interchangeType": 0,
//                        "interchangeAddress": null
//                    }
//                }
//            ]
//        }
//    ]
//}
#endregion