
namespace LaMetricController.Dialogs
{
    partial class SettingsDialog
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
            this._ipAddressSegment1Input = new System.Windows.Forms.NumericUpDown();
            this._ipAddressSegment2Input = new System.Windows.Forms.NumericUpDown();
            this._ipAddressSegment3Input = new System.Windows.Forms.NumericUpDown();
            this._ipAddressSegment4Input = new System.Windows.Forms.NumericUpDown();
            this._pingButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._apiKeyLabel = new System.Windows.Forms.Label();
            this._apiKeyInput = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this._infoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._ipAddressSegment1Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ipAddressSegment2Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ipAddressSegment3Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ipAddressSegment4Input)).BeginInit();
            this.SuspendLayout();
            // 
            // _ipAddressSegment1Input
            // 
            this._ipAddressSegment1Input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this._ipAddressSegment1Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._ipAddressSegment1Input.ForeColor = System.Drawing.Color.White;
            this._ipAddressSegment1Input.Location = new System.Drawing.Point(32, 64);
            this._ipAddressSegment1Input.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this._ipAddressSegment1Input.Name = "_ipAddressSegment1Input";
            this._ipAddressSegment1Input.Size = new System.Drawing.Size(44, 23);
            this._ipAddressSegment1Input.TabIndex = 2;
            this._ipAddressSegment1Input.ValueChanged += new System.EventHandler(this.Segment1InputValueChange);
            // 
            // _ipAddressSegment2Input
            // 
            this._ipAddressSegment2Input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this._ipAddressSegment2Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._ipAddressSegment2Input.ForeColor = System.Drawing.Color.White;
            this._ipAddressSegment2Input.Location = new System.Drawing.Point(82, 64);
            this._ipAddressSegment2Input.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this._ipAddressSegment2Input.Name = "_ipAddressSegment2Input";
            this._ipAddressSegment2Input.Size = new System.Drawing.Size(44, 23);
            this._ipAddressSegment2Input.TabIndex = 3;
            this._ipAddressSegment2Input.ValueChanged += new System.EventHandler(this.Segment2InputValueChange);
            // 
            // _ipAddressSegment3Input
            // 
            this._ipAddressSegment3Input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this._ipAddressSegment3Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._ipAddressSegment3Input.ForeColor = System.Drawing.Color.White;
            this._ipAddressSegment3Input.Location = new System.Drawing.Point(132, 64);
            this._ipAddressSegment3Input.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this._ipAddressSegment3Input.Name = "_ipAddressSegment3Input";
            this._ipAddressSegment3Input.Size = new System.Drawing.Size(44, 23);
            this._ipAddressSegment3Input.TabIndex = 4;
            this._ipAddressSegment3Input.ValueChanged += new System.EventHandler(this.Segment3InputValueChange);
            // 
            // _ipAddressSegment4Input
            // 
            this._ipAddressSegment4Input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this._ipAddressSegment4Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._ipAddressSegment4Input.ForeColor = System.Drawing.Color.White;
            this._ipAddressSegment4Input.Location = new System.Drawing.Point(182, 64);
            this._ipAddressSegment4Input.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this._ipAddressSegment4Input.Name = "_ipAddressSegment4Input";
            this._ipAddressSegment4Input.Size = new System.Drawing.Size(44, 23);
            this._ipAddressSegment4Input.TabIndex = 5;
            this._ipAddressSegment4Input.ValueChanged += new System.EventHandler(this.Segment4InputValueChange);
            // 
            // _pingButton
            // 
            this._pingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this._pingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._pingButton.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._pingButton.Location = new System.Drawing.Point(242, 64);
            this._pingButton.Name = "_pingButton";
            this._pingButton.Size = new System.Drawing.Size(46, 23);
            this._pingButton.TabIndex = 6;
            this._pingButton.Text = "Ping";
            this._pingButton.UseVisualStyleBackColor = false;
            this._pingButton.Click += new System.EventHandler(this.PingButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "The IP Address of your Clock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Settings";
            // 
            // _apiKeyLabel
            // 
            this._apiKeyLabel.AutoSize = true;
            this._apiKeyLabel.Location = new System.Drawing.Point(32, 112);
            this._apiKeyLabel.Name = "_apiKeyLabel";
            this._apiKeyLabel.Size = new System.Drawing.Size(122, 15);
            this._apiKeyLabel.TabIndex = 9;
            this._apiKeyLabel.Text = "The Developer ApiKey";
            // 
            // _apiKeyInput
            // 
            this._apiKeyInput.Location = new System.Drawing.Point(32, 131);
            this._apiKeyInput.MaxLength = 500;
            this._apiKeyInput.Name = "_apiKeyInput";
            this._apiKeyInput.Size = new System.Drawing.Size(256, 23);
            this._apiKeyInput.TabIndex = 10;
            this._apiKeyInput.TextChanged += new System.EventHandler(this.ApiKeyInputTextChange);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 178);
            this.splitter1.TabIndex = 11;
            this.splitter1.TabStop = false;
            // 
            // _infoLabel
            // 
            this._infoLabel.AutoSize = true;
            this._infoLabel.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._infoLabel.ForeColor = System.Drawing.Color.LightGray;
            this._infoLabel.Location = new System.Drawing.Point(132, 9);
            this._infoLabel.Name = "_infoLabel";
            this._infoLabel.Size = new System.Drawing.Size(175, 12);
            this._infoLabel.TabIndex = 12;
            this._infoLabel.Text = "(Changes will be applied automatically)";
            // 
            // SettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(321, 178);
            this.Controls.Add(this._infoLabel);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this._apiKeyInput);
            this.Controls.Add(this._apiKeyLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._pingButton);
            this.Controls.Add(this._ipAddressSegment1Input);
            this.Controls.Add(this._ipAddressSegment4Input);
            this.Controls.Add(this._ipAddressSegment2Input);
            this.Controls.Add(this._ipAddressSegment3Input);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "SettingsDialog";
            this.ShowInTaskbar = false;
            this.Text = "SettingsDialog";
            ((System.ComponentModel.ISupportInitialize)(this._ipAddressSegment1Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ipAddressSegment2Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ipAddressSegment3Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ipAddressSegment4Input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown _ipAddressSegment1Input;
        private System.Windows.Forms.NumericUpDown _ipAddressSegment2Input;
        private System.Windows.Forms.NumericUpDown _ipAddressSegment3Input;
        private System.Windows.Forms.NumericUpDown _ipAddressSegment4Input;
        private System.Windows.Forms.Button _pingButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label _apiKeyLabel;
        private System.Windows.Forms.TextBox _apiKeyInput;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label _infoLabel;
    }
}