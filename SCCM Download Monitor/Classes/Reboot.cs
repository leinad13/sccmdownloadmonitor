using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCCM_Download_Monitor.Classes
{
    class Reboot
    {
        public bool CBServicing { get; set; }
        public bool WindowsUpdate { get; set; }
        public bool CCMClientSDK { get; set; }
        public bool PendingComputerRename { get; set; }
        public bool PendingFileRename { get; set; }

        public List<string> PendingFiles { get; set; }

        public Reboot() { }

        public Reboot(bool cBServicing, bool windowsUpdate, bool cCMClientSDK, bool pendingComputerRename, bool pendingFileRename, List<string> pendingFiles)
        {
            CBServicing = cBServicing;
            WindowsUpdate = windowsUpdate;
            CCMClientSDK = cCMClientSDK;
            PendingComputerRename = pendingComputerRename;
            PendingFileRename = pendingFileRename;
            PendingFiles = pendingFiles;
        }

        public bool GetPendingReboot
        {
            get
            {
                // If any of the local bool's are true, then return true - machine IS pending a reboot
                if ((CBServicing? 1:0) + (WindowsUpdate? 1:0) + (CCMClientSDK? 1:0) + (PendingComputerRename? 1:0) + (PendingFileRename? 1:0) > 0)
                {
                    return true;
                } else
                {
                    return false;
                }
            }
        }

    }
}
