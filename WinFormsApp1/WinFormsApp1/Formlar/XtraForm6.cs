using DevExpress.Mvvm.POCO;
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

namespace WinFormsApp1.Formlar
{
    public partial class XtraForm6 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm6()
        {
            InitializeComponent();
        }



        string connectionString = "Server=DESKTOP-2PGSHUI\\SQLEXPRESS;DataBase=Express;Uid=sa;Pwd=1234;TrustServerCertificate=True";
        void Listele()
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Name FROM Company ORDER BY Id desc ";

                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    List<string> departmanlar = new List<string>();

                    while (reader.NextResult())
                    {
                        departmanlar.Add(reader["Name"].ToString());
                    }
                    gridControl1.DataSource = departmanlar;
                    gridControl1.RefreshDataSource();
                }
               

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Listele();


        }
    }
}