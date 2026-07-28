namespace TTAK_BLZRV2.Entity
{
    public class SalesShipLineE
    {
        //public int sourcedoc_opt { get; set; }
        //public string sourceno_cod { get; set; }
        //public string no_cod { get; set; }
        //public string desc_txt { get; set; }
        //public string uom_cod { get; set; }
        //public double qty_dec { get; set; }
        //public double qtytoship_dec { get; set; }
        //public double qtyshipped_dec { get; set; }
        //public int lineno_int { get; set; }

        //public int doctype_int { get; set; }
        //public string doctypecaption_txt { get; set; }
        //public string docno_cod { get; set; }

        ////public int lineno_int { get; set; }
        //public string type_cod { get; set; }
        //public string typecaption_txt { get; set; }
        ////public string no_cod { get; set; }
        ////public string uom_cod { get; set; }

        //public string shelfno_cod { get; set; }
        ////public double qtyshipped_dec { get; set; }
        ////public string shelfno_cod = string.Empty;
        ///

        //"doctype_int": 1,
        public int doctype_int = 0;
        //"doctypecaption_txt": "Order",
        public string doctypecaption_txt =string.Empty;
        //"docno_cod": "SO13825",
        public string docno_cod =string.Empty;
        //"lineno_int": 70000,
        public int lineno_int = 0;
        //"type_cod": 2,
        public string type_cod =string.Empty;
        //"typecaption_txt": "Item",
        public string typecaption_txt =string.Empty;
        //"no_cod": "T1607714",
        public string no_cod =string.Empty;
        //"uom_cod": "NOS",
        public string uom_cod =string.Empty;
        //"shelfno_cod": "",
        public string shelfno_cod =string.Empty;
        //"qty_dec": 15.0,
        public double qty_dec = 0;
        //"qtytoship_dec": 0.0,
        public double qtytoship_dec = 0;
        //"outstandingqty_dec": 0.0,
        public double outstandingqty_dec = 0;
        //"qtyshipped_dec": 15.0
        public double qtyshipped_dec = 0;

        public string selltocustno_cod = string.Empty;
        public string selltocustname_txt = string.Empty;

        public string itemno_cod = string.Empty;
        public string desc_txt = string.Empty;
        public string location_cod = string.Empty;
        public int entrytype_int = 0;
        public string entrytypecaption_txt = string.Empty;
        public double qtycalculated_dec = 0;
        public double qtyphysinventory_dec = 0;

        public string batchname_cod = string.Empty;
        public string code_cod = string.Empty;
        public string bin_cod = string.Empty;
        //public string qty_dec = string.Empty;
        public string serialno_cod = string.Empty;
        public string lotno_cod = string.Empty;
        public string scancode_cod = string.Empty;
        public string newscancode_cod = string.Empty;
        public string newloccode_cod = string.Empty;
        public string newbin_cod = string.Empty;
    }
}
