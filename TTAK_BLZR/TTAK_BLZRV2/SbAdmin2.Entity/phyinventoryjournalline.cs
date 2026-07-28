using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTAK_BLZRV2.Entity
{
    public class phyinventoryjournalline
    {
        //"batchname_cod":"DEFAULT",
        public string batchname_cod { get; set; }

        //"no_cod":"1000",
        public string no_cod { get; set; }

        //"uom_cod":"PCS",
        public string uom_cod { get; set; }

        //"code_cod":"SILVER",
        public string code_cod { get; set; }

        //"bin_cod":"S-01-0001",
        public string bin_cod { get; set; }

        //"qty_dec":5.0,
        public string qty_dec { get; set; }

        //"systemquantity_dec":210.0,
        public string systemquantity_dec { get; set; }
        //"adjquantity_dec":205.0
        public string adjquantity_dec { get; set; }


    }
}
