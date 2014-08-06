namespace UdpTestApp
{
    partial class UdpTest
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OptCustom = new System.Windows.Forms.RadioButton();
            this.OptBroadcast = new System.Windows.Forms.RadioButton();
            this.OptMulticast = new System.Windows.Forms.RadioButton();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.numPacketSize = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButSendPacket = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPacketSize)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "192.168.0.5";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OptCustom);
            this.groupBox1.Controls.Add(this.OptBroadcast);
            this.groupBox1.Controls.Add(this.OptMulticast);
            this.groupBox1.Controls.Add(this.numPort);
            this.groupBox1.Controls.Add(this.numPacketSize);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 106);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Target";
            // 
            // OptCustom
            // 
            this.OptCustom.AutoSize = true;
            this.OptCustom.Location = new System.Drawing.Point(15, 73);
            this.OptCustom.Name = "OptCustom";
            this.OptCustom.Size = new System.Drawing.Size(79, 17);
            this.OptCustom.TabIndex = 5;
            this.OptCustom.Text = "Custom IP :";
            this.OptCustom.UseVisualStyleBackColor = true;
            // 
            // OptBroadcast
            // 
            this.OptBroadcast.AutoSize = true;
            this.OptBroadcast.Location = new System.Drawing.Point(15, 50);
            this.OptBroadcast.Name = "OptBroadcast";
            this.OptBroadcast.Size = new System.Drawing.Size(163, 17);
            this.OptBroadcast.TabIndex = 4;
            this.OptBroadcast.Text = "Broadcast : 255.255.255.255";
            this.OptBroadcast.UseVisualStyleBackColor = true;
            // 
            // OptMulticast
            // 
            this.OptMulticast.AutoSize = true;
            this.OptMulticast.Checked = true;
            this.OptMulticast.Location = new System.Drawing.Point(15, 27);
            this.OptMulticast.Name = "OptMulticast";
            this.OptMulticast.Size = new System.Drawing.Size(133, 17);
            this.OptMulticast.TabIndex = 3;
            this.OptMulticast.TabStop = true;
            this.OptMulticast.Text = "Mutlicast : 224.0.0.251";
            this.OptMulticast.UseVisualStyleBackColor = true;
            // 
            // numPort
            // 
            this.numPort.Location = new System.Drawing.Point(335, 27);
            this.numPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numPort.Name = "numPort";
            this.numPort.Size = new System.Drawing.Size(82, 20);
            this.numPort.TabIndex = 2;
            this.numPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numPort.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // numPacketSize
            // 
            this.numPacketSize.Location = new System.Drawing.Point(335, 52);
            this.numPacketSize.Maximum = new decimal(new int[] {
            1400,
            0,
            0,
            0});
            this.numPacketSize.Name = "numPacketSize";
            this.numPacketSize.Size = new System.Drawing.Size(82, 20);
            this.numPacketSize.TabIndex = 2;
            this.numPacketSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numPacketSize.Value = new decimal(new int[] {
            1400,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Packet Size :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Port :";
            // 
            // ButSendPacket
            // 
            this.ButSendPacket.Location = new System.Drawing.Point(12, 124);
            this.ButSendPacket.Name = "ButSendPacket";
            this.ButSendPacket.Size = new System.Drawing.Size(433, 35);
            this.ButSendPacket.TabIndex = 2;
            this.ButSendPacket.Text = "Send Packet";
            this.ButSendPacket.UseVisualStyleBackColor = true;
            this.ButSendPacket.Click += new System.EventHandler(this.ButSendPacket_Click);
            // 
            // UdpTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 171);
            this.Controls.Add(this.ButSendPacket);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UdpTest";
            this.Text = "SolderSplash : UDP Test App";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPacketSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numPort;
        private System.Windows.Forms.NumericUpDown numPacketSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButSendPacket;
        private System.Windows.Forms.RadioButton OptCustom;
        private System.Windows.Forms.RadioButton OptBroadcast;
        private System.Windows.Forms.RadioButton OptMulticast;
    }
}

