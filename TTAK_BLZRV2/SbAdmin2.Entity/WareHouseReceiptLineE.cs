using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTAK_BLZRV2.Entity
{
    public class WareHouseReceiptLineE
    {
        public string no_cod = string.Empty;
        public int sourcedoc_opt = 0;
        public string sourceno_cod = string.Empty;
        //public string no_cod = string.Empty;
        public string scan_cod = string.Empty;
        public string desc_txt = string.Empty;
        public string uom_cod = string.Empty;
        public double qty_dec = 0;
        public double qtytoreceive_dec = 0;
        public double qtyreceived_dec = 0;
        public string shelfno_cod = string.Empty;
    }
}
