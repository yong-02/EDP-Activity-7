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
using ClosedXML.Excel;

namespace LastNa
{
    public partial class Branch : Form
    {
        private databaseConnection connection;
        public DataTable dt = new DataTable();
        public Branch()
        {
            InitializeComponent();
            connection = new databaseConnection();
            EventHandler dataGridView_SelectionChanged = null;
            dataGridView1.SelectionChanged += dataGridView_SelectionChanged;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ExportToExcel(dt);
        }
        private void ExportToExcel(DataTable dataTable)
        {
            string templatePath = @"C:\Users\MAIDON DURAN\OneDrive\Desktop\LastNa\TemplateBranch.xlsx"; 
            string newFilePath = @"C:\Users\MAIDON DURAN\OneDrive\Desktop\LastNa\TemplateBranchExported.xlsx";

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
                    sign.Value = "Signature: Maidon Duran (Branch)";
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

        private void button1_Click(object sender, EventArgs e)
        {
            var Dashboard = new Dashboard();
            this.Hide();
            Dashboard.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var company = new Company();
            this.Hide();
            company.Show();
        }

        private void Branch_Load(object sender, EventArgs e)
        {
            BindData2();
        }
        private void BindData2()
        {
            try
            {
                if (connection.OpenConnection())
                {
                    string sqlQuery = "SELECT * FROM future_company.branch";
                    MySqlCommand cmd = new MySqlCommand(sqlQuery, connection.connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    connection.CloseConnection();
                }
                else
                {
                    MessageBox.Show("Failed to connect to database");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user data: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
