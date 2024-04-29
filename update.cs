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
    public partial class update : Form
    {
        private databaseConnection connection;
        string user_id = Dashboard.id;
        public update()
        {
            InitializeComponent();
            connection = new databaseConnection();

            if (connection.OpenConnection())
            {
                try
                {
                    string sql = "SELECT * FROM future_company.accounts WHERE id_acc = @user_id";
                    MySqlCommand cmd = new MySqlCommand(sql, connection.connection);
                    cmd.Parameters.AddWithValue("@user_id", user_id);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textBox_emaillll.Text = reader["email"].ToString();
                            textBox_nameeee.Text = reader["acc_realname"].ToString();
                            textBox_passsss.Text = reader["acc_pass"].ToString();
                            textBox_usernameeee.Text = reader["acc_uname"].ToString();

                        }
                        else
                        {
                            MessageBox.Show("Invalid");
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occure: " + ex.Message);
                }
                finally
                {
                    connection.CloseConnection();
                }

            }
        }

        private void update_Load(object sender, EventArgs e)
        {

        }

        private void button_update_Click(object sender, EventArgs e)
        {
            string name = textBox_nameeee.Text;
            string email = textBox_emaillll.Text;
            string user = textBox_usernameeee.Text;
            string pass = textBox_passsss.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Invalid");
                return;
            } 
            if(connection.OpenConnection())
            {
                try
                {
                    string sql = "UPDATE `future_company`.`accounts` SET `acc_uname` = @user, `acc_pass` = @pass, `acc_realname` = " +
                        "@name, `email` = @email WHERE(`id_acc` = @user_id);";
                    MySqlCommand cmd = new MySqlCommand(sql, connection.connection);
                    cmd.Parameters.AddWithValue("@user_id", user_id);
                    cmd.Parameters.AddWithValue("@user", user);
                    cmd.Parameters.AddWithValue("@pass", pass);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@name", name);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Added Value!");
                        var Dashboard = new Dashboard();
                        this.Hide();
                        Dashboard.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " +ex.Message);
                }
                finally
                {
                    connection.CloseConnection();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dashboard = new Dashboard();
            this.Hide();
            dashboard.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
