using Newtonsoft.Json;

namespace TTAK_BLZRV2.Entity
{

   
    public class RequestJsonE : IStockTakeEntityBase
    {
        
        public FilterE filter = new FilterE();
        /// <summary>
        /// Is used to set the service function module like ItemsF
        /// </summary>
        
        public string urlFunctionName = string.Empty;
        public bool isDataInOptions;
        
        public object data { get; set; }
        
        public int offset { get; set; }
        
        public int limit { get; set; }
        
        public string ins { get; set; }
        
        public bool isLineEinJTable { get; set; }
        
        public string itemNameOrNo { get; set; }
        //
        //public FilterE Filter = new FilterE();

        //public object Data
        //{
        //    get
        //    {
        //        return data;
        //    }

        //    set
        //    {
        //        data = value;
        //    }
        //}

        //public int Offset
        //{
        //    get
        //    {
        //        return offset;
        //    }

        //    set
        //    {
        //        offset = value;
        //    }
        //}

        //public int Limit
        //{
        //    get
        //    {
        //        return limit;
        //    }

        //    set
        //    {
        //        limit = value;
        //    }
        //}


    }
}
