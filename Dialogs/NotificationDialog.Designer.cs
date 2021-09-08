
namespace LaMetricController.Dialogs
{
    partial class NotificationDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._notificationInput = new System.Windows.Forms.TextBox();
            this._notificationLabel = new System.Windows.Forms.Label();
            this._iconNumberLabel = new System.Windows.Forms.Label();
            this._iconNumberInput = new System.Windows.Forms.TextBox();
            this._submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _notificationInput
            // 
            this._notificationInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this._notificationInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._notificationInput.ForeColor = System.Drawing.Color.White;
            this._notificationInput.Location = new System.Drawing.Point(118, 20);
            this._notificationInput.Name = "_notificationInput";
            this._notificationInput.Size = new System.Drawing.Size(136, 23);
            this._notificationInput.TabIndex = 0;
            this._notificationInput.TabStop = false;
            this._notificationInput.WordWrap = false;
            this._notificationInput.TextChanged += new System.EventHandler(this.NotificationInputTextChange);
            // 
            // _notificationLabel
            // 
            this._notificationLabel.AutoSize = true;
            this._notificationLabel.Location = new System.Drawing.Point(23, 23);
            this._notificationLabel.Name = "_notificationLabel";
            this._notificationLabel.Size = new System.Drawing.Size(73, 15);
            this._notificationLabel.TabIndex = 1;
            this._notificationLabel.Text = "Notification:";
            // 
            // _iconNumberLabel
            // 
            this._iconNumberLabel.AutoSize = true;
            this._iconNumberLabel.Location = new System.Drawing.Point(23, 59);
            this._iconNumberLabel.Name = "_iconNumberLabel";
            this._iconNumberLabel.Size = new System.Drawing.Size(80, 15);
            this._iconNumberLabel.TabIndex = 2;
            this._iconNumberLabel.Text = "Icon Number:";
            // 
            // _iconNumberInput
            // 
            this._iconNumberInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this._iconNumberInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._iconNumberInput.ForeColor = System.Drawing.Color.White;
            this._iconNumberInput.Location = new System.Drawing.Point(118, 56);
            this._iconNumberInput.MaxLength = 6;
            this._iconNumberInput.Name = "_iconNumberInput";
            this._iconNumberInput.Size = new System.Drawing.Size(136, 23);
            this._iconNumberInput.TabIndex = 3;
            this._iconNumberInput.Text = "2867";
            this._iconNumberInput.TextChanged += new System.EventHandler(this.IconNumberInputChange);
            // 
            // _submitButton
            // 
            this._submitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this._submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._submitButton.Location = new System.Drawing.Point(27, 98);
            this._submitButton.Name = "_submitButton";
            this._submitButton.Size = new System.Drawing.Size(227, 25);
            this._submitButton.TabIndex = 4;
            this._submitButton.Text = "Send Notification";
            this._submitButton.UseVisualStyleBackColor = false;
            this._submitButton.Click += new System.EventHandler(this.SubmitButtonClick);
            // 
            // NotificationDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(282, 135);
            this.Controls.Add(this._submitButton);
            this.Controls.Add(this._iconNumberInput);
            this.Controls.Add(this._iconNumberLabel);
            this.Controls.Add(this._notificationLabel);
            this.Controls.Add(this._notificationInput);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "NotificationDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NotificationDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _notificationInput;
        private System.Windows.Forms.Label _notificationLabel;
        private System.Windows.Forms.Label _iconNumberLabel;
        private System.Windows.Forms.TextBox _iconNumberInput;
        private System.Windows.Forms.Button _submitButton;
    }
}