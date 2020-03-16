using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tools.objects;

namespace tools.extension
{
    public static class ParcelSpecArrayExt
    {
        public static string ParcelSpecArrToStringEx(this Parcel[] parcelSpecArr) 
        {
            return JsonConvert.SerializeObject(parcelSpecArr);
        }
    }
}
