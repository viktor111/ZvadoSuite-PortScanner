using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace PortScanner.PortScanning
{
    internal class Scanner
    {
        public async Task<ScanResultsModel> Scan(string ip)
        {           
            var ports = new List<Port>();

            var tcpClient = new TcpClient();
            var stopWatch = new Stopwatch();

            var ipAddress =  IPAddress.Parse(ip);

            var portsToScan = PortsToScan.Ports();

            stopWatch.Start();

            for (int i = 0; i < portsToScan.Count; i++)
            {
                var port = portsToScan[i];
                try
                {
                    await tcpClient.ConnectAsync(ipAddress, port.PortNumber);

                    port.Open = true;
                }
                catch (Exception)
                {
                    port.Open = false;
                }
                ports.Add(port);
            }
            tcpClient.Close();

            var elapsedtime = stopWatch.Elapsed;

            var results = new ScanResultsModel();
            results.OpenPorts = ports.Where(p => p.Open == true).ToList();
            results.ScannedPortsCount = portsToScan.Count;
            results.ScannedAt = DateTime.Now;
            results.TimeTakenToScan = elapsedtime;
            results.Ip = ip;

            return results;
        }
    }
}
