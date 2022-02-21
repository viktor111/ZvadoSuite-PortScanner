namespace PortScanner
{
    partial class ScanResults
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
            this.PortsListView = new System.Windows.Forms.ListView();
            this.NameHeader = new System.Windows.Forms.ColumnHeader();
            this.PortHeader = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalPortsScannedResutlLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IpAddressResultLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TimeTakenResultLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DateResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PortsListView
            // 
            this.PortsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameHeader,
            this.PortHeader});
            this.PortsListView.Location = new System.Drawing.Point(12, 93);
            this.PortsListView.Name = "PortsListView";
            this.PortsListView.Size = new System.Drawing.Size(267, 398);
            this.PortsListView.TabIndex = 0;
            this.PortsListView.UseCompatibleStateImageBehavior = false;
            this.PortsListView.View = System.Windows.Forms.View.Details;
            // 
            // NameHeader
            // 
            this.NameHeader.Text = "Name";
            this.NameHeader.Width = 100;
            // 
            // PortHeader
            // 
            this.PortHeader.Text = "Port";
            this.PortHeader.Width = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Ports Scanned:";
            // 
            // TotalPortsScannedResutlLabel
            // 
            this.TotalPortsScannedResutlLabel.AutoSize = true;
            this.TotalPortsScannedResutlLabel.Location = new System.Drawing.Point(131, 9);
            this.TotalPortsScannedResutlLabel.Name = "TotalPortsScannedResutlLabel";
            this.TotalPortsScannedResutlLabel.Size = new System.Drawing.Size(13, 15);
            this.TotalPortsScannedResutlLabel.TabIndex = 2;
            this.TotalPortsScannedResutlLabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ip Address:";
            // 
            // IpAddressResultLabel
            // 
            this.IpAddressResultLabel.AutoSize = true;
            this.IpAddressResultLabel.Location = new System.Drawing.Point(83, 24);
            this.IpAddressResultLabel.Name = "IpAddressResultLabel";
            this.IpAddressResultLabel.Size = new System.Drawing.Size(13, 15);
            this.IpAddressResultLabel.TabIndex = 4;
            this.IpAddressResultLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Time Taken:";
            // 
            // TimeTakenResultLabel
            // 
            this.TimeTakenResultLabel.AutoSize = true;
            this.TimeTakenResultLabel.Location = new System.Drawing.Point(83, 39);
            this.TimeTakenResultLabel.Name = "TimeTakenResultLabel";
            this.TimeTakenResultLabel.Size = new System.Drawing.Size(13, 15);
            this.TimeTakenResultLabel.TabIndex = 6;
            this.TimeTakenResultLabel.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Scan Compleated At:";
            // 
            // DateResultLabel
            // 
            this.DateResultLabel.AutoSize = true;
            this.DateResultLabel.Location = new System.Drawing.Point(131, 54);
            this.DateResultLabel.Name = "DateResultLabel";
            this.DateResultLabel.Size = new System.Drawing.Size(13, 15);
            this.DateResultLabel.TabIndex = 8;
            this.DateResultLabel.Text = "0";
            // 
            // ScanResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 505);
            this.Controls.Add(this.DateResultLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TimeTakenResultLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IpAddressResultLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TotalPortsScannedResutlLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PortsListView);
            this.Name = "ScanResults";
            this.Text = "ScanResults";
            this.Load += new System.EventHandler(this.ScanResults_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView PortsListView;
        private ColumnHeader NameHeader;
        private ColumnHeader PortHeader;
        private Label label1;
        private Label TotalPortsScannedResutlLabel;
        private Label label2;
        private Label IpAddressResultLabel;
        private Label label4;
        private Label TimeTakenResultLabel;
        private Label label6;
        private Label DateResultLabel;
    }
}