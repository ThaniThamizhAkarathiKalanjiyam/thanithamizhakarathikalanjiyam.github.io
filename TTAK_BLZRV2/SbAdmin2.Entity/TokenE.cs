using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTAK_BLZRV2.Entity
{
    public class TokenE
    {
        public string UserName { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public string SecretKey { get; set; }
        public string PassWord { get; set; }
    }
}
