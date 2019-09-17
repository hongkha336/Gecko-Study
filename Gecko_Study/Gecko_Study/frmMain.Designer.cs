namespace Gecko_Study
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBGCD = new System.Windows.Forms.Button();
            this.btnGmail = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClassRoom = new System.Windows.Forms.Button();
            this.btnStackOverFlow = new System.Windows.Forms.Button();
            this.btnWebcoban = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lbkey = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.btnBGCD);
            this.panel1.Controls.Add(this.btnGmail);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnClassRoom);
            this.panel1.Controls.Add(this.btnStackOverFlow);
            this.panel1.Controls.Add(this.btnWebcoban);
            this.panel1.Location = new System.Drawing.Point(12, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 261);
            this.panel1.TabIndex = 6;
            // 
            // btnBGCD
            // 
            this.btnBGCD.BackgroundImage = global::Gecko_Study.Properties.Resources._38846453_430434964117581_694300039131955200_n;
            this.btnBGCD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBGCD.Location = new System.Drawing.Point(0, 25);
            this.btnBGCD.Name = "btnBGCD";
            this.btnBGCD.Size = new System.Drawing.Size(167, 90);
            this.btnBGCD.TabIndex = 0;
            this.btnBGCD.UseVisualStyleBackColor = true;
            this.btnBGCD.Click += new System.EventHandler(this.btnBGCD_Click);
            // 
            // btnGmail
            // 
            this.btnGmail.BackgroundImage = global::Gecko_Study.Properties.Resources.download;
            this.btnGmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGmail.Location = new System.Drawing.Point(194, 25);
            this.btnGmail.Name = "btnGmail";
            this.btnGmail.Size = new System.Drawing.Size(184, 90);
            this.btnGmail.TabIndex = 5;
            this.btnGmail.UseVisualStyleBackColor = true;
            this.btnGmail.Click += new System.EventHandler(this.btnGmail_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Gecko_Study.Properties.Resources.java_icon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Location = new System.Drawing.Point(194, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 99);
            this.button1.TabIndex = 1;
            this.button1.Text = "JSP và Servlet";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClassRoom
            // 
            this.btnClassRoom.BackgroundImage = global::Gecko_Study.Properties.Resources.GoogleClassroom3_2;
            this.btnClassRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClassRoom.Location = new System.Drawing.Point(3, 153);
            this.btnClassRoom.Name = "btnClassRoom";
            this.btnClassRoom.Size = new System.Drawing.Size(167, 99);
            this.btnClassRoom.TabIndex = 4;
            this.btnClassRoom.UseVisualStyleBackColor = true;
            this.btnClassRoom.Click += new System.EventHandler(this.btnClassRoom_Click);
            // 
            // btnStackOverFlow
            // 
            this.btnStackOverFlow.BackgroundImage = global::Gecko_Study.Properties.Resources.stack_overflow;
            this.btnStackOverFlow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStackOverFlow.Location = new System.Drawing.Point(401, 25);
            this.btnStackOverFlow.Name = "btnStackOverFlow";
            this.btnStackOverFlow.Size = new System.Drawing.Size(179, 90);
            this.btnStackOverFlow.TabIndex = 2;
            this.btnStackOverFlow.UseVisualStyleBackColor = true;
            this.btnStackOverFlow.Click += new System.EventHandler(this.btnStackOverFlow_Click);
            // 
            // btnWebcoban
            // 
            this.btnWebcoban.BackgroundImage = global::Gecko_Study.Properties.Resources.difference_between_html_css_and_javascript;
            this.btnWebcoban.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWebcoban.Location = new System.Drawing.Point(401, 153);
            this.btnWebcoban.Name = "btnWebcoban";
            this.btnWebcoban.Size = new System.Drawing.Size(179, 99);
            this.btnWebcoban.TabIndex = 3;
            this.btnWebcoban.Text = "Web cơ bản";
            this.btnWebcoban.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnWebcoban.UseVisualStyleBackColor = true;
            this.btnWebcoban.Click += new System.EventHandler(this.btnWebcoban_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(136, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "POWER BY TIME KILLER";
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(15, 361);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(588, 22);
            this.textBox1.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(15, 394);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 26);
            this.button2.TabIndex = 9;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbkey
            // 
            this.lbkey.AutoSize = true;
            this.lbkey.Location = new System.Drawing.Point(17, 341);
            this.lbkey.Name = "lbkey";
            this.lbkey.Size = new System.Drawing.Size(41, 17);
            this.lbkey.TabIndex = 10;
            this.lbkey.Text = "lbkey";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(17, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Gõ đoạn code sau để xác nhận thoát:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 428);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbkey);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBGCD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnStackOverFlow;
        private System.Windows.Forms.Button btnWebcoban;
        private System.Windows.Forms.Button btnClassRoom;
        private System.Windows.Forms.Button btnGmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbkey;
        private System.Windows.Forms.Label label2;
    }
}