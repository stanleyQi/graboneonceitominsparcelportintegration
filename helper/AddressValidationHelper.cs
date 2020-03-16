using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using tools.objects;

namespace tools.helper
{
    class AddressValidationHelper
    {
        private static string addyapikey = "XXXXXXXXXX";
        private const string addyapi_product = "XXXXXXXXXX";
        private const string addyapi_postmanmockserver = "XXXXXXXXXX";
        private const string addyapi = addyapi_postmanmockserver;

        public static AddressValidated GetCleansedAddress(string address,int testi=1)
        {
            AddressValidated addrVal = new AddressValidated();
            try
            {
                //后台client方式GET提交
                HttpClient myHttpClient = new HttpClient();

                //To addy
                //string url = string.Format(addyapi, addyapikey, address);

                //To postman mock
                string url = string.Format(addyapi, addyapikey, address,testi);
                //string url = string.Format(addyapi_postmanmockserver, addyapikey, address, testi);

                HttpResponseMessage response = myHttpClient.GetAsync(url).Result;
                if (response.IsSuccessStatusCode)
                {

                    #region for convert test
                    //                //TODO:for convert test
                    //                string json = string.Format("{0}", @"{
                    //  'address': {
                    //                    'id': 1764443,
                    //    'dpid': 721429,
                    //    'linzid': 1922891,
                    //    'parcelid': 5071175,
                    //    'meshblock': 605603,
                    //    'number': '218',
                    //    'numberfull': '5/218',
                    //    'numberdisplay': 'Flat 5, 218',
                    //    'rdnumber': '',
                    //    'alpha': '',
                    //    'unittype': 'Flat',
                    //    'unitnumber': '5',
                    //    'floor': '',
                    //    'street': 'Captain Springs Road',
                    //    'suburb': 'Onehunga',
                    //    'city': 'Auckland',
                    //    'mailtown': 'Auckland',
                    //    'territory': 'Auckland',
                    //    'region': 'Auckland',
                    //    'postcode': '1061',
                    //    'building': '',
                    //    'full': '5/218 Captain Springs Road, Onehunga, Auckland 1061',
                    //    'displayline': '5/218 Captain Springs Road',
                    //    'address1': '5/218 Captain Springs Road',
                    //    'address2': 'Onehunga',
                    //    'address3': 'Auckland 1061',
                    //    'address4': '',
                    //    'type': 'Urban',
                    //    'boxbagnumber': '',
                    //    'boxbaglobby': '',
                    //    'x': '174.798975',
                    //    'y': '-36.915818',
                    //    'modified': '2018-01-22',
                    //    'paf': true,
                    //    'deleted': false
                    //  },
                    //  'alternatives': [


                    //  ],
                    //  'reason': null,
                    //  'foundPrefix': false,
                    //  'prefix': ''
                    //}");
                    #endregion

                    //addrVal = (AddressValidated)JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().Result);
                    addrVal = new JavaScriptSerializer().Deserialize<AddressValidated>(response.Content.ReadAsStringAsync().Result);
                    Console.Out.WriteLine(addrVal);
                }
                return addrVal;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
