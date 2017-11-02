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
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Authorization f1 = new Authorization();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection(@"Data Source=ЖЕНЯ-ПК;Initial Catalog=Employees;Integrated Security=True"))
            {
                try
                {
                    string sql = "INSERT INTO employee (name, surname, middleName, login, password)" + "VALUES (@name, @surname, @middleName, @login, @password);";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sql, con);
                    //создаем параметры и добавляем их в коллекцию


                    string name = textBoxName.Text.ToString();
                    string surname = textBoxSurname.Text.ToString();
                    string middleName = textBoxSecondName.Text.ToString();
                    string login = textBoxLogin.Text.ToString();
                    string password = textBoxPassword.Text.ToString();

                    MD5 md5 = System.Security.Cryptography.MD5.Create();
                    byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(password);
                    byte[] hash = md5.ComputeHash(inputBytes);

                    StringBuilder PasswordHex = new StringBuilder();

                    for (int i = 0; i < hash.Length; i++)
                
                    {
                        PasswordHex.Append(hash[i].ToString("X2"));
                    }

                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@surname", surname);
                    cmd.Parameters.AddWithValue("@middleName", middleName);
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@password", PasswordHex.ToString());
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                MessageBox.Show("Успешно добавлено");
                this.Close();
            }
      

        }
    }
}
