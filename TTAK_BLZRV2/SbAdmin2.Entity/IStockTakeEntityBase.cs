using Newtonsoft.Json;

namespace TTAK_BLZRV2.Entity
{
    //All classes derived from this class, so every class will derived from this class

    public abstract class IStockTakeEntityBase
    {
        public virtual string getJsonString()
        {
            string json = JsonConvert.SerializeObject(this, Formatting.None);

            return json;
        }

        public virtual string getJsonString(object data)
        {
            string json = JsonConvert.SerializeObject(data, Formatting.None);

            return json;
        }
    }
}
