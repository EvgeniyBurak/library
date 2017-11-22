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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            booksBindingSource.Filter = "ISBN = \'" + textBoxSearch.Text + "\'";

        }

        private void FormSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'booksDataSet.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.booksDataSet.Book);
         
         

        }


        private void button3_Click(object sender, EventArgs e)
        {
            AddBook addbook = new AddBook();
            addbook.Show();
        }
    }
}
