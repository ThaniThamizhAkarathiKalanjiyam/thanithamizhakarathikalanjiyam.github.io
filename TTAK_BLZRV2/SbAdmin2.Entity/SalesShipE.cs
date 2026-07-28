using System.Collections.Generic;

namespace TTAK_BLZRV2.Entity
{
    public class SalesShipE
    {
        public int doctype_int = 0;
        public string no_cod = string.Empty;
        public string doctypecaption_txt = string.Empty;

        public string selltocustname_txt = string.Empty;
        public string selltocustno_cod = string.Empty;
        public string location_cod = string.Empty;
        public string orderdate_dat = string.Empty;
        public string postingdate_dat = string.Empty;
        public string bin_cod = string.Empty;
        public int status_opt = 0;

        public List<SalesShipLineE> lines = null;
    }
}
