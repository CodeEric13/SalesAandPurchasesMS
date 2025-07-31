using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPMS.Classes
{
    public class SalesRercord
    {
        public int SalesID { get; set; }
        public string BusinessCode { get; set; }
        public string CustomerName { get; set; }
        public string GrossSales { get; set; }
        public string VatSales { get; set; }
        public string OutputSales { get; set; }
        public DateTime DateOfTransact { get; set; }

    }
}
