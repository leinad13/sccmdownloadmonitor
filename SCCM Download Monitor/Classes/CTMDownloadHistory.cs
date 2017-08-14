using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCCM_Download_Monitor.Classes
{
    class CTMDownloadHistory
    {
        public UInt64 BytesDownloaded;
        public String ContentID;
        public String CTMJobID;
        public String DownloadSource;
        public UInt32 DownloadType;
        public string StartTime;
    }
}
