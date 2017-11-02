using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
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
            
            registration reg = new registration();
            
            reg.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(textBox2.Text);
            byte[] hash = md5.ComputeHash(inputBytes);

            StringBuilder PasswordHex = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)

            {
                PasswordHex.Append(hash[i].ToString("X2"));
            }
            SqlConnection con = new SqlConnection(@"Data Source=ЖЕНЯ-ПК;Initial Catalog=Employees;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT (*) FROM employee where  login = '"+ textBox1.Text +"' and password = '"+ PasswordHex.ToString() + "'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1") 
            {
                this.Hide();
                Form2 f = new Form2();
                f.Show();
            } else {
                MessageBox.Show("Неверный логин или пароль");
            
            }
        }
    }
}
