using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTAK_BLZRV2.Entity
{
    public class UploadedFilesByJson
    {
        public ViewDataUploadFilesResult[] files;
        public string TempFolder { get; set; }
        public UploadedFilesByJson(List<ViewDataUploadFilesResult> filesList)
        {
            files = new ViewDataUploadFilesResult[filesList.Count];
            for (int i = 0; i < filesList.Count; i++)
            {
                files[i] = filesList.ElementAt(i);
            }
        }
    }
}
