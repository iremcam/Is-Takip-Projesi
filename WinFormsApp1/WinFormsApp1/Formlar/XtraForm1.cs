using DevExpress.Xpo;
using DevExpress.XtraEditors;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.DependencyInjection;
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
    public partial class XtraForm1 : Form
    {
        public XtraForm1()
        {
            InitializeComponent();
        }

        string connectionString = "Server=DESKTOP-2PGSHUI\\SQLEXPRESS;DataBase=Express;Uid=sa;Pwd=1234;TrustServerCertificate=True";
        void Listele()
        {
            //string connectionString = "data source=DESKTOP-2PGSHUI\\SQLEXPRESS;user id=sa;password=1234;initial catalog=Express;integrated security =true";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Department ORDER BY Id asc ";

                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                   
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    // gridControl1'e DataTable'i bağ
                    gridControl1.DataSource = dataTable;

                    // gridView1 kontrolünü tanım
                    gridView1.PopulateColumns();

                    // Sütunları otomatik olarak ayar
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

                string query = "INSERT INTO Department (Id, Name) VALUES (@Id, @Name)";
                SqlCommand command = new SqlCommand(query, connection);


                command.Parameters.AddWithValue("@Id", Convert.ToInt32(textBox1.Text));

                command.Parameters.AddWithValue("@Name", textBox2.Text);

                command.ExecuteNonQuery();

                connection.Close();
            }
            MessageBox.Show("veri eklendi.");

            Listele();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();


                string idCheckQuery = "SELECT COUNT(*) FROM Department WHERE Id = @Id";
                SqlCommand idCheckCommand = new SqlCommand(idCheckQuery, connection);
                idCheckCommand.Parameters.AddWithValue("@Id", Convert.ToInt32(textBox1.Text));

                int existingIDCount = (int)idCheckCommand.ExecuteScalar();

                if (existingIDCount > 0)
                {
                    string deleteQuery = "DELETE FROM Department WHERE Id = @Id";
                    SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
                    deleteCommand.Parameters.AddWithValue("@Id", Convert.ToInt32(textBox1.Text));

                    deleteCommand.ExecuteNonQuery();
                    MessageBox.Show("Veri silindi.");
                }
                else
                {

                    MessageBox.Show("Bu ID mevcut değil.");
                }
                connection.Close();
                Listele();
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string idquery = "SELECT COUNT(*) FROM Department WHERE Id=@Id";
                SqlCommand command = new SqlCommand(idquery, connection);
                command.Parameters.AddWithValue("@Id", Convert.ToInt32(textBox1.Text));

                int idCount = (int)command.ExecuteScalar();
                if (idCount > 0)
                {
                    string query = "UPDATE Department SET Name=@Name WHERE Id=@Id";
                    SqlCommand updateCommand = new SqlCommand(query, connection);

                    updateCommand.Parameters.AddWithValue("@Id", Convert.ToInt32(textBox1.Text));
                    updateCommand.Parameters.AddWithValue("@Name", textBox2.Text);
                    updateCommand.ExecuteNonQuery();

                    MessageBox.Show("güncellendi!!");
                }
                else
                {
                    MessageBox.Show("hatalı id");
                }
                connection.Close();
                Listele();
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}