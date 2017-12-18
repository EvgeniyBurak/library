using System;
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
                textBoxAuthor.Text = Program.HEADER.Author.ToString();
                textBoxAuthorSign.Text = Program.HEADER.AuthorSign.ToString();
                textBoxMainTitle.Text = Program.TITLE.MainTitle.ToString();
                textBoxGeneralMaterialDesignation.Text = Program.TITLE.GeneralMaterialDesignation.ToString();
                textBoxParallelTitle.Text = Program.TITLE.ParallelTitle.ToString();
                textBoxInformationPertainingToTheTitle.Text = Program.TITLE.InformationPertainingToTheTitle.ToString();
                textBoxFirstInformationOnLiability.Text = Program.TITLE.FirstInformationOnLiability.ToString();
                textBoxFurtherInformationOnLiability.Text = Program.TITLE.FurtherInformationOnLiability.ToString();
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Program.HEADER = new Header(textBoxAuthor.Text.ToString(), textBoxAuthorSign.Text.ToString());
            Program.TITLE = new Title(textBoxMainTitle.Text.ToString(), textBoxGeneralMaterialDesignation.Text.ToString(), textBoxParallelTitle.Text.ToString(), textBoxInformationPertainingToTheTitle.Text.ToString(), textBoxFirstInformationOnLiability.Text.ToString(), textBoxFurtherInformationOnLiability.Text.ToString());
            Close();

            var addbook0 = new AddBook0();
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