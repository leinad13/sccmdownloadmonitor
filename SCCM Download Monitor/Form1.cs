using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Management;
using System.Threading;
using System.Threading.Tasks;
using SCCM_Download_Monitor.Classes;
using System.Security.Principal;
using System.Diagnostics;

namespace SCCM_Download_Monitor
{
    public partial class Form1 : Form
    {
        private readonly SynchronizationContext syncContext;
        public Form1()
        {
            InitializeComponent();
            syncContext = SynchronizationContext.Current;
        }

        public bool CheckIfElevated()
        {
            try
            {
                WindowsIdentity userIdentity = WindowsIdentity.GetCurrent();
                WindowsPrincipal userPrincipal = new WindowsPrincipal(userIdentity);

                if (userPrincipal.IsInRole(WindowsBuiltInRole.Administrator))
                    return true;

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to determine if Application is running as Administrator: " + ex.Message);
                //Log("Unable to determine whether Application is running Elevated. Error: " + ex.Message);
                return false;
            }
        }

        private bool PingMachine(string hostname)
        {
            try
            {
                Ping p = new Ping();
                PingReply r;
                r = p.Send(hostname);
                if (r.Status == IPStatus.Success)
                {
                    lbLog.Items.Add(hostname + " is Online");
                    return true;
                } else
                {

                    return false;
                }

            } catch (Exception e)
            {
                lbLog.Items.Add("Problem connecting to " + hostname);
                return false;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // Only try to connect if Ping works
            if (PingMachine(tbHostname.Text))
            {
                var initialWMIResult = await InitialWMIConnect(tbHostname.Text);
                lbLog.Items.Add(initialWMIResult);
                List<CTMDownloadHistory> list = await GetDownloadHistory(tbHostname.Text);
                lbLog.Items.Add(list[0].ContentID);
                
            }
        }

        private async Task<string> InitialWMIConnect(string hostname)
        {
            return await Task.Run(() =>
            {
                ConnectionOptions options = new ConnectionOptions();
                options.Impersonation = System.Management.ImpersonationLevel.Impersonate;

                ManagementScope scope = new ManagementScope("\\\\" + hostname + "\\root\\cimv2", options);
                scope.Connect();

                ObjectQuery query = new ObjectQuery("select * from Win32_OperatingSystem");
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);

                ManagementObjectCollection queryCollection = searcher.Get();
                foreach (ManagementObject m in queryCollection)
                {
                    return "WMI Connected - OS = " + m["Caption"];
                }
                return "Problem getting OS info";
            });
        }

        private async Task<List<CTMDownloadHistory>> GetDownloadHistory(string hostname)
        {
            return await Task.Run(() =>
            {
                ConnectionOptions options = new ConnectionOptions();
                options.Impersonation = System.Management.ImpersonationLevel.Impersonate;

                ManagementScope scope = new ManagementScope("\\\\" + hostname + "\\root\\ccm\\ContentTransferManager", options);
                scope.Connect();

                ObjectQuery query = new ObjectQuery("select * from CCM_CTM_DownloadHistory");
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);

                ManagementObjectCollection queryCollection = searcher.Get();
                List<CTMDownloadHistory> list = new List<CTMDownloadHistory>();
                foreach (ManagementObject m in queryCollection)
                {
                    CTMDownloadHistory obj = new CTMDownloadHistory();
                    obj.BytesDownloaded = (UInt64)m["BytesDownloaded"];
                    obj.ContentID = (string)m["ContentID"];
                    obj.CTMJobID = (string)m["CTMJobID"];
                    obj.DownloadSource = (string)m["DownloadSource"];
                    obj.DownloadType = (UInt32)m["DownloadType"];
                    obj.StartTime = (string)m["StartTime"];

                    list.Add(obj);
                }
                return list;
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Check if running as admin, and relaunch if not.
            if (CheckIfElevated() == false)
            {
                string myPath = System.Reflection.Assembly.GetExecutingAssembly().Location;

                // Restart program and run as admin
                ProcessStartInfo startInfo = new ProcessStartInfo(myPath);
                startInfo.Verb = "runas";
                System.Diagnostics.Process.Start(startInfo);
                Application.Exit();
                return;
            }
        }
    }
}
