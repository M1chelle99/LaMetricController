using LaMetricController;

namespace LaMetricController.Views
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._reloadButton = new System.Windows.Forms.Button();
            this._notifyButton = new System.Windows.Forms.Button();
            this._settingsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _reloadButton
            // 
            this._reloadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this._reloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._reloadButton.Location = new System.Drawing.Point(33, 25);
            this._reloadButton.Name = "_reloadButton";
            this._reloadButton.Size = new System.Drawing.Size(150, 29);
            this._reloadButton.TabIndex = 0;
            this._reloadButton.Text = "Reload Config";
            this._reloadButton.UseVisualStyleBackColor = false;
            this._reloadButton.Click += new System.EventHandler(this.ReloadButtonClick);
            // 
            // _notifyButton
            // 
            this._notifyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this._notifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._notifyButton.Location = new System.Drawing.Point(33, 72);
            this._notifyButton.Name = "_notifyButton";
            this._notifyButton.Size = new System.Drawing.Size(150, 28);
            this._notifyButton.TabIndex = 1;
            this._notifyButton.Text = "Send Notification";
            this._notifyButton.UseVisualStyleBackColor = false;
            this._notifyButton.Click += new System.EventHandler(this.NotifyButtonClick);
            // 
            // _settingsButton
            // 
            this._settingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this._settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._settingsButton.Location = new System.Drawing.Point(33, 120);
            this._settingsButton.Name = "_settingsButton";
            this._settingsButton.Size = new System.Drawing.Size(150, 28);
            this._settingsButton.TabIndex = 2;
            this._settingsButton.Text = "Settings";
            this._settingsButton.UseVisualStyleBackColor = false;
            this._settingsButton.Click += new System.EventHandler(this.SettingsButtonClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._settingsButton);
            this.Controls.Add(this._notifyButton);
            this.Controls.Add(this._reloadButton);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "MainForm";
            this.Text = "LaMetric Controller";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _reloadButton;
        private System.Windows.Forms.Button _notifyButton;
        private System.Windows.Forms.Button _settingsButton;
    }
}

