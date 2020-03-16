using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Script.Serialization;

namespace tools.objects
{
    public class AddressValidated
    {

        public Address address { get; set; }
        public Alternative[] alternatives { get; set; }

        private string _reason = "";
        public string reason { get { return _reason; } set { if (value == null) _reason = ""; } }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

    public class Address
    {
        private int _id;
        public int? id { get { return _id; } set { if (value == null) _id = 0; } }

        private int _dpid;
        public int? dpid { get { return _dpid; } set { if (value == null) _dpid = 0; }}

        private int _linzid;
        public int? linzid { get { return _linzid; } set { if (value == null) _linzid = 0; }}

        private int _parcelid;
        public int? parcelid { get { return _parcelid; } set { if (value == null) _parcelid = 0; } }

        private int _meshblock;
        public int? meshblock { get { return _meshblock; } set { if (value == null) _meshblock = 0; } }
        public string number { get; set; }
        public string numberfull { get; set; }
        public string numberdisplay { get; set; }
        public string rdnumber { get; set; }
        public string alpha { get; set; }
        public string unittype { get; set; }
        public string unitnumber { get; set; }
        public string floor { get; set; }
        public string street { get; set; }
        public string suburb { get; set; }
        public string city { get; set; }
        public string mailtown { get; set; }
        public string territory { get; set; }
        public string region { get; set; }
        public string postcode { get; set; }
        public string building { get; set; }
        public string full { get; set; }
        public string displayline { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string address3 { get; set; }
        public string address4 { get; set; }
        public string type { get; set; }
        public string boxbagnumber { get; set; }
        public string boxbaglobby { get; set; }
        public string x { get; set; }
        public string y { get; set; }
        public string modified { get; set; }
        public bool paf { get; set; }
        public bool deleted { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

    public class Alternative
    {
        public int id { get; set; }
        public string a { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}