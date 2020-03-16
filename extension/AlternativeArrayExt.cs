using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tools.objects;

namespace tools.extension
{
    public static class AlternativeArrayExt
    {
        public static string AlternativeArrToStringEx(this Alternative[] alternativeArr) 
        {
            return JsonConvert.SerializeObject(alternativeArr);
        }
    }
}
