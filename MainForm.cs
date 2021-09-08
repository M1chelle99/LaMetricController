using LaMetricController.Dialogs;
using LaMetricController.Services;
using System;
using System.Windows.Forms;

namespace LaMetricController.Views
{
    public partial class MainForm : Form
    {
        private readonly ConfigurationService _config;
        private readonly MessageService _messageService;

        public MainForm(
            ConfigurationService config,
            MessageService messageService)
        {
            InitializeComponent();
            _config = config;
            _messageService = messageService;
        }

        private void NotifyButtonClick(object sender, EventArgs e)
        {
            using var dialogForm = new NotificationDialog();
            var result = dialogForm.ShowDialog(this);
            if (result != DialogResult.OK) return;

            var ipAddress = _config.LastSessionInfo.IPAddress;
            var notification = dialogForm.Notification;
            var icon = dialogForm.IconNumber;

            _messageService
                .SendNotification(notification, icon)
                .Wait();
        }

        private void SettingsButtonClick(object sender, EventArgs e)
        {
            using var dialogForm = new SettingsDialog(_config);
            dialogForm.ShowDialog(Owner);
        }

        private void ReloadButtonClick(object sender, EventArgs e)
        {
            _config.Load();
        }
    }
}
