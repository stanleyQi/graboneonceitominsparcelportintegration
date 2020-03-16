using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tools.objects
{
    public class DGVFlatRow
    {
        public string id { get; set; }
        public bool action { get; set; }
        public string order { get; set; }
        public string initAddress { get; set; }
        public string valAddress { get; set; }
        public int valQyt { get; set; }
        public string valSku { get; set; }
        public double valItemLenght { get; set; }
        public double valItemHeight { get; set; }
        public double valItemWidth { get; set; }
        public double valItemWeight { get; set; }
        public string valAddrState { get; set; }
    }
}
