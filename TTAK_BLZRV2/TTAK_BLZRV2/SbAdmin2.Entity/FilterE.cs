using Newtonsoft.Json;

namespace TTAK_BLZRV2.Entity
{
    public class FilterE
    {
        public string userid_cod = string.Empty;
        public string funcname_txt = string.Empty;
        public string companyname_txt = string.Empty;
        
        public string getJsonString()
        {
            string json = JsonConvert.SerializeObject(this, Formatting.None);

            return json;
        }
    }
}
