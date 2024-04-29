namespace LastNa
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
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.BigCompany = new System.Windows.Forms.Label();
            this.lbl_recovery = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(343, 203);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(271, 20);
            this.textBox_id.TabIndex = 1;
            this.textBox_id.TextChanged += new System.EventHandler(this.textBox_id_TextChanged);
            // 
            // textBox_pass
            // 
            this.textBox_pass.Location = new System.Drawing.Point(343, 269);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.Size = new System.Drawing.Size(271, 20);
            this.textBox_pass.TabIndex = 2;
            this.textBox_pass.TextChanged += new System.EventHandler(this.textBox_pass_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "AdminID";
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Login.Location = new System.Drawing.Point(375, 329);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(205, 43);
            this.btn_Login.TabIndex = 6;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // BigCompany
            // 
            this.BigCompany.AutoSize = true;
            this.BigCompany.Font = new System.Drawing.Font("MS PGothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BigCompany.Location = new System.Drawing.Point(384, 118);
            this.BigCompany.Name = "BigCompany";
            this.BigCompany.Size = new System.Drawing.Size(196, 35);
            this.BigCompany.TabIndex = 7;
            this.BigCompany.Text = "BigCompany";
            // 
            // lbl_recovery
            // 
            this.lbl_recovery.AutoSize = true;
            this.lbl_recovery.Location = new System.Drawing.Point(434, 313);
            this.lbl_recovery.Name = "lbl_recovery";
            this.lbl_recovery.Size = new System.Drawing.Size(86, 13);
            this.lbl_recovery.TabIndex = 8;
            this.lbl_recovery.Text = "Forgot Password";
            this.lbl_recovery.Click += new System.EventHandler(this.lbl_recovery_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 450);
            this.Controls.Add(this.lbl_recovery);
            this.Controls.Add(this.BigCompany);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_pass);
            this.Controls.Add(this.textBox_id);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label BigCompany;
        private System.Windows.Forms.Label lbl_recovery;
    }
}

