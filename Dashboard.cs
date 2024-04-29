using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using MySql.Data.MySqlClient;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Office.CustomUI;


namespace LastNa
{
    public partial class Dashboard : Form
    {

        private databaseConnection connection;
        public static string id;
        public DataTable dt = new DataTable();
        public Dashboard()
        {
            InitializeComponent();
            connection = new databaseConnection();
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_update_Click(object sender, EventArgs e)
        {

            string adminID = textBox_adminid_del.Text;
            string adminpass = textBox_pass_del.Text;

            if (string.IsNullOrEmpty(adminID) || string.IsNullOrEmpty(adminpass))
            {
                MessageBox.Show("Invalid");
            }
            if (connection.OpenConnection())
            {
                try
                {
                    string sql = "SELECT * FROM future_company.accounts WHERE id_acc = @adminID AND acc_pass = @adminpass;";
                    MySqlCommand cmd = new MySqlCommand(sql, connection.connection);
                    cmd.Parameters.AddWithValue("@adminID", adminID);
                    cmd.Parameters.AddWithValue("@adminpass", adminpass);

                    using (MySqlDataReader reader = cmd.ExecuteReader()) 
                    { 
                        if(reader.Read())
                        {
                            id = reader["id_acc"].ToString();
                            var update = new update();
                            this.Hide();
                            update.Show();
                        } else
                        {

                        }
                     }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                    return;
                }
                finally
                {
                    connection.CloseConnection();
                }
            }

        }

        private void button_add_Click(object sender, EventArgs e)
        {
           
            string adminid = textBox_adminid.Text;
            string adminname = textBox_name.Text;
            string adminemail = textBox_email_das.Text;
            string adminuser = textBox_userrrrr.Text;
            string adminpass = textBox_passsss.Text;

            if (string.IsNullOrEmpty(adminname) || string.IsNullOrEmpty(adminpass) || string.IsNullOrEmpty(adminemail) || string.IsNullOrEmpty(adminpass))
            {
                MessageBox.Show("Invalid input");
            }
            if (connection.OpenConnection())
            {
                try
                {
                    string sql = "INSERT INTO `future_company`.`accounts` (`acc_uname`, `acc_pass`, `acc_realname`, `email`) VALUES(@adminuser,  @adminpass , @adminname, @adminemail);";
                    MySqlCommand cmd = new MySqlCommand(sql, connection.connection);
                    cmd.Parameters.AddWithValue("@adminuser", adminuser);
                    cmd.Parameters.AddWithValue("@adminpass", adminpass);
                    cmd.Parameters.AddWithValue("@adminname", adminname);
                    cmd.Parameters.AddWithValue("@adminemail", adminemail);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
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

        private void button_signout_Click(object sender, EventArgs e)
        {
            var Form1 = new Form1();
            this.Hide();
            Form1.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            dataLoad();
        }

        private void dataLoad()
        {
            try
            {
                if(connection.OpenConnection())
                {
                    string slqQuery = "SELECT * FROM future_company.accounts";

                    MySqlCommand cmd = new MySqlCommand(slqQuery, connection.connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    //DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                    connection.CloseConnection();
                } else
                {
                    MessageBox.Show("Failed to connect to database");
                }
            } 
            catch(Exception ex ) {
                MessageBox.Show("an error occure " +ex.Message);
            }   
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            string adminID = textBox_adminid_del.Text;
            string adminpass = textBox_pass_del.Text;

            if(string.IsNullOrEmpty(adminID) || string.IsNullOrEmpty(adminpass))
            {
                MessageBox.Show("Invalid");
            }
            if(connection.OpenConnection())
            {
                DialogResult result = MessageBox.Show("Are you sure?", "No", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    try
                    {
                        string sql = "DELETE FROM `future_company`.`accounts` WHERE (`id_acc` = @adminID) AND (`acc_pass` = @adminpass) ;";
                        MySqlCommand cmd = new MySqlCommand(sql, connection.connection);
                        cmd.Parameters.AddWithValue("@adminpass", adminpass);
                        cmd.Parameters.AddWithValue("@adminID", adminID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
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
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                        return;
                    }
                    finally
                    {
                        connection.CloseConnection();
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    var Dashboard = new Dashboard();
                    this.Hide();
                    Dashboard.Show();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportToExcel(dt);
        }

        private void ExportToExcel(DataTable dataTable)
        {
            string templatePath = @"C:\Users\MAIDON DURAN\OneDrive\Desktop\LastNa\TemplateAccount.xlsx"; 
            string newFilePath = @"C:\Users\MAIDON DURAN\OneDrive\Desktop\LastNa\TemplateAccountExported.xlsx"; 

            try
            {

                using (var workbook = new XLWorkbook(templatePath))
                {
                    var worksheet = workbook.Worksheet(1);
                    int startRow = 11;
                    int startColumn = 2;
                    int totalRow = dataTable.Rows.Count;
                    int totalColumn = dataTable.Columns.Count;

                    for (int i = 0; i < dataTable.Columns.Count; i++)
                    {
                        var header = worksheet.Cell(startRow - 1, startColumn + i);
                        header.Value = dataTable.Columns[i].ColumnName;
                        header.Style.Font.SetBold(true);
                        worksheet.Column(startColumn + i).Width = 20;


                    }

                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataTable.Rows[i].ItemArray.Length; j++)
                        {
                            worksheet.Cell(startRow + i, startColumn + j).Value = Convert.ToString(dataTable.Rows[i][j]);

                        }

                    }

                    var sign = worksheet.Cell(dataTable.Rows.Count + startRow + 3, 1);
                    sign.Value = "Signature: Maidon Duran (Account)";
                    sign.Style.Font.SetBold(true);

                    workbook.SaveAs(newFilePath);
                    MessageBox.Show($"File saved at {newFilePath}");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var branch = new Branch();
            this.Hide();
            branch.Show();
        }
    }
}
