using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace SCCM_Download_Monitor.Classes
{
    class CTMDownloadHistory
    {
        

        public UInt64 BytesDownloaded { get; set; }
        public string ContentID { get; set; }
        public string CTMJobID { get; set; }
        public string DownloadSource { get; set; }
        public UInt32 DownloadType { get; set; }
        public DateTime StartTime { get; set; }

        public string ApplicationName { get; set; }

        public CTMDownloadHistory(object bytesDownloaded, object contentID, object cTMJobID, object downloadSource, object downloadType, object startTime)
        {
            this.BytesDownloaded = (ulong)bytesDownloaded;
            ContentID = (string)contentID;
            CTMJobID = (string)cTMJobID;
            DownloadSource = (string)downloadSource;
            DownloadType = (UInt32)downloadType;
            StartTime = ManagementDateTimeConverter.ToDateTime((string)startTime);
            ApplicationName = "";
        }

        public CTMDownloadHistory() { }

    }
}
