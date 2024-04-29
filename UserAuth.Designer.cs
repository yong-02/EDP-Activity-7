namespace LastNa
{
    partial class UserAuth
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
            this.button_recover = new System.Windows.Forms.Button();
            this.textBox_recover = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_OTP = new System.Windows.Forms.Button();
            this.label_OTP = new System.Windows.Forms.Label();
            this.textBox_OTP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textBox_reveal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_recover
            // 
            this.button_recover.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_recover.Location = new System.Drawing.Point(392, 107);
            this.button_recover.Name = "button_recover";
            this.button_recover.Size = new System.Drawing.Size(118, 54);
            this.button_recover.TabIndex = 0;
            this.button_recover.Text = "Recover My Account";
            this.button_recover.UseVisualStyleBackColor = false;
            this.button_recover.Click += new System.EventHandler(this.button_recover_Click);
            // 
            // textBox_recover
            // 
            this.textBox_recover.Location = new System.Drawing.Point(83, 107);
            this.textBox_recover.Multiline = true;
            this.textBox_recover.Name = "textBox_recover";
            this.textBox_recover.Size = new System.Drawing.Size(304, 54);
            this.textBox_recover.TabIndex = 1;
            this.textBox_recover.TextChanged += new System.EventHandler(this.textBox_recover_TextChanged);
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Location = new System.Drawing.Point(80, 86);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(49, 18);
            this.label_email.TabIndex = 2;
            this.label_email.Text = "Email:";
            this.label_email.Click += new System.EventHandler(this.label_email_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button_OTP);
            this.panel1.Controls.Add(this.label_OTP);
            this.panel1.Controls.Add(this.textBox_OTP);
            this.panel1.Location = new System.Drawing.Point(53, 209);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 128);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button_OTP
            // 
            this.button_OTP.BackColor = System.Drawing.Color.Transparent;
            this.button_OTP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_OTP.Location = new System.Drawing.Point(329, 42);
            this.button_OTP.Name = "button_OTP";
            this.button_OTP.Size = new System.Drawing.Size(113, 50);
            this.button_OTP.TabIndex = 6;
            this.button_OTP.Text = "Send";
            this.button_OTP.UseVisualStyleBackColor = false;
            this.button_OTP.Click += new System.EventHandler(this.button_OTP_Click);
            // 
            // label_OTP
            // 
            this.label_OTP.AutoSize = true;
            this.label_OTP.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_OTP.Location = new System.Drawing.Point(25, 14);
            this.label_OTP.Name = "label_OTP";
            this.label_OTP.Size = new System.Drawing.Size(108, 25);
            this.label_OTP.TabIndex = 1;
            this.label_OTP.Text = "Enter OTP:";
            this.label_OTP.Click += new System.EventHandler(this.label_OTP_Click);
            // 
            // textBox_OTP
            // 
            this.textBox_OTP.Location = new System.Drawing.Point(30, 42);
            this.textBox_OTP.Multiline = true;
            this.textBox_OTP.Name = "textBox_OTP";
            this.textBox_OTP.Size = new System.Drawing.Size(304, 50);
            this.textBox_OTP.TabIndex = 0;
            this.textBox_OTP.TextChanged += new System.EventHandler(this.textBox_OTP_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MingLiU-ExtB", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "BigCompany";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(501, 465);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(77, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Back To Login";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // textBox_reveal
            // 
            this.textBox_reveal.Location = new System.Drawing.Point(153, 377);
            this.textBox_reveal.Multiline = true;
            this.textBox_reveal.Name = "textBox_reveal";
            this.textBox_reveal.Size = new System.Drawing.Size(254, 66);
            this.textBox_reveal.TabIndex = 6;
            this.textBox_reveal.TextChanged += new System.EventHandler(this.textBox_reveal_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 446);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Wait for your password here.";
            // 
            // UserAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 498);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_reveal);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.textBox_recover);
            this.Controls.Add(this.button_recover);
            this.Name = "UserAuth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserAuth";
            this.Load += new System.EventHandler(this.UserAuth_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_recover;
        private System.Windows.Forms.TextBox textBox_recover;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_OTP;
        private System.Windows.Forms.TextBox textBox_OTP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button_OTP;
        private System.Windows.Forms.TextBox textBox_reveal;
        private System.Windows.Forms.Label label2;
    }
}