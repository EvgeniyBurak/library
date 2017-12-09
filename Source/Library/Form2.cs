using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library
{
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            
            




        }

        private void FormSearch_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Book2". При необходимости она может быть перемещена или удалена.
            this.book2TableAdapter.Fill(this.dataSet1.Book2);
           

        }


        private void button3_Click(object sender, EventArgs e)
        {
            AddBook addbook = new AddBook();
            addbook.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void FormSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Закрыть?", "Message", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                Application.ExitThread();
            }
        }

        

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            this.book2TableAdapter.Fill(this.dataSet1.Book2);
            book2BindingSource.Filter = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (comboBoxSearch.Text == "ISBN")
            {
                book2BindingSource.Filter = "ISBN = \'" + textBoxSearch.Text + "\'";
            }
            if (comboBoxSearch.Text.Equals("Автор"))
            {
                book2BindingSource.Filter = "Author = \'" + textBoxSearch.Text + "\'";
            }
            if (comboBoxSearch.Text.Equals("ББК"))
            {
                book2BindingSource.Filter = "BBK = \'" + textBoxSearch.Text + "\'";
            }
            if (comboBoxSearch.Text.Equals("Год издания"))
            {
                book2BindingSource.Filter = "DatePublication = \'" + textBoxSearch.Text + "\'";
            }
            if (comboBoxSearch.Text.Equals("Заглавие"))
            {
                book2BindingSource.Filter = "MainTitle = \'" + textBoxSearch.Text + "\'";
            }
            if (comboBoxSearch.Text.Equals("Издательство"))
            {
                book2BindingSource.Filter = "InformationOnThePublication = \'" + textBoxSearch.Text + "\'";
            }

        }
    }
}
