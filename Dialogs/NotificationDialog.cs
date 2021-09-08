using System;
using System.Windows.Forms;

namespace LaMetricController.Dialogs
{
    public partial class NotificationDialog : Form
    {
        public NotificationDialog()
        {
            InitializeComponent();
        }

        public string Notification { get; set; }
        public int IconNumber { get; set; }

        private void IconNumberInputChange(object sender, EventArgs e)
        {
            if (int.TryParse(_iconNumberInput.Text.Trim(), out int icon))
                IconNumber = icon;

            ValidateInputs();
        }

        private void NotificationInputTextChange(object sender, EventArgs e)
        {
            Notification = _notificationInput.Text.Trim();
            ValidateInputs();
        }

        private void ValidateInputs()
        {
            if (IsValid())
                _submitButton.Enabled = true;
            else
                _submitButton.Enabled = false;
        }

        private bool IsValid()
        {
            if (string.IsNullOrWhiteSpace(_submitButton.Text)) return false;
            if (string.IsNullOrWhiteSpace(_iconNumberInput.Text)) return false;
            if (!int.TryParse(_iconNumberInput.Text.Trim(), out var _)) return false;
            if (IconNumber < 0) return false;

            return true;
        }

        private void SubmitButtonClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
