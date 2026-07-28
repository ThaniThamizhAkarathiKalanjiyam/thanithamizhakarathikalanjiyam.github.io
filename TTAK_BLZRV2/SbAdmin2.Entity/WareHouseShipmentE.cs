using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTAK_BLZRV2.Entity
{
    public class WareHouseShipmentE
    {
        public string no_cod { get; set; }
        public string location_cod { get; set; }
        public string zone_cod { get; set; }
        public string bin_cod { get; set; }
        public string status_opt { get; set; }
        public string postingdate_dat { get; set; }
        public List<WareHouseReceiptLineE> lines { get; set; }
    }
}
