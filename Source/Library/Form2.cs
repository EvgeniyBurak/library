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

        public void RefreshGrid()
        {
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            




        }

        private void FormSearch_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "booksDataSet.Book2". При необходимости она может быть перемещена или удалена.
            this.book2TableAdapter1.Fill(this.booksDataSet.Book2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Book2". При необходимости она может быть перемещена или удалена.
            this.book2TableAdapter.Fill(this.dataSet1.Book2);
           

        }


        private void button3_Click(object sender, EventArgs e)
        {
            Program.N = 0;

            Program.HEADER = new Header();
            Program.TITLE = new Title();
            Program.PUBLICATION = new Publication();
            Program.OUTPUTDATA = new OutputData();
            Program.PHCHARACTERISTICS = new PhysicalCharacteristics();
            Program.SERIES = new Series();
            Program.STANDARDNUMBER = new StandardNumber();
            AddBook addbook = new AddBook();
            addbook.Show();
            UpdateGrid();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            int N = Convert.ToInt32(dataGridView2.Rows[0].Cells[0].Value);
            DataBaseClass DB = new DataBaseClass();
            if (DB.Delete(N))
            {
                MessageBox.Show("Книга списана успешно");
            }
            else
            {
                MessageBox.Show("Произошла ошибка");
            }

            UpdateGrid();

           
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

        public void UpdateGrid()
        {
            this.book2TableAdapter.Fill(this.dataSet1.Book2);
            this.book2TableAdapter1.Fill(this.booksDataSet.Book2);

            book2BindingSource.Filter = null;
            book2BindingSource1.Filter = null;

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateGrid();
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

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            string code = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);

            string CardBook = "";

            book2BindingSource1.Filter = "id = \'" +  code + "\'";
            CardBook = dataGridView2.Rows[0].Cells[0].Value.ToString() + "\n" +
                dataGridView2.Rows[0].Cells[2].Value.ToString() + "\n" +
                dataGridView2.Rows[0].Cells[1].Value.ToString() + ". " +
                dataGridView2.Rows[0].Cells[3].Value.ToString() + " : " +
                dataGridView2.Rows[0].Cells[6].Value.ToString() + "/ " +
                dataGridView2.Rows[0].Cells[7].Value.ToString() + ".- " +
                dataGridView2.Rows[0].Cells[17].Value.ToString() + " : " +
                dataGridView2.Rows[0].Cells[16].Value.ToString() + ", " +
                dataGridView2.Rows[0].Cells[21].Value.ToString() + ".- " +
                dataGridView2.Rows[0].Cells[25].Value.ToString() + ".-" +
                "ISBN " + dataGridView2.Rows[0].Cells[36].Value.ToString() + ".";
            richTextBoxBook.Text = CardBook;

        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Program.N = 1;
            Program.currentID = Convert.ToInt32(dataGridView2.Rows[0].Cells[0].Value);
            Program.HEADER = new Header(dataGridView2.Rows[0].Cells[1].Value.ToString(),
                                        dataGridView2.Rows[0].Cells[2].Value.ToString());
            Program.TITLE = new Title(dataGridView2.Rows[0].Cells[3].Value.ToString(), 
                                      dataGridView2.Rows[0].Cells[4].Value.ToString(),
                                      dataGridView2.Rows[0].Cells[5].Value.ToString(),
                                      dataGridView2.Rows[0].Cells[6].Value.ToString(),
                                      dataGridView2.Rows[0].Cells[7].Value.ToString(),
                                      dataGridView2.Rows[0].Cells[8].Value.ToString());
            Program.PUBLICATION = new Publication(dataGridView2.Rows[0].Cells[9].Value.ToString(),
                                                  dataGridView2.Rows[0].Cells[10].Value.ToString(),
                                                  dataGridView2.Rows[0].Cells[11].Value.ToString(),
                                                  dataGridView2.Rows[0].Cells[12].Value.ToString(),
                                                  dataGridView2.Rows[0].Cells[13].Value.ToString(),
                                                  dataGridView2.Rows[0].Cells[14].Value.ToString(),
                                                  dataGridView2.Rows[0].Cells[15].Value.ToString());
            Program.OUTPUTDATA = new OutputData(dataGridView2.Rows[0].Cells[16].Value.ToString(),
                                                dataGridView2.Rows[0].Cells[17].Value.ToString(),
                                                dataGridView2.Rows[0].Cells[18].Value.ToString(),
                                                dataGridView2.Rows[0].Cells[19].Value.ToString(),
                                                dataGridView2.Rows[0].Cells[20].Value.ToString(),
                                                dataGridView2.Rows[0].Cells[21].Value.ToString(),
                                                dataGridView2.Rows[0].Cells[22].Value.ToString(),
                                                dataGridView2.Rows[0].Cells[23].Value.ToString(),
                                                dataGridView2.Rows[0].Cells[24].Value.ToString());
            Program.PHCHARACTERISTICS = new PhysicalCharacteristics(dataGridView2.Rows[0].Cells[25].Value.ToString(),
                                                                    dataGridView2.Rows[0].Cells[26].Value.ToString(),
                                                                    dataGridView2.Rows[0].Cells[27].Value.ToString(),
                                                                    dataGridView2.Rows[0].Cells[28].Value.ToString());


            Program.SERIES = new Series(dataGridView2.Rows[0].Cells[29].Value.ToString(),
                                        dataGridView2.Rows[0].Cells[30].Value.ToString(),
                                        dataGridView2.Rows[0].Cells[31].Value.ToString(),
                                        dataGridView2.Rows[0].Cells[32].Value.ToString(),
                                        dataGridView2.Rows[0].Cells[33].Value.ToString(),
                                        dataGridView2.Rows[0].Cells[34].Value.ToString(),
                                        dataGridView2.Rows[0].Cells[35].Value.ToString());

            Program.STANDARDNUMBER = new StandardNumber(dataGridView2.Rows[0].Cells[36].Value.ToString(),
                                                        dataGridView2.Rows[0].Cells[37].Value.ToString(),
                                                        dataGridView2.Rows[0].Cells[38].Value.ToString());


            AddBook addbook = new AddBook();
            addbook.Show();
           
           
          /*  dataGridView1.Rows[0].Cells[3].Value
            dataGridView2.Rows[0].Cells[4].Value
            dataGridView2.Rows[0].Cells[5].Value
            dataGridView2.Rows[0].Cells[6].Value
            dataGridView2.Rows[0].Cells[7].Value
            dataGridView2.Rows[0].Cells[8].Value
            Program.PUBLICATION = new Publication(dataGridView2.Rows[0].Cells[9].Value.ToString(),
                                                  dataGridView2.Rows[0].Cells[10].Value.ToString(),
                                                  dataGridView2.Rows[0].Cells[11].Value.ToString(),
                                                  dataGridView2.Rows[0].Cells[12].Value.ToString(),
                                                  dataGridView2.Rows[0].Cells[13].Value.ToString(),
                                                  dataGridView2.Rows[0].Cells[14].Value.ToString(),
                                                  dataGridView2.Rows[0].Cells[15].Value.ToString());
            Program.OUTPUTDATA = new OutputData(dataGridView2.Rows[0].Cells[16].Value.ToString(),
                                                dataGridView2.Rows[0].Cells[17].Value.ToString(),
                                                dataGridView2.Rows[0].Cells[18].Value.ToString(),
                                                dataGridView2.Rows[0].Cells[19].Value.ToString(),
                                                dataGridView2.Rows[0].Cells[20].Value.ToString(),
                                                dataGridView2.Rows[0].Cells[21].Value.ToString(),
                                                dataGridView2.Rows[0].Cells[22].Value.ToString(),
                                                dataGridView2.Rows[0].Cells[23].Value.ToString(),
                                                dataGridView2.Rows[0].Cells[24].Value.ToString());
            Program.PHCHARACTERISTICS = new PhysicalCharacteristics(dataGridView2.Rows[0].Cells[25].Value.ToString(),
                                                                    dataGridView2.Rows[0].Cells[26].Value.ToString(),
                                                                    dataGridView2.Rows[0].Cells[27].Value.ToString(),
                                                                    dataGridView2.Rows[0].Cells[28].Value.ToString());


            Program.SERIES = new Series(dataGridView2.Rows[0].Cells[29].Value.ToString(),
                                        dataGridView2.Rows[0].Cells[30].Value.ToString(),
                                        dataGridView2.Rows[0].Cells[31].Value.ToString(),
                                        dataGridView2.Rows[0].Cells[32].Value.ToString(),
                                        dataGridView2.Rows[0].Cells[33].Value.ToString(),
                                        dataGridView2.Rows[0].Cells[34].Value.ToString(),
                                        dataGridView2.Rows[0].Cells[35].Value.ToString());

            Program.STANDARDNUMBER = new StandardNumber(dataGridView2.Rows[0].Cells[36].Value.ToString(),
                                                        dataGridView2.Rows[0].Cells[37].Value.ToString(),
                                                        dataGridView2.Rows[0].Cells[38].Value.ToString());*/


        }
    }
}
