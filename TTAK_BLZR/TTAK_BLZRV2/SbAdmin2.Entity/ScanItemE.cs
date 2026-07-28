using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTAK_BLZRV2.Entity
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ScanItemE
    {
        [JsonProperty]
        string no_cod = string.Empty;
        [JsonProperty]
        List<UomE> uom = new List<UomE>();
        [JsonProperty]
        string serialno_cod = string.Empty;
        [JsonProperty]
        string lotno_cod = string.Empty;
        [JsonProperty]
        string desc_txt = string.Empty;

        public string Itemno_cod
        {
            get
            {
                return no_cod;
            }

            set
            {
                no_cod = value;
            }
        }

        public List<UomE> Uom
        {
            get
            {
                return uom;
            }

            set
            {
                uom = value;
            }
        }

        public string Serialno_cod
        {
            get
            {
                return serialno_cod;
            }

            set
            {
                serialno_cod = value;
            }
        }

        public string Lotno_cod
        {
            get
            {
                return lotno_cod;
            }

            set
            {
                lotno_cod = value;
            }
        }

        public string Itemdesc_txt
        {
            get
            {
                return desc_txt;
            }

            set
            {
                desc_txt = value;
            }
        }
    }
}
