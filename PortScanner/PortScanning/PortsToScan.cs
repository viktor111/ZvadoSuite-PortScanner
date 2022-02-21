using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortScanner.PortScanning
{
    internal class PortsToScan
    {
        public static List<Port> Ports()
        {
            return new List<Port>
            {
                new Port("FTP", 20),
                new Port("FTP", 21),
                new Port("SSH", 22),
                new Port("Telnet", 23),
                new Port("SMTP", 25),
                new Port("DNS", 53),
                new Port("DNS", 53),
                new Port("Finger protocol", 79),
                new Port("HTTP", 80),
                new Port("Kerberos ", 88),
                new Port("NetBIOS ", 137),
                new Port("IMAP", 143),
                new Port("IMAP", 143),
                new Port("HTTPS", 443),
                new Port("FTPS", 989),
                new Port("FTPS", 990),
                new Port("FTPS", 990),
                new Port("NAS", 991),
                new Port("NAS", 991),
                new Port("Telnet over SSL", 992),
                new Port("MSSQL", 1433),
                new Port("MSSQL", 1434),
                new Port("Oracle Net Services", 1527),
            };
        }
    }
}
