using PortScanner.PortScanning;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortScanner
{
    public partial class ScanResults : Form
    {
        private ScanResultsModel results { get; set; }

        public ScanResults(ScanResultsModel results)
        {
            this.results = results;
            InitializeComponent();
        }

        private void ScanResults_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void LoadData()
        {
            var scanner = new Scanner();           

            for (int i = 0; i < results.OpenPorts.Count; i++)
            {
                var port = results.OpenPorts[i];
                var row = new string[] { port.Name, port.PortNumber.ToString()};
                var listViewItem = new ListViewItem(row);
                PortsListView.Items.Add(listViewItem);
            }

            TotalPortsScannedResutlLabel.Text = results.ScannedPortsCount.ToString();
           // IpAddressResultLabel.Text = results.;

            var ts = results.TimeTakenToScan;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);

            Console.WriteLine("RunTime " + elapsedTime);
            TimeTakenResultLabel.Text = elapsedTime;
            DateResultLabel.Text = results.ScannedAt.ToString();
        }
    }
}
