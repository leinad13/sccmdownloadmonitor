using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCCM_Download_Monitor.Classes
{
    class SCCMSiteDetails
    {
        public SCCMSiteDetails(string siteServer, string siteCode)
        {
            SiteServer = siteServer;
            SiteCode = siteCode;
        }

        public string SiteServer { get; set; }
        public string SiteCode { get; set; }
    }
}
