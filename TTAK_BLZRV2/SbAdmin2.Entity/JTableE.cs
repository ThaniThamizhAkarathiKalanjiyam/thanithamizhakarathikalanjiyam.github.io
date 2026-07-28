using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTAK_BLZRV2.Entity
{
    public class JTableE
    {

        public string Result { get; set; }

        /// <summary>
        /// A URL to redirect the page when an ajax request to the server returns with UnAuthorizedRequest = true or HTTP status 401. If this option is not set, jTable refresh the page when server returns UnAuthorizedRequest = true or HTTP status 401.
        /// </summary>
        public bool UnAuthorizedRequest { get; set; }

        public object Records { get; set; }

        public int TotalRecordCount { get; set; }

        public string Message { get; set; }

        public int JtStartIndex { get; set; }

        public int JtPageSize { get; set; }
    }


}
