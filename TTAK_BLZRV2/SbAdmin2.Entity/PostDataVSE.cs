using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace TTAK_BLZRV2.Entity
{
    public class PostDataVSE<RecordsClass>
    {
        public string Mode = string.Empty;
        public List<RecordsClass> Records = new List<RecordsClass>();
        public string Result = string.Empty;
        public string Message = string.Empty;
        public int TotalRecordCount = 0;
    }
    public class PostDataVSE
    {
        public string Mode = string.Empty;
        public object Records = new object();
        public string Result = string.Empty;
        public string Sql = string.Empty;
        public string Message = string.Empty;
        public int TotalRecordCount = 0;
        public JObject Parent = new JObject();
    }
}
