using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTAK_BLZRV2.Entity
{
    public class ItemReclassE
    {
        public string no_cod = string.Empty;
        public string uom_cod = string.Empty;
        public string code_cod = string.Empty;
        public string newloccode_cod = string.Empty;
        public string bin_cod = string.Empty;
        public string newbin_cod = string.Empty;
        public string qty_dec = string.Empty;
        public string scancode_cod = string.Empty;
        public string lotno_cod = string.Empty;
        public string newscancode_cod = string.Empty;
        public int entrytype_int = 0;
        public int lineno_int = 0;
        public int doctype_int = 0;

        public string itemno_cod = string.Empty;
        public string shelfno_cod = string.Empty;
        public string docno_cod = string.Empty;

        public string baseuom_cod = string.Empty;
        public string desc_txt = string.Empty;
        public List<UomE> uom = new List<UomE>();
        public bool withuom_bool = false;
        public string itemjnltemplatename_cod = string.Empty;
        public string itemjnlbatchname_cod = string.Empty;


        public string location_cod = string.Empty;
        public string newlocation_cod = string.Empty;

        //20200306 - added by mpm; outstandingqty_dec 
        public double outstandingqty_dec = 0;
    }
}
