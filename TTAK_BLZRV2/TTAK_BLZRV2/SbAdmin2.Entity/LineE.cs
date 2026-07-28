using Newtonsoft.Json;

namespace TTAK_BLZRV2.Entity
{
    [JsonObject(MemberSerialization.OptIn)]
    public class LineE
    {
        [JsonProperty]
        string lineno_int = string.Empty;
        [JsonProperty]
        string no_cod = string.Empty;
        [JsonProperty]
        string uom_cod = string.Empty;
        [JsonProperty]
        double qty_dec = 0;
        [JsonProperty]
        double mobileqty_dec = 0;
        [JsonProperty]
        double qtyreceived_dec = 0;

        public string Lineno_int
        {
            get
            {
                return lineno_int;
            }

            set
            {
                lineno_int = value;
            }
        }

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

        public string Uom_cod
        {
            get
            {
                return uom_cod;
            }

            set
            {
                uom_cod = value;
            }
        }

        public double Qty_dec
        {
            get
            {
                return qty_dec;
            }

            set
            {
                qty_dec = value;
            }
        }

        public double Mobileqty_dec
        {
            get
            {
                return mobileqty_dec;
            }

            set
            {
                mobileqty_dec = value;
            }
        }

        public double Qtyreceived_dec
        {
            get
            {
                return qtyreceived_dec;
            }

            set
            {
                qtyreceived_dec = value;
            }
        }
    }
}