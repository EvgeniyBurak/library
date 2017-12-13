using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{

   

    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
            if (Program.N == 1)
            {
                this.textBoxAuthor.Text = Program.HEADER.Author.ToString();
                this.textBoxAuthorSign.Text = Program.HEADER.AuthorSign.ToString();
                this.textBoxMainTitle.Text = Program.TITLE.MainTitle.ToString();
                this.textBoxGeneralMaterialDesignation.Text = Program.TITLE.GeneralMaterialDesignation.ToString();
                this.textBoxParallelTitle.Text = Program.TITLE.ParallelTitle.ToString();
                this.textBoxInformationPertainingToTheTitle.Text = Program.TITLE.InformationPertainingToTheTitle.ToString();
                this.textBoxFirstInformationOnLiability.Text = Program.TITLE.FirstInformationOnLiability.ToString();
                this.textBoxFurtherInformationOnLiability.Text = Program.TITLE.FurtherInformationOnLiability.ToString();

            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Program.HEADER = new Header(textBoxAuthor.Text.ToString(), textBoxAuthorSign.Text.ToString());
            Program.TITLE = new Title(textBoxMainTitle.Text.ToString(), textBoxGeneralMaterialDesignation.Text.ToString(), textBoxParallelTitle.Text.ToString(), textBoxInformationPertainingToTheTitle.Text.ToString(), textBoxFirstInformationOnLiability.Text.ToString(), textBoxFurtherInformationOnLiability.Text.ToString());
            this.Close();

            AddBook0 addbook0 = new AddBook0();
            addbook0.textBoxAdditionalInformationAboutPublication.Text = Program.PUBLICATION.InformationOnThePublication;
            addbook0.textBoxFirstInformationOnLiabilityRelatingPublication.Text = Program.PUBLICATION.FirstInformationOnLiabilityRelatingPublication;
            addbook0.textBoxFirstInformationOnLiabilityRelatingToAdditionalInformationPublication.Text = Program.PUBLICATION.FirstInformationOnLiabilityRelatingToAdditionalInformationPublication;
            addbook0.textBoxFurtherInformationOnLiabilityRelatingPublication.Text = Program.PUBLICATION.FurtherInformationOnLiabilityRelatingPublication;
            addbook0.textBoxFurtherInformationOnLiabilityRelatingToAdditionalInformationPublication.Text = Program.PUBLICATION.FurtherInformationOnLiabilityRelatingToAdditionalInformationPublication;
            addbook0.textBoxInformationOnThePublication.Text = Program.PUBLICATION.InformationOnThePublication;
            addbook0.textBoxParallelInformationAboutThePublication.Text = Program.PUBLICATION.ParallelInformationAboutThePublication;
            addbook0.Show();
        }
    }
}
