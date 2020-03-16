using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tools.objects.parcelport
{
    public class ConsignmentRep
    {
        [JsonIgnore]
        public string id { get; set; }
        public string message { get; set; }
        public bool isSuccess { get; set; }
        public ErrorMessages errorMessages { get; set; }
        public List<string> consignmentRef { get; set; }
        public List<int> consignmentLocalIDs { get; set; }
        public List<string> consignmentRefEncode { get; set; }
        public object batchOrderId { get; set; }
    }

    public class ErrorMessages
    {
    }
}
