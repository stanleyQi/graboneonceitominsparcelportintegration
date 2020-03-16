using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tools.objects;

namespace tools.helper
{
    class ParcelSpecHelper
    {
        #region TODO:模拟物件规格
        private static Dictionary<string, Parcel> RefParcelSpecs = new Dictionary<string, Parcel>();
        static ParcelSpecHelper(){
            RefParcelSpecs.Add("FUR00038#M", new Parcel { Length=45.05,Height=8,Width=120,Weight=23.5 });
            RefParcelSpecs.Add("FUR00029#B", new Parcel { Length =40, Height =100, Width =20, Weight =15  });
            RefParcelSpecs.Add("FUR00003#B", new Parcel { Length =25, Height =50, Width =100, Weight =12 });
            RefParcelSpecs.Add("FUR00055#W", new Parcel { Length =35, Height =15, Width =25, Weight =7 });
            RefParcelSpecs.Add("CAR00066", new Parcel { Length = 35, Height = 15, Width = 25, Weight = 7 });
            RefParcelSpecs.Add("FUR00051#B", new Parcel { Length = 35, Height = 15, Width = 25, Weight = 7 });
            RefParcelSpecs.Add("ACCR0015", new Parcel { Length = 35, Height = 15, Width = 25, Weight = 7 });
            RefParcelSpecs.Add("BTH00001", new Parcel { Length = 35, Height = 15, Width = 25, Weight = 7 });
            RefParcelSpecs.Add("BAG000222", new Parcel { Length = 35, Height = 15, Width = 25, Weight = 7 });
            RefParcelSpecs.Add("COPK0015***", new Parcel { Length = 35, Height = 15, Width = 25, Weight = 7 });
        }
        #endregion
        
        public static Parcel GetParcelSpec(string code) 
        {
            Parcel parcelSpec = new Parcel();

            parcelSpec = RefParcelSpecs.ContainsKey(code) ? RefParcelSpecs[code] : null;

            return parcelSpec;
        }
    }
}
