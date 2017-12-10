namespace UDPSample
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.connectIP = new System.Windows.Forms.TextBox();
            this.comPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.connect = new System.Windows.Forms.Button();
            this.myIP = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.messageText = new System.Windows.Forms.TextBox();
            this.sendText = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.myIP);
            this.groupBox1.Controls.Add(this.connect);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comPort);
            this.groupBox1.Controls.Add(this.connectIP);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "UDP設定";
            // 
            // connectIP
            // 
            this.connectIP.Location = new System.Drawing.Point(112, 37);
            this.connectIP.Name = "connectIP";
            this.connectIP.Size = new System.Drawing.Size(100, 19);
            this.connectIP.TabIndex = 0;
            // 
            // comPort
            // 
            this.comPort.Location = new System.Drawing.Point(112, 63);
            this.comPort.Name = "comPort";
            this.comPort.Size = new System.Drawing.Size(100, 19);
            this.comPort.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(5, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "接続先IPAddress:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(5, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "ポート番号:";
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(185, 90);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(75, 23);
            this.connect.TabIndex = 2;
            this.connect.Text = "通信開始";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.onClickConnectButton);
            // 
            // myIP
            // 
            this.myIP.Location = new System.Drawing.Point(7, 19);
            this.myIP.Name = "myIP";
            this.myIP.Size = new System.Drawing.Size(205, 14);
            this.myIP.TabIndex = 3;
            this.myIP.Text = "このPCのIP Address:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 126);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "受信メッセージ";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 15);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(254, 108);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // messageText
            // 
            this.messageText.Location = new System.Drawing.Point(56, 263);
            this.messageText.Multiline = true;
            this.messageText.Name = "messageText";
            this.messageText.Size = new System.Drawing.Size(216, 24);
            this.messageText.TabIndex = 2;
            // 
            // sendText
            // 
            this.sendText.Location = new System.Drawing.Point(13, 264);
            this.sendText.Name = "sendText";
            this.sendText.Size = new System.Drawing.Size(37, 23);
            this.sendText.TabIndex = 3;
            this.sendText.Text = "送信";
            this.sendText.UseVisualStyleBackColor = true;
            this.sendText.Click += new System.EventHandler(this.sendText_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 311);
            this.Controls.Add(this.sendText);
            this.Controls.Add(this.messageText);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox comPort;
        private System.Windows.Forms.TextBox connectIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label myIP;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox messageText;
        private System.Windows.Forms.Button sendText;
    }
}

