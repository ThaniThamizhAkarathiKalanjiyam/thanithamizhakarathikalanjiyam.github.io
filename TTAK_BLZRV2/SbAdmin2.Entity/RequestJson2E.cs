using Newtonsoft.Json;

namespace TTAK_BLZRV2.Entity
{
    [JsonObject(MemberSerialization.OptIn)]
    public class RequestJson2E<T> : IStockTakeEntityBase
    {
        [JsonProperty]
       public FilterE filter;
        [JsonProperty]
        T data;
        [JsonProperty]
        int offset;
        [JsonProperty]
        int limit;
        [JsonProperty]
        public string ins { get; set; }
        [JsonProperty]
        public bool isLineEinJTable { get; set; }
        [JsonProperty]
        public string itemNameOrNo { get; set; }

       

        public T Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }

        public int Offset
        {
            get
            {
                return offset;
            }

            set
            {
                offset = value;
            }
        }

        public int Limit
        {
            get
            {
                return limit;
            }

            set
            {
                limit = value;
            }
        }


    }
}
