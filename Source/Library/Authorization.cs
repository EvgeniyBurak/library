using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Library
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var reg = new registration();

            reg.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // FormSearch f = new FormSearch();
            // f.Show();
            var md5 = MD5.Create();
            var inputBytes = Encoding.ASCII.GetBytes(textBox2.Text);
            var hash = md5.ComputeHash(inputBytes);

            var PasswordHex = new StringBuilder();

            for (var i = 0; i < hash.Length; i++)
                PasswordHex.Append(hash[i].ToString("X2"));

            var con = new SqlConnection(@"Data Source=ЖЕНЯ-ПК;Initial Catalog=Employees;Integrated Security=True");
            var sda = new SqlDataAdapter(
                "SELECT COUNT (*) FROM employee where  login = '" + textBox1.Text + "' and password = '" + PasswordHex +
                "'", con);
            var dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Hide();
                var fe = new FormSearch();
                fe.Show();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }
    }
}