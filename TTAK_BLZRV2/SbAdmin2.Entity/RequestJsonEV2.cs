using Newtonsoft.Json;
using System.Collections.Generic;

namespace TTAK_BLZRV2.Entity
{
    [JsonObject(MemberSerialization.OptIn)]
    public class RequestJsonEV2<T> : IStockTakeEntityBase
    {
        [JsonProperty]
        FilterE filter;
        [JsonProperty]
        List<T> data;
        [JsonProperty]
        int offset;
        [JsonProperty]
        int limit;

        public FilterE Filter
        {
            get
            {
                return filter;
            }

            set
            {
                filter = value;
            }
        }

        public List<T> Data
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
