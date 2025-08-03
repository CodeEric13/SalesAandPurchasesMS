using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPMS.Classes
{
    public class PurchaseRecord
    {
        public string BusinesCode { get; set; }
        public int PurchaseID { get; set; }
        public int Tin { get; set; }
        public string SupplierName { get; set; }
        public decimal GrossPurchase { get; set; }
        public decimal NetOfVat { get; set; }
        public decimal InputVat { get; set; }
        public DateTime DateOfTransact { get; set; }
    }
}
