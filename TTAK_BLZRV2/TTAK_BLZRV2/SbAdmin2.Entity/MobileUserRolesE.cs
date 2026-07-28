using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTAK_BLZRV2.Entity
{
    public class MobileUserRolesE
    {
        public string shipno_cod = string.Empty;
        public List<MobileUserRolesListE> lines { get; set; }
    }
}
