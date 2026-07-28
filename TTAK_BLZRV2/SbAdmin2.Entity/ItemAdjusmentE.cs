using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTAK_BLZRV2.Entity
{

    public class ItemAdjusmentE
    {
        public int lineno_int = 0;
        public string postingdate_dat = string.Empty;
        public int entrytype_int = 0;
        public string docno_cod = string.Empty;
        public string itemno_cod = string.Empty;
        public string uom_cod = string.Empty;
        public string location_cod = string.Empty;
        public string bin_cod = string.Empty;
        public double qty_dec = 0;
        public string unitamt_dec = string.Empty;
        public string serialno_cod = string.Empty;
        public string lotno_cod = string.Empty;
        //public string scancode_cod = string.Empty;
        public string newscancode_cod = string.Empty;
        public string newloccode_cod = string.Empty;
        public string newbin_cod = string.Empty;

        public string baseuom_cod = string.Empty;
        public string desc_txt = string.Empty;
        public List<UomE> uom = new List<UomE>();
        public bool withuom_bool = false;
        public string itemjnltemplatename_cod = string.Empty;
        public string itemjnlbatchname_cod = string.Empty;
        public string no_cod = string.Empty;
        public string scancode_cod = string.Empty;
        public string batchname_cod = string.Empty;

        //public string lineno_int = string.Empty;
        //public string docno_cod = string.Empty;
        //public string itemno_cod = string.Empty;
        //public string desc_txt = string.Empty;
        //public string uom_cod = string.Empty;
        //public string location_cod = string.Empty;
        //public string entrytype_int = string.Empty;
        public string entrytypecaption_txt = string.Empty;
        //public string qty_dec = string.Empty;
    }
}
