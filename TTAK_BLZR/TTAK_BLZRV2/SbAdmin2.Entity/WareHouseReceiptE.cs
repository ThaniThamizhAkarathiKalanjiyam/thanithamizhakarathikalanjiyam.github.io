using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTAK_BLZRV2.Entity
{
    public class WareHouseReceiptE
    {
        public string no_cod = string.Empty;
        //public string no_cod = string.Empty;
        public string location_cod = string.Empty;
        public string zone_cod = string.Empty;
        public string bin_cod = string.Empty;
        public string status_opt = string.Empty;
        public string postingdate_dat = string.Empty;
        public string shipno_cod = string.Empty;

        public List<WareHouseReceiptLineE> lines { get; set; }
    }

    
}
