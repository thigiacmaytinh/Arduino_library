namespace UI
{
    partial class frmDemo
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.chk_autoConnect = new System.Windows.Forms.CheckBox();
            this.cb_comPort = new System.Windows.Forms.ComboBox();
            this.lblArduino = new System.Windows.Forms.Label();
            this.btn_connect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data to send";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(396, 71);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 2;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 106);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(458, 332);
            this.textBox2.TabIndex = 3;
            // 
            // chk_autoConnect
            // 
            this.chk_autoConnect.AutoSize = true;
            this.chk_autoConnect.Checked = true;
            this.chk_autoConnect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_autoConnect.Location = new System.Drawing.Point(40, 16);
            this.chk_autoConnect.Name = "chk_autoConnect";
            this.chk_autoConnect.Size = new System.Drawing.Size(90, 17);
            this.chk_autoConnect.TabIndex = 4;
            this.chk_autoConnect.Text = "Auto connect";
            this.chk_autoConnect.UseVisualStyleBackColor = true;
            this.chk_autoConnect.CheckedChanged += new System.EventHandler(this.chk_autoConnect_CheckedChanged);
            // 
            // cb_comPort
            // 
            this.cb_comPort.Enabled = false;
            this.cb_comPort.FormattingEnabled = true;
            this.cb_comPort.Location = new System.Drawing.Point(137, 14);
            this.cb_comPort.Name = "cb_comPort";
            this.cb_comPort.Size = new System.Drawing.Size(225, 21);
            this.cb_comPort.TabIndex = 5;
            // 
            // lblArduino
            // 
            this.lblArduino.AutoSize = true;
            this.lblArduino.Location = new System.Drawing.Point(40, 40);
            this.lblArduino.Name = "lblArduino";
            this.lblArduino.Size = new System.Drawing.Size(0, 13);
            this.lblArduino.TabIndex = 6;
            // 
            // btn_connect
            // 
            this.btn_connect.Enabled = false;
            this.btn_connect.Location = new System.Drawing.Point(396, 13);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(75, 23);
            this.btn_connect.TabIndex = 7;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // frmDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 450);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.lblArduino);
            this.Controls.Add(this.cb_comPort);
            this.Controls.Add(this.chk_autoConnect);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmDemo";
            this.Text = "Demo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDemo_FormClosed);
            this.Load += new System.EventHandler(this.frmDemo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox chk_autoConnect;
        private System.Windows.Forms.ComboBox cb_comPort;
        private System.Windows.Forms.Label lblArduino;
        private System.Windows.Forms.Button btn_connect;
    }
}