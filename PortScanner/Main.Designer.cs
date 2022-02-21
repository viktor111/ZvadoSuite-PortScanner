namespace PortScanner
{
    partial class Main
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
            this.BeginScanButton = new System.Windows.Forms.Button();
            this.IpAddressTextBox = new System.Windows.Forms.TextBox();
            this.IpAddressLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BeginScanButton
            // 
            this.BeginScanButton.Location = new System.Drawing.Point(77, 41);
            this.BeginScanButton.Name = "BeginScanButton";
            this.BeginScanButton.Size = new System.Drawing.Size(75, 23);
            this.BeginScanButton.TabIndex = 0;
            this.BeginScanButton.Text = "Scan";
            this.BeginScanButton.UseVisualStyleBackColor = true;
            this.BeginScanButton.Click += new System.EventHandler(this.BeginScanButton_Click);
            // 
            // IpAddressTextBox
            // 
            this.IpAddressTextBox.Location = new System.Drawing.Point(77, 12);
            this.IpAddressTextBox.Name = "IpAddressTextBox";
            this.IpAddressTextBox.Size = new System.Drawing.Size(170, 23);
            this.IpAddressTextBox.TabIndex = 1;
            // 
            // IpAddressLabel
            // 
            this.IpAddressLabel.AutoSize = true;
            this.IpAddressLabel.Location = new System.Drawing.Point(12, 20);
            this.IpAddressLabel.Name = "IpAddressLabel";
            this.IpAddressLabel.Size = new System.Drawing.Size(59, 15);
            this.IpAddressLabel.TabIndex = 2;
            this.IpAddressLabel.Text = "IpAddress";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 84);
            this.Controls.Add(this.IpAddressLabel);
            this.Controls.Add(this.IpAddressTextBox);
            this.Controls.Add(this.BeginScanButton);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BeginScanButton;
        private TextBox IpAddressTextBox;
        private Label IpAddressLabel;
    }
}