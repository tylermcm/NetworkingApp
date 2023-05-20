namespace P2PNetworkApp
{
    partial class Form1
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
            this.receiveBox = new System.Windows.Forms.TextBox();
            this.sendBox = new System.Windows.Forms.TextBox();
            this.ipBox1 = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.portBox1 = new System.Windows.Forms.TextBox();
            this.ipBox2 = new System.Windows.Forms.TextBox();
            this.portBox2 = new System.Windows.Forms.TextBox();
            this.IpLabel1 = new System.Windows.Forms.Label();
            this.IpLabel2 = new System.Windows.Forms.Label();
            this.PortLabel1 = new System.Windows.Forms.Label();
            this.PortLabel2 = new System.Windows.Forms.Label();
            this.ClientLabel1 = new System.Windows.Forms.Label();
            this.ClientLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // receiveBox
            // 
            this.receiveBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.receiveBox.Location = new System.Drawing.Point(22, 143);
            this.receiveBox.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.receiveBox.MaxLength = 5000000;
            this.receiveBox.Multiline = true;
            this.receiveBox.Name = "receiveBox";
            this.receiveBox.ReadOnly = true;
            this.receiveBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.receiveBox.Size = new System.Drawing.Size(623, 425);
            this.receiveBox.TabIndex = 10;
            this.receiveBox.TabStop = false;
            // 
            // sendBox
            // 
            this.sendBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.sendBox.Location = new System.Drawing.Point(22, 591);
            this.sendBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.sendBox.MaxLength = 5000000;
            this.sendBox.Multiline = true;
            this.sendBox.Name = "sendBox";
            this.sendBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sendBox.Size = new System.Drawing.Size(543, 40);
            this.sendBox.TabIndex = 3;
            this.sendBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sendBox_KeyPress);
            // 
            // ipBox1
            // 
            this.ipBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ipBox1.Location = new System.Drawing.Point(72, 43);
            this.ipBox1.Margin = new System.Windows.Forms.Padding(3, 20, 10, 3);
            this.ipBox1.MaxLength = 45;
            this.ipBox1.Multiline = true;
            this.ipBox1.Name = "ipBox1";
            this.ipBox1.Size = new System.Drawing.Size(157, 27);
            this.ipBox1.TabIndex = 1;
            // 
            // connectButton
            // 
            this.connectButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.connectButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.connectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.connectButton.Location = new System.Drawing.Point(550, 59);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(95, 40);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // sendButton
            // 
            this.sendButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sendButton.Location = new System.Drawing.Point(571, 591);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(74, 40);
            this.sendButton.TabIndex = 12;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // portBox1
            // 
            this.portBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.portBox1.Location = new System.Drawing.Point(72, 93);
            this.portBox1.Margin = new System.Windows.Forms.Padding(3, 20, 10, 3);
            this.portBox1.MaxLength = 45;
            this.portBox1.Multiline = true;
            this.portBox1.Name = "portBox1";
            this.portBox1.Size = new System.Drawing.Size(157, 27);
            this.portBox1.TabIndex = 17;
            // 
            // ipBox2
            // 
            this.ipBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ipBox2.Location = new System.Drawing.Point(320, 43);
            this.ipBox2.Margin = new System.Windows.Forms.Padding(3, 20, 10, 3);
            this.ipBox2.MaxLength = 45;
            this.ipBox2.Multiline = true;
            this.ipBox2.Name = "ipBox2";
            this.ipBox2.Size = new System.Drawing.Size(157, 27);
            this.ipBox2.TabIndex = 18;
            // 
            // portBox2
            // 
            this.portBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.portBox2.Location = new System.Drawing.Point(320, 93);
            this.portBox2.Margin = new System.Windows.Forms.Padding(3, 20, 10, 3);
            this.portBox2.MaxLength = 45;
            this.portBox2.Multiline = true;
            this.portBox2.Name = "portBox2";
            this.portBox2.Size = new System.Drawing.Size(157, 27);
            this.portBox2.TabIndex = 19;
            // 
            // IpLabel1
            // 
            this.IpLabel1.AutoSize = true;
            this.IpLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.IpLabel1.Location = new System.Drawing.Point(42, 46);
            this.IpLabel1.Name = "IpLabel1";
            this.IpLabel1.Size = new System.Drawing.Size(24, 20);
            this.IpLabel1.TabIndex = 20;
            this.IpLabel1.Text = "IP";
            // 
            // IpLabel2
            // 
            this.IpLabel2.AutoSize = true;
            this.IpLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.IpLabel2.Location = new System.Drawing.Point(290, 47);
            this.IpLabel2.Name = "IpLabel2";
            this.IpLabel2.Size = new System.Drawing.Size(24, 20);
            this.IpLabel2.TabIndex = 21;
            this.IpLabel2.Text = "IP";
            // 
            // PortLabel1
            // 
            this.PortLabel1.AutoSize = true;
            this.PortLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PortLabel1.Location = new System.Drawing.Point(28, 96);
            this.PortLabel1.Name = "PortLabel1";
            this.PortLabel1.Size = new System.Drawing.Size(38, 20);
            this.PortLabel1.TabIndex = 22;
            this.PortLabel1.Text = "Port";
            // 
            // PortLabel2
            // 
            this.PortLabel2.AutoSize = true;
            this.PortLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PortLabel2.Location = new System.Drawing.Point(276, 93);
            this.PortLabel2.Name = "PortLabel2";
            this.PortLabel2.Size = new System.Drawing.Size(38, 20);
            this.PortLabel2.TabIndex = 23;
            this.PortLabel2.Text = "Port";
            // 
            // ClientLabel1
            // 
            this.ClientLabel1.AutoSize = true;
            this.ClientLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ClientLabel1.Location = new System.Drawing.Point(69, 20);
            this.ClientLabel1.Name = "ClientLabel1";
            this.ClientLabel1.Size = new System.Drawing.Size(48, 15);
            this.ClientLabel1.TabIndex = 24;
            this.ClientLabel1.Text = "Client 1";
            // 
            // ClientLabel2
            // 
            this.ClientLabel2.AutoSize = true;
            this.ClientLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ClientLabel2.Location = new System.Drawing.Point(317, 20);
            this.ClientLabel2.Name = "ClientLabel2";
            this.ClientLabel2.Size = new System.Drawing.Size(48, 15);
            this.ClientLabel2.TabIndex = 25;
            this.ClientLabel2.Text = "Client 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 648);
            this.Controls.Add(this.ClientLabel2);
            this.Controls.Add(this.ClientLabel1);
            this.Controls.Add(this.PortLabel2);
            this.Controls.Add(this.PortLabel1);
            this.Controls.Add(this.IpLabel2);
            this.Controls.Add(this.IpLabel1);
            this.Controls.Add(this.portBox2);
            this.Controls.Add(this.ipBox2);
            this.Controls.Add(this.portBox1);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.ipBox1);
            this.Controls.Add(this.sendBox);
            this.Controls.Add(this.receiveBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button sendButton;

        #endregion

        private System.Windows.Forms.TextBox receiveBox;
        private System.Windows.Forms.TextBox sendBox;
        private System.Windows.Forms.TextBox ipBox1;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TextBox portBox1;
        private System.Windows.Forms.TextBox ipBox2;
        private System.Windows.Forms.TextBox portBox2;
        private System.Windows.Forms.Label IpLabel1;
        private System.Windows.Forms.Label IpLabel2;
        private System.Windows.Forms.Label PortLabel1;
        private System.Windows.Forms.Label PortLabel2;
        private System.Windows.Forms.Label ClientLabel1;
        private System.Windows.Forms.Label ClientLabel2;
    }
}

