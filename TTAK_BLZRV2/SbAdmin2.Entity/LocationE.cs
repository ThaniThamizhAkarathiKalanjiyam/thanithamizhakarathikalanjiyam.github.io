using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTAK_BLZRV2.Entity
{
    public class LocationE
    {
        public string batchname_cod = string.Empty;
        public bool binmandatory_bool = false;
        public string code_cod = string.Empty;
        public string name_txt = string.Empty;
        public List<BinE> bin = new List<BinE>();
    }
}
