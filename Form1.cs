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

namespace LastNa
{
    public partial class Form1 : Form
    {
        private databaseConnection conn;
        public Form1()
        {
            InitializeComponent();
            conn = new databaseConnection();
        }



        private void textBox_id_TextChanged(object sender, EventArgs e)
        {
            // if (this.textBox_id.Text == "admin") ;
        }

        private void textBox_pass_TextChanged(object sender, EventArgs e)
        {
              // if (this.textBox_pass.Text == "admin") ;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string acc_uname = textBox_id.Text;
            string acc_pass = textBox_pass.Text;

            if( string.IsNullOrEmpty( acc_uname )  || string.IsNullOrEmpty( acc_pass ) )
            {
                MessageBox.Show("Invalid");
            }
            if (conn.OpenConnection())
            {
                try
                {
                    string sql = "SELECT acc_uname FROM future_company.accounts WHERE acc_uname = @acc_uname AND acc_pass = @acc_pass";
                    MySqlCommand cmd = new MySqlCommand(sql, conn.connection);
                    cmd.Parameters.AddWithValue("@acc_uname", acc_uname);
                    cmd.Parameters.AddWithValue("@acc_pass", acc_pass);

                    using(MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var Dashboard = new Dashboard();
                            this.Hide();
                            Dashboard.Show();  
                        }
                        else
                        {
                            MessageBox.Show("Invalid");
                        }
                    }

                } catch(Exception ex)
                {
                    MessageBox.Show("An error occure: " +ex.Message);
                }
                finally 
                {
                    conn.CloseConnection();    
                }

            }

        }

        private void lbl_recovery_Click(object sender, EventArgs e)
        {
            var UserAuth = new UserAuth();
            this.Hide();
            UserAuth.Show();
        }

    }
}
