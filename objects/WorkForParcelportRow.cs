using LINQtoCSV;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tools.objects
{
    public class WorkForParcelportRow
    {
        public bool AutoFlg { get; set; }
        //Original csv row
        public CSVForParcelportRow CSVForParcelportRow { get; set; }

        //combined from original address info
        public string InitialFullAddress { get; set; }

        //validated address info
        private AddressValidated _addressValidated;
        public AddressValidated AddressValidated { 
            get { return _addressValidated; } 
            set 
            {
                this.AutoFlg = (value.address == null || string.IsNullOrEmpty(value.address.ToString())) ? false:true;
                _addressValidated = value;
            } 
        }//for address validation

        //getting parcel spec info
        public Parcel[] Parcels { get; set; }//for parcel specification

        //for getting labels
        public string Booking_Pickup_Option { get; set; }
        public string Booking_Instruction { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
