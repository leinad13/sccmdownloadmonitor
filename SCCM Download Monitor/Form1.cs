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
                // Connect to WMI and get the OS Name
                var initialWMIResult = await InitialWMIConnect(tbHostname.Text);
                lbLog.Items.Add(initialWMIResult);

                // Connect to WMI and get the SCCM Content Download History
                SortableBindingList<CTMDownloadHistory> list = await GetDownloadHistory(tbHostname.Text);

                // Set datagrid datasource to the list returned and sort by date descending
                dgPreviousDownloads.DataSource = list;
                dgPreviousDownloads.Sort(dgPreviousDownloads.Columns[5], ListSortDirection.Descending);

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

        private async Task<SortableBindingList<CTMDownloadHistory>> GetDownloadHistory(string hostname)
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
                SortableBindingList<CTMDownloadHistory> list = new SortableBindingList<CTMDownloadHistory>();
                foreach (ManagementObject m in queryCollection)
                {
                    CTMDownloadHistory obj = new CTMDownloadHistory(m["BytesDownloaded"], m["ContentID"], m["CTMJobID"], m["DownloadSource"], m["DownloadType"], m["StartTime"]);
                    list.Add(obj);
                }
                return list;
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set some DataGridViewProperties
            dgPreviousDownloads.AutoGenerateColumns = true;
            dgPreviousDownloads.ReadOnly = true;
            dgPreviousDownloads.AllowUserToAddRows = false;

            //// Check if running as admin, and relaunch if not.
            //if (CheckIfElevated() == false)
            //{
            //    string myPath = System.Reflection.Assembly.GetExecutingAssembly().Location;

            //    // Restart program and run as admin
            //    ProcessStartInfo startInfo = new ProcessStartInfo(myPath);
            //    startInfo.Verb = "runas";
            //    System.Diagnostics.Process.Start(startInfo);
            //    Application.Exit();
            //    return;
            //}
        }
    }
}
