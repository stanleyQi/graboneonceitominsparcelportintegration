using LINQtoCSV;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tools.objects
{
    public class CSVForParcelportRow
    {
        [CsvColumn(FieldIndex =1)]
        public string ID { get; set; }

        [CsvColumn(FieldIndex =4)]
        public string Name { get; set; }

        [CsvColumn(FieldIndex = 5, CanBeNull = true)]
        public string Email { get; set; }

        [CsvColumn(FieldIndex = 9, CanBeNull = true)]
        public string Company { get; set; }

        [CsvColumn(FieldIndex = 11, CanBeNull = true)]
        public string PO { get; set; }

        [CsvColumn(FieldIndex = 13, CanBeNull = false)]
        public string Address { get; set; }

        [CsvColumn(FieldIndex = 27, CanBeNull = true)]
        public string City { get; set; }

        [CsvColumn(FieldIndex = 30, CanBeNull = false)]
        public string Country { get; set; }

        [CsvColumn(FieldIndex = 31, CanBeNull = true)]
        public string Phone { get; set; }

        [CsvColumn( FieldIndex = 35, CanBeNull = true)]
        public string Codeqty { get; set; }

        [CsvColumn(FieldIndex = 36, CanBeNull = true)]
        public string Postcode { get; set; }

         [CsvColumn(FieldIndex = 25, CanBeNull = true)]
        public string Pickup_Instruction { get; set; }

        [CsvColumn(FieldIndex = 24, CanBeNull = true)]
        public string Delivery_Instruction { get; set; }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
        ////for generate excel
        //public string InitialFullAddress { get; set; }
        //public AddressValidated AddressValidated { get; set; }//for address validation
        //public List<ParcelSpec> ParcelSpecs { get; set; }//for parcel specification

        //public string Booking_Pickup_Option { get; set; }
        //public string Booking_Instruction { get; set; }
    }
}
