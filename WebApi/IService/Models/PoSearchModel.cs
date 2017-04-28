using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IService.Models
{
    public class PoSearchModel
    {
        public string PONUM { get; set; }
        public System.DateTime IDATE { get; set; }
        public string POTYPE { get; set; }
        public string REV { get; set; }
        public string WONUM { get; set; }
        public string PROJECT { get; set; }
        public string VENID { get; set; }
        public string CURR { get; set; }
        public decimal RATE { get; set; }
        public decimal TAXRATE { get; set; }
        public string TRADETERM { get; set; }
        public string SHIPTO { get; set; }
        public string SHIPMARK { get; set; }
        public string VIA { get; set; }
        public string REMARK { get; set; }
        public Decimal AMOUNT { get; set; }
        public Boolean CLOSED { get; set; }
        public DateTime CREATED { get; set; }
        public string CREATEDBY { get; set; }
        public string WFSTATUS { get; set; }
        public string ISPRINTED { get; set; }
        public string OBJTYPE { get; set; }
        public DateTime? CLOSEDDATE { get; set; }
        public string DEPTID { get; set; }
        public string COMMENTS { get; set; }
        public Decimal INSURE { get; set; }
        public Decimal HANDLE { get; set; }
        public Decimal DELIVERYCHRG { get; set; }
        public Decimal MISCHRG { get; set; }
        public string MISCHRGTIT { get; set; }
        public string MISCACC { get; set; }
        public Decimal TOTALQTY { get; set; }
        public String BuyerName { get; set; }
        public String InvTypeDescr { get; set; }
        public String PayMethodDescr { get; set; }
        public String PayTermDescr { get; set; }
        public String CreatedUserName { get; set; }
        public String UpdatedUserName { get; set; }
    }
}
