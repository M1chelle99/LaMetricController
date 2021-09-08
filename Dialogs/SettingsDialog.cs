using LaMetricController.Services;
using System;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaMetricController.Dialogs
{
    public partial class SettingsDialog : Form
    {
        private readonly ConfigurationService _config;

        public SettingsDialog(ConfigurationService config)
        {
            InitializeComponent();
            _config = config;
        }

        public int IPSegment1 { get; set; }
        public int IPSegment2 { get; set; }
        public int IPSegment3 { get; set; }
        public int IPSegment4 { get; set; }

        public string IPAddress { get; set; }
        public string ApiKey { get; set; }

        private void ApiKeyInputTextChange(object sender, EventArgs e)
        {
            ApiKey = _apiKeyInput.Text.Trim();
            SaveConfiguration();
        }

        private void Segment1InputValueChange(object sender, EventArgs e)
        {
            IPSegment1 = (int)_ipAddressSegment1Input.Value;
            BuildIPAddress();
            SaveConfiguration();
        }

        private void Segment2InputValueChange(object sender, EventArgs e)
        {
            IPSegment2 = (int)_ipAddressSegment2Input.Value;
            BuildIPAddress();
            SaveConfiguration();
        }

        private void Segment3InputValueChange(object sender, EventArgs e)
        {
            IPSegment3 = (int)_ipAddressSegment3Input.Value;
            BuildIPAddress();
            SaveConfiguration();
        }

        private void Segment4InputValueChange(object sender, EventArgs e)
        {
            IPSegment4 = (int)_ipAddressSegment4Input.Value;
            BuildIPAddress();
            SaveConfiguration();
        }

        private void SaveConfiguration()
        {
            _config.LastSessionInfo.ApiKey = ApiKey;
            _config.LastSessionInfo.IPAddress = IPAddress;
            _config.Save();            
        }

        private void BuildIPAddress()
        {
            if (IPSegment1 == 0
                && IPSegment2 == 0
                && IPSegment3 == 0
                && IPSegment4 == 0)
                IPAddress = null;
            else
                IPAddress = $"{IPSegment1}.{IPSegment2}.{IPSegment3}.{IPSegment4}";
        }

        private void PingButtonClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IPAddress)) return;

            SetIPInputsEnabledState(false);

            if (GetPingResult().GetAwaiter().GetResult())
                MessageBox.Show(Owner, "Ping resulted in a good response.", "Ping Response", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(Owner, "Ping resulted in a bad response.", "Ping Response", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            SetIPInputsEnabledState(true);
        }

        private delegate void SetIPInputsEnabledStateDelegate(bool state);
        private void SetIPInputsEnabledState(bool state)
        {
            if (InvokeRequired)
            {
                Invoke(new SetIPInputsEnabledStateDelegate(SetIPInputsEnabledState), new[] { state });
                return;
            }

            _ipAddressSegment1Input.Enabled = state;
            _ipAddressSegment2Input.Enabled = state;
            _ipAddressSegment3Input.Enabled = state;
            _ipAddressSegment4Input.Enabled = state;
        }

        private Task<bool> GetPingResult()
        {
            var tcs = new TaskCompletionSource<bool>();

            Task.Factory.StartNew(() =>
            {
                try
                {
                    using var pinger = new Ping();
                    var pingable = pinger
                        .Send(IPAddress, 10 * 1000)
                        .Status == IPStatus.Success;

                    tcs.SetResult(pingable);
                }
                catch (PingException)
                {
                    tcs.SetResult(false);
                }
            });

            return tcs.Task;
        }
    }
}
