using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net;
using System.Net.Mail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LastNa
{
    public partial class UserAuth : Form
    {
        private databaseConnection conn;
        string sendCode = "";
        string password = "";
        string email = "";
        string to = "";

        public UserAuth()
        {
            InitializeComponent();
            conn = new databaseConnection();
            // panel_password.Hide()
            textBox_reveal.Hide();
        }

        private void label_OTP_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserAuth_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var Form1 = new Form1();
            this.Hide();
            Form1.Show();
        }

        private void button_recover_Click(object sender, EventArgs e)
        {
            string email = textBox_recover.Text;
            bool verify = false;

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Invalid Input", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (conn.OpenConnection())
            {
                string sql = "SELECT * FROM accounts WHERE email = @email";
                MySqlCommand cmd = new MySqlCommand(sql, conn.connection);
                cmd.Parameters.AddWithValue("@email", email);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        email = reader["email"].ToString();
                        password = reader["acc_pass"].ToString();
                        verify = true;
                    }
                }
                if (verify == true)
                {
                    string from, pass, messageBody;
                    Random rand = new Random();
                    MailMessage message = new MailMessage();
                    sendCode = (rand.Next(999999)).ToString();
                    to = email;
                    from = "maidonduran1005@gmail.com";
                    pass = "kowftigosyuujxnj";
                    messageBody = "Your password recovery code: " + sendCode;

                    message.To.Add(to);
                    message.From = new MailAddress(from);
                    message.Body = messageBody;
                    message.Subject = "Password Recovery Code";

                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.EnableSsl = true;
                    smtp.Port = 587;

                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(from, pass);

                    try
                    {
                        smtp.Send(message);
                        MessageBox.Show("Code send successfully");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                else
                {
                    //verify_code.Hide();
                }
                conn.CloseConnection();

            }
        }

        private void button_OTP_Click(object sender, EventArgs e)
        {
            string verify_text = textBox_OTP.Text;
            conn.connection.Open();

            if (verify_text == sendCode)
            {
                MessageBox.Show("match!");
                textBox_reveal.Text = password;
                textBox_reveal.Show();

            }

            else
            {
                MessageBox.Show("Code not match!");
            }
            conn.CloseConnection();
        }

        private void textBox_OTP_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_recover_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_email_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_reveal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
