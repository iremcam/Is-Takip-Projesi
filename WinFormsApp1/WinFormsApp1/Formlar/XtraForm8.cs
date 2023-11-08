using DevExpress.DataAccess.Sql;
using DevExpress.XtraCharts.Native;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Entity.Express;

namespace WinFormsApp1.Formlar
{
    public partial class XtraForm8 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm8()
        {
            InitializeComponent();
        }
        string connectionString = "Server=DESKTOP-2PGSHUI\\SQLEXPRESS;DataBase=Express;Uid=sa;Pwd=1234;TrustServerCertificate=True";

        void Listele()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string sqlquery = "SELECT * FROM Tasks";

                SqlCommand com = new SqlCommand(sqlquery, con);

                com.ExecuteNonQuery();

                using (SqlDataReader reader1 = com.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();

                    dataTable.Load(reader1);

                    gridControl1.DataSource = dataTable;

                    gridView1.PopulateColumns();

                    gridView1.BestFitColumns();

                }
            }
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {



            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                //GİRİŞ YAPAN PERSONEL KONTROLÜ

                string userName = Globals.UserName;
                string sql = "Select p.Id from Personel as p inner join Users as u on p.Id=u.PersonelId where u.UserName=@userName";
                int personelId = 0;
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@userName", userName);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            personelId = Convert.ToInt32(reader["Id"].ToString());
                        }
                    }
                }
                //


                string query = "INSERT INTO Tasks (TaskGiver,Assigned,Description,FirstDate,EndDate) VALUES (@TaskGiver,@Assigned,@Description,@FirstDate,@EndDate)";

                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("@TaskGiver", personelId);

                if (comboBoxEdit1.SelectedIndex != -1)
                {
                    int aId = (int)comboBoxEdit1.SelectedIndex + 1;
                    sqlCommand.Parameters.AddWithValue("@Assigned", aId);
                }

                sqlCommand.Parameters.AddWithValue("@Description", richTextBox1.Text);

                sqlCommand.Parameters.AddWithValue("@EndDate", dateEdit1.EditValue.ToString());

                sqlCommand.Parameters.AddWithValue("@FirstDate", DateTime.Now);

                sqlCommand.ExecuteNonQuery();

            }
            MessageBox.Show("Görev Ataması Gerçekleşti");
            Listele();
        }

        private void XtraForm8_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string sql = "SELECT * FROM Personel";
            SqlCommand command = new SqlCommand(sql, connection);

            command.ExecuteNonQuery();

            using (SqlDataReader reader = command.ExecuteReader())
            {

                while (reader.Read())
                {
                    string personelName = reader["FirstName"].ToString() + " " + reader["LastName"].ToString();
                    comboBoxEdit1.Properties.Items.Add(personelName);
                }

            }
        }
    }
}