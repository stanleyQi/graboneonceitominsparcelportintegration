using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tools.objects;

namespace tools.helper
{
    public class DVGHelper
    {
        public static DGVFlatRow Convert(WorkForParcelportRow workRow)
        {
            DGVFlatRow dGVFlatRow = new DGVFlatRow();

            dGVFlatRow.id = workRow.CSVForParcelportRow.ID;
            dGVFlatRow.action = (workRow.Parcels.Length > 1 
                                        || workRow.CSVForParcelportRow.Codeqty.Contains(',')) 
                                        ? false: workRow.AutoFlg;
            dGVFlatRow.order = workRow.CSVForParcelportRow.Codeqty;
            dGVFlatRow.initAddress = workRow.InitialFullAddress;
            dGVFlatRow.valAddress = workRow.AddressValidated.address==null?"":workRow.AddressValidated.address.full;
            dGVFlatRow.valQyt = workRow.Parcels.Length;
            dGVFlatRow.valSku= workRow.CSVForParcelportRow.Codeqty;
            dGVFlatRow.valItemLenght = workRow.Parcels[0].Length;
            dGVFlatRow.valItemHeight = workRow.Parcels[0].Height;
            dGVFlatRow.valItemWidth = workRow.Parcels[0].Width;
            dGVFlatRow.valItemWeight = workRow.Parcels[0].Weight;
            dGVFlatRow.valAddrState = workRow.Parcels.Length > 1 ?
                                "More than one item." :
                                (string.IsNullOrEmpty(workRow.AddressValidated.reason) ? (
                                    workRow.AddressValidated.address == null ? "Could not be validated" : workRow.AddressValidated.address.full
                                ) : workRow.AddressValidated.reason) ;

            return dGVFlatRow;
        }
    }
}
