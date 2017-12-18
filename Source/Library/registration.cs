using System;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Library
{
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
        }

        void button1_Click(object sender, EventArgs e)
        {
            var f1 = new Authorization();
            f1.Show();
        }

        void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=ЖЕНЯ-ПК;Initial Catalog=Employees;Integrated Security=True"))
            {
                try
                {
                    var sql = "INSERT INTO employee (name, surname, middleName, login, password)" + "VALUES (@name, @surname, @middleName, @login, @password);";
                    con.Open();
                    var cmd = new SqlCommand(sql, con);
                    // создаем параметры и добавляем их в коллекцию

                    var name = textBoxName.Text.ToString();
                    var surname = textBoxSurname.Text.ToString();
                    var middleName = textBoxSecondName.Text.ToString();
                    var login = textBoxLogin.Text.ToString();
                    var password = textBoxPassword.Text.ToString();

                    var md5 = System.Security.Cryptography.MD5.Create();
                    byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(password);
                    byte[] hash = md5.ComputeHash(inputBytes);

                    var PasswordHex = new StringBuilder();

                    for (int i = 0; i < hash.Length; i++)
                        PasswordHex.Append(hash[i].ToString("X2"));

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
                Close();
            }
        }
    }
}