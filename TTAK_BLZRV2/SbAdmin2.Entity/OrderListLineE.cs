using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTAK_BLZRV2.Entity
{
    public class OrderListLineE
    {
        public string no_cod = string.Empty;
        public int lineno_int = 0;
        public string docno_cod = string.Empty;
        public string scancode_cod = string.Empty;
        public string uom_cod = string.Empty;
        public double qty_dec = 0;
        public double qtytoreceive_dec = 0;
        public double qtyreceived_dec = 0;
        public int doctype_int = 0;
        public string shelfno_cod = string.Empty;
        public string location_cod = string.Empty;
        public string bin_cod = string.Empty;

    }
}
