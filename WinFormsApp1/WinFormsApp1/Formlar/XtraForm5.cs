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
    public partial class Firma : DevExpress.XtraEditors.XtraForm
    {
        public Firma()
        {
            InitializeComponent();
        }

        string connectionString = "Server=DESKTOP-2PGSHUI\\SQLEXPRESS;DataBase=Express;Uid=sa;Pwd=1234;TrustServerCertificate=True";

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Company (Name) VALUES (@Name)";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Name", textBox2.Text);

                command.ExecuteNonQuery();

                connection.Close();
            }
        }
    }
}