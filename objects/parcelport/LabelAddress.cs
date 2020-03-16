using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tools.objects.parcelport
{
    class LabelAddress
    {
        public string url { get; set; }
        public bool success { get; set; }
        public string message { get; set; }

        public override string ToString()
        {
            return this.url.Substring(this.url.Length-10,10).Replace('/', '=');
        }
    }
}
