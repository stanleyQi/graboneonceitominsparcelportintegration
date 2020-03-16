using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tools.helper
{
    class Tools
    {
        public static Dictionary<string, int> GetParcelItemsAndQuantity(string codeqty) 
        {
            Dictionary<string, int> itemsInfo = new Dictionary<string, int>();

            var items = codeqty.Split(',').ToList<string>();
            items.ForEach((item)=> {
                var itemArr = item.Split('*');
                int quantity = Int32.Parse(itemArr[itemArr.Length - 1].Trim());
                string newItem = item.Trim();
                itemsInfo.Add(newItem.Substring(0, newItem.Length- quantity.ToString().Length-1), quantity); 
            });

            return itemsInfo;
        }
    }
}
