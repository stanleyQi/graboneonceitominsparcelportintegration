using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tools.objects.parcelport
{
    class ConsignmentReq
    {
        public int authority_to_leave { get; set; }
        public string carrier_id { get; set; }
        public string carrier_method_id { get; set; }
        public string carrier_method_code { get; set; }
        public int email_to_recipient { get; set; }
        public int is_signature { get; set; }
        public string QuoteRequestID { get; set; }
        public List<Parcel> parcels { get; set; }
        public DeliveryAddress DeliveryAddress { get; set; }
        public PickupAddress PickupAddress { get; set; }
        public Booking booking { get; set; }
    }

    public class Booking
    {
        public int pickup_option { get; set; }
    }
}
