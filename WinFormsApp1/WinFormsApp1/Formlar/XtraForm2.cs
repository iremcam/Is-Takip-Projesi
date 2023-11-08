using DevExpress.XtraEditors;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.Formlar
{
    public partial class XtraForm2 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm2()
        {
            InitializeComponent();
        }
        string connectionString = "Server=DESKTOP-2PGSHUI\\SQLEXPRESS;DataBase=Express;Uid=sa;Pwd=1234;TrustServerCertificate=True";

        

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }




        void Listele()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();


                string query = "SELECT * FROM Personel";

                SqlCommand command = new SqlCommand(query, connection);

                command.ExecuteNonQuery();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();

                    dataTable.Load(reader);

                    gridControl1.DataSource = dataTable;

                    gridView1.PopulateColumns();

                    gridView1.BestFitColumns();


                }

            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO  Personel (FirstName,LastName,Mail,Department,Phone,CompanyId) VALUES (@FirstName,@LastName,@Mail,@Department,@Phone,@CompanyId) ";
                SqlCommand command = new SqlCommand(query, connection);


                command.Parameters.AddWithValue("@FirstName", textBox1.Text);

                command.Parameters.AddWithValue("@LastName", textBox2.Text);

                command.Parameters.AddWithValue("@Mail", textBox3.Text);

                command.Parameters.AddWithValue("@Phone", textBox4.Text);

                if (comboBoxEdit1.SelectedIndex != -1)
                {
                    int departmentId = (int)comboBoxEdit1.SelectedIndex+1;
                    command.Parameters.AddWithValue("Department", departmentId);
                }

                if (comboBoxEdit2.SelectedIndex != -1)
                {
                    int companyId = (int)comboBoxEdit2.SelectedIndex + 1;
                    command.Parameters.AddWithValue("@CompanyId", companyId);

                }
                command.ExecuteNonQuery();
                connection.Close();
 
            }
            MessageBox.Show("personel eklendi");
            Listele();
        }

        private void XtraForm2_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn=new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Department";

                SqlCommand command = new SqlCommand(query, conn);

                command.ExecuteNonQuery();

                using (SqlDataReader reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        string departmentName = reader["Name"].ToString();
                        comboBoxEdit1.Properties.Items.Add(departmentName);
                    }

                }


                string query1 = "SELECT * FROM Company";

                SqlCommand command1 = new SqlCommand(query1,conn);

                command1.ExecuteNonQuery();

                using (SqlDataReader reader1=command1.ExecuteReader())
                {
                    while (reader1.Read())
                    {
                        string companyName = reader1["Name"].ToString();

                        comboBoxEdit2.Properties.Items.Add(companyName);
                        
                    }
                }



            }

        }
    }
}