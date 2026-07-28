using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTAK_BLZRV2.Entity
{
    public class OrderListE
    {
        public int doctype_int = 0;
        public string no_cod = string.Empty;
        public string doctypecaption_txt = string.Empty;
        public string buyfromvendname_txt  = string.Empty;
        public string location_cod  = string.Empty;
        public string status_opt  = string.Empty;
        public string orderdate_dat  = string.Empty;
        public string buyfromvendno_cod  = string.Empty;
        public string postingdate_dat = string.Empty;
        public string shipno_cod = string.Empty;
        public List<OrderListLineE> lines = null;

    }
}
