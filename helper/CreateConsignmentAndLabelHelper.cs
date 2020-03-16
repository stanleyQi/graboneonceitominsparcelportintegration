using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using tools.objects;
using tools.objects.parcelport;

namespace tools.helper
{
     class CreateConsignmentAndLabelHelper
    {
        public static SecurityInfoForApi GetSecurityInfoForApi(string shippingagent)
        {
            SecurityInfoForApi securityInfoForApi = new SecurityInfoForApi();
            string url = @"https://apitest.parcelport.co.nz/token";
            string Username = "ParcelportTest";//test
            string Password = "1234abcd";//test
            string Grant_type = "password";//test
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    //myHttpClient.DefaultRequestHeaders.Authorization =
                    //        new AuthenticationHeaderValue("Bearer", "Your Oauth token");
                    Dictionary<string, string> user = new Dictionary<string, string>();
                    user.Add("username", Username);
                    user.Add("password", Password);
                    user.Add("grant_type", Grant_type);
                    var req = new HttpRequestMessage(HttpMethod.Post, url) { Content = new FormUrlEncodedContent(user) };
                    HttpResponseMessage rep = httpClient.PostAsync(url, req.Content).Result;

                    if (rep.IsSuccessStatusCode)
                    {
                        //securityInfoForApi = (SecurityInfoForApi) JsonConvert.DeserializeObject(rep.Content.ReadAsStringAsync().Result);
                        securityInfoForApi = new JavaScriptSerializer().Deserialize<SecurityInfoForApi>(rep.Content.ReadAsStringAsync().Result);
                        Console.Out.WriteLine(securityInfoForApi);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            

            return securityInfoForApi;
        }

        public static List<ConsignmentRep> CreateConsignments(SecurityInfoForApi userInfoForApi, 
                                                                                            List<WorkForParcelportRow> autoForParcelportRows)
        {
            List<ConsignmentRep> consignmentReps = new List<ConsignmentRep>();

            string shippingUrl = string.Format(@" https://apitest.parcelport.co.nz/api/1.0/shippingoptions?client_id={0}",userInfoForApi.client_id);//post
            string consignmentUrl = string.Format(@" https://apitest.parcelport.co.nz/api/1.0/consignment?client_id={0}", userInfoForApi.client_id);//put

            try
            {
                foreach (WorkForParcelportRow workForParcelportRow in autoForParcelportRows)
                {
                    using (HttpClient httpClient = new HttpClient())
                    {
                        httpClient.DefaultRequestHeaders.Authorization =
                                new AuthenticationHeaderValue("Bearer", userInfoForApi.access_token);

                        # region shipping
                        ShippingReq shippingReq = new ShippingReq();
                        ShippingRep shippingRep = new ShippingRep();

                        //conpose shipping quota request
                        shippingReq.parcels = workForParcelportRow.Parcels.ToList<objects.Parcel>();

                        DeliveryAddress da = new DeliveryAddress();
                        da.address_body = workForParcelportRow.AddressValidated.address.displayline;
                        da.address_city = workForParcelportRow.AddressValidated.address.city;
                        da.address_country = "NZ";
                        da.address_postcode = workForParcelportRow.AddressValidated.address.postcode;//TODO convert exception?
                        da.address_number = workForParcelportRow.AddressValidated.address.number;
                        da.address_street = workForParcelportRow.AddressValidated.address.street;
                        da.address_suburb = workForParcelportRow.AddressValidated.address.suburb==null||string.IsNullOrEmpty(workForParcelportRow.AddressValidated.address.suburb)? 
                                                workForParcelportRow.AddressValidated.address.city: workForParcelportRow.AddressValidated.address.suburb;
                        shippingReq.DeliveryAddress = da;

                        shippingReq.PickupAddress = new PickupAddress()
                        {
                            address_body= "4/1 Cebel Place",
                            address_city= "Auckland",
                            address_country= "NZ",
                            address_postcode= "0632",
                            address_number= "1",
                            address_street= "Cebel Place",
                            address_suburb= "Rosedale"
                        };

                        using (var content = new StringContent(JsonConvert.SerializeObject(shippingReq), System.Text.Encoding.UTF8, "application/json"))
                        {
                            HttpResponseMessage result = httpClient.PostAsync(shippingUrl, content).Result;
                            if (result.IsSuccessStatusCode)
                            {
                                shippingRep = new JavaScriptSerializer().Deserialize<ShippingRep>(result.Content.ReadAsStringAsync().Result);
                                Console.WriteLine(shippingRep);
                            }
                            else
                            {
                                string returnValue = result.Content.ReadAsStringAsync().Result;
                                throw new Exception($"Failed to POST data: ({result.StatusCode}): {returnValue}");
                            }
                        }
                        #endregion
                        /////////////////////////////////////////////////////////////////////////////////////////////////////
                        using (HttpClient consignmentClient = new HttpClient())
                        {
                            consignmentClient.DefaultRequestHeaders.Authorization =
                                    new AuthenticationHeaderValue("Bearer", userInfoForApi.access_token);
                            #region consignment
                            ConsignmentReq consignmentReq = new ConsignmentReq();
                            ConsignmentRep consignmentRep = new ConsignmentRep();

                            //conpose consignment request
                            consignmentReq.authority_to_leave = 0;
                            consignmentReq.carrier_id = "NCP";
                            consignmentReq.carrier_method_id = "CPOLP";
                            consignmentReq.carrier_method_code = "CPOLP";
                            consignmentReq.email_to_recipient = 1;
                            consignmentReq.is_signature = 1;//TODO
                            consignmentReq.QuoteRequestID = shippingRep.quoteRequestID;
                            consignmentReq.parcels = shippingReq.parcels;

                            DeliveryAddress daConsignment = new DeliveryAddress();
                            daConsignment = shippingReq.DeliveryAddress;
                            daConsignment.company_name = workForParcelportRow.CSVForParcelportRow.Company;
                            daConsignment.contact_name = workForParcelportRow.CSVForParcelportRow.Name;
                            daConsignment.email = workForParcelportRow.CSVForParcelportRow.Email;
                            daConsignment.instruction = string.Format(@"id#{0}#{1}", 
                                workForParcelportRow.CSVForParcelportRow.ID, workForParcelportRow.CSVForParcelportRow.Delivery_Instruction);
                            consignmentReq.DeliveryAddress = daConsignment;

                            PickupAddress paConsignment = new PickupAddress();
                            paConsignment = shippingReq.PickupAddress;
                            paConsignment.company_name = "Gmart";
                            paConsignment.contact_name = "Peter";
                            paConsignment.email = "peter@systec.co.nz";
                            paConsignment.instruction = "pickup memo...";
                            paConsignment.phone = "999999999";
                            consignmentReq.PickupAddress = paConsignment;
                            
                            Booking booking = new Booking();
                            booking.pickup_option = 1;
                            consignmentReq.booking = booking;

                            using (var content = new StringContent(JsonConvert.SerializeObject(consignmentReq), System.Text.Encoding.UTF8, "application/json"))
                            {
                                HttpResponseMessage result = consignmentClient.PutAsync(consignmentUrl, content).Result;
                                if (result.IsSuccessStatusCode)
                                {
                                    consignmentRep = new JavaScriptSerializer().Deserialize<ConsignmentRep>(result.Content.ReadAsStringAsync().Result);
                                    consignmentRep.id = workForParcelportRow.CSVForParcelportRow.ID;
                                    consignmentReps.Add(consignmentRep);
                                }
                                else
                                {
                                    string returnValue = result.Content.ReadAsStringAsync().Result;
                                    throw new Exception($"Failed to POST data: ({result.StatusCode}): {returnValue}");
                                }
                            }
                            #endregion
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }

            return consignmentReps;
        }

        public static List<LabelAddress> CreateLabels(SecurityInfoForApi userInfoForApi, List<ConsignmentRep> consignmentReps)
        {
            List<LabelAddress> lables = new List<LabelAddress>();

            string labelUrl = string.Format(@"https://apitest.parcelport.co.nz/api/1.0/labels?client_id={0}", userInfoForApi.client_id);//post

            try
            {
                foreach (ConsignmentRep consignmentRep in consignmentReps)
                {
                    using (HttpClient httpClient = new HttpClient())
                    {
                        httpClient.DefaultRequestHeaders.Authorization =
                                new AuthenticationHeaderValue("Bearer", userInfoForApi.access_token);

                        consignmentRep.consignmentRef.ForEach(r => {
                            LabelAddress LabelAddressRep = new LabelAddress();
                            string  newLabelUrl = labelUrl+string.Format(@"&consignmentRef={0}", r);
                            HttpResponseMessage rep = httpClient.GetAsync(newLabelUrl).Result;
                            if (rep.IsSuccessStatusCode)
                            {
                                LabelAddressRep = new JavaScriptSerializer().Deserialize<LabelAddress>(rep.Content.ReadAsStringAsync().Result);
                                lables.Add(LabelAddressRep);
                            }
                        });
                        
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            return lables;
        }
    }
}
