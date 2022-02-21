using PortScanner.PortScanning;
using System.Text.RegularExpressions;

namespace PortScanner
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private async void BeginScanButton_Click(object sender, EventArgs e)
        {
            var ip = IpAddressTextBox.Text;
            var ipRegex = @"\b((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)(\.|$)){4}\b";

            var match = Regex.Match(ip, ipRegex, RegexOptions.IgnoreCase);

            if (string.IsNullOrEmpty(ip) || !match.Success)
            {
                MessageBox.Show("Enter a valid IP address!");
                return;
            }
            var scanner = new Scanner();

            MessageBox.Show("Started scanning it might take a few minutes!");
            var results = await scanner.Scan(ip);
            var scanResults = new ScanResults(results);
            scanResults.Show();
        }        
    }
}