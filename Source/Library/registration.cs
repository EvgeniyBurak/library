using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
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

        private void button1_Click(object sender, EventArgs e)
        {
            var f1 = new Authorization();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var con =
                new SqlConnection(@"Data Source=YAUHENI-PK;Initial Catalog=Employees;Integrated Security=True"))
            {
                try
                {
                    var sql = "INSERT INTO employee (name, surname, middleName, login, password)" +
                              "VALUES (@name, @surname, @middleName, @login, @password);";
                    con.Open();
                    var cmd = new SqlCommand(sql, con);
                    // создаем параметры и добавляем их в коллекцию

                    var name = textBoxName.Text;
                    var surname = textBoxSurname.Text;
                    var middleName = textBoxSecondName.Text;
                    var login = textBoxLogin.Text;
                    var password = textBoxPassword.Text;

                    var md5 = MD5.Create();
                    var inputBytes = Encoding.ASCII.GetBytes(password);
                    var hash = md5.ComputeHash(inputBytes);

                    var PasswordHex = new StringBuilder();

                    for (var i = 0; i < hash.Length; i++)
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