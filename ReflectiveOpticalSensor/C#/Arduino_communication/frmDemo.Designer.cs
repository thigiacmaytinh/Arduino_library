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
            this.chk_autoConnect = new System.Windows.Forms.CheckBox();
            this.lblArduino = new System.Windows.Forms.Label();
            this.btn_connect = new System.Windows.Forms.Button();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.lbl_elapsed = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_speed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chk_autoConnect
            // 
            this.chk_autoConnect.AutoSize = true;
            this.chk_autoConnect.Checked = true;
            this.chk_autoConnect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_autoConnect.Location = new System.Drawing.Point(28, 16);
            this.chk_autoConnect.Name = "chk_autoConnect";
            this.chk_autoConnect.Size = new System.Drawing.Size(100, 17);
            this.chk_autoConnect.TabIndex = 4;
            this.chk_autoConnect.Text = "Auto select port";
            this.chk_autoConnect.UseVisualStyleBackColor = true;
            this.chk_autoConnect.CheckedChanged += new System.EventHandler(this.chk_autoConnect_CheckedChanged);
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
            // txt_port
            // 
            this.txt_port.Enabled = false;
            this.txt_port.Location = new System.Drawing.Point(137, 16);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(225, 20);
            this.txt_port.TabIndex = 8;
            // 
            // lbl_elapsed
            // 
            this.lbl_elapsed.AutoSize = true;
            this.lbl_elapsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_elapsed.ForeColor = System.Drawing.Color.Red;
            this.lbl_elapsed.Location = new System.Drawing.Point(561, 116);
            this.lbl_elapsed.Name = "lbl_elapsed";
            this.lbl_elapsed.Size = new System.Drawing.Size(141, 153);
            this.lbl_elapsed.TabIndex = 9;
            this.lbl_elapsed.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(80, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(497, 153);
            this.label2.TabIndex = 10;
            this.label2.Text = "Speed:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(-11, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(596, 153);
            this.label3.TabIndex = 11;
            this.label3.Text = "Elapsed:";
            // 
            // lbl_speed
            // 
            this.lbl_speed.AutoSize = true;
            this.lbl_speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_speed.ForeColor = System.Drawing.Color.Red;
            this.lbl_speed.Location = new System.Drawing.Point(561, 295);
            this.lbl_speed.Name = "lbl_speed";
            this.lbl_speed.Size = new System.Drawing.Size(141, 153);
            this.lbl_speed.TabIndex = 12;
            this.lbl_speed.Text = "0";
            // 
            // frmDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 545);
            this.Controls.Add(this.lbl_speed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_elapsed);
            this.Controls.Add(this.txt_port);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.lblArduino);
            this.Controls.Add(this.chk_autoConnect);
            this.Name = "frmDemo";
            this.Text = "Demo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDemo_FormClosed);
            this.Load += new System.EventHandler(this.frmDemo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chk_autoConnect;
        private System.Windows.Forms.Label lblArduino;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.Label lbl_elapsed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_speed;
    }
}