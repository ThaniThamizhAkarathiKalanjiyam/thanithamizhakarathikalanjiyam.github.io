using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTake.Entity
{
    public class RestRequestE
    {
        Method objMethod { set; get; }
        IRestRequest[] objIRestRequest { set; get; }
        RestRequestBodyE objRestRequestBodyE { set; get; }

        //AddParameter(string name, object value, ParameterType type)
    }

    public class RestRequestBodyE
    {
        string name { set; get; }
        object value { set; get; }
        ParameterType objParameterType { set; get; }

        //AddParameter(string name, object value, ParameterType type)
    }
}
