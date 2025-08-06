using DevExpress.XtraEditors.Filtering.Templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPMS.Classes
{
    public class ClientRecords
    {
       // public string BranchCode { get; set; }
        public string TinNo{ get; set; }
        public string Name { get; set; }
        public string BusinessAddress { get; set; }
        public string BusinessCode { get; set; }
        public string BusinessName { get; set; }
        public string TaxType { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
