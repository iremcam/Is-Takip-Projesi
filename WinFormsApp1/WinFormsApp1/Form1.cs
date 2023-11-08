using DevExpress.XtraBars.Ribbon;
using System.Data.SqlClient;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string connectionString = "Server=DESKTOP-2PGSHUI\\SQLEXPRESS;DataBase=Express;Uid=sa;Pwd=1234;TrustServerCertificate=True";
    
        public bool KullaniciDogrulama(string userName, string userPassword)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM  Users WHERE UserName=@userName AND UserPassword=@userPassword";
                using (SqlCommand conn = new SqlCommand(query, connection))
                {
                    conn.Parameters.AddWithValue("@userName", userName);
                    conn.Parameters.AddWithValue("@userPassword", userPassword);
                    int result = (int)conn.ExecuteScalar();
                    //this.UserName = userName;
                    return result > 0;

                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text;
            string userPassword = textBox2.Text;


            if (KullaniciDogrulama(userName, userPassword))
            {
                Globals.UserName = userName;
                RibbonForm1 ribbonForm1 = new RibbonForm1();
                this.Hide();
                ribbonForm1.Show();
            }
            else
            {
                MessageBox.Show("Kullanýcý adý veya þifre hatalý.");
            }
        }
    }
}