using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace StockTake.Entity
{
    //public static class AppConfigs
    //{
    //    public static string BaseController = ConfigurationManager.AppSettings["BaseController"];
    //    //public static string GetBaseUrl()
    //    //{
    //    //    var request = HttpContext.Current.Request;
    //    //    var appUrl = HttpRuntime.AppDomainAppVirtualPath;

    //    //    if (appUrl != "/")
    //    //        appUrl = "/" + appUrl;

    //    //    var baseUrl = string.Format("{0}://{1}{2}", request.Url.Scheme, request.Url.Authority, appUrl);
    //    //    return baseUrl;
    //    //}

    //    public static string GetBaseUrl()
    //    {
    //        var request = HttpContext.Current.Request;
    //        var appUrl = HttpRuntime.AppDomainAppVirtualPath;

    //        if (appUrl != "/")
    //        {
    //            //appUrl = "/" + appUrl;
    //            appUrl = "/" + appUrl;
    //            appUrl = appUrl.Replace("//","/");
    //        }
    //        var baseUrl = string.Format("{0}://{1}{2}", request.Url.Scheme, request.Url.Authority, appUrl);

    //        return baseUrl;
    //    }
    //}
}
