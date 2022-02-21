using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortScanner.PortScanning
{
    public class ScanResultsModel
    {
        public List<Port> OpenPorts { get; set; }

        public int ScannedPortsCount { get; set; }

        public DateTime ScannedAt { get; set; }

        public TimeSpan TimeTakenToScan { get; set; }

        public string Ip { get; set; }
    }
}
