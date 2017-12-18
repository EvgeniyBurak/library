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
                textBoxAuthor.Text = Program.HEADER.Author;
                textBoxAuthorSign.Text = Program.HEADER.AuthorSign;
                textBoxMainTitle.Text = Program.TITLE.MainTitle;
                textBoxGeneralMaterialDesignation.Text = Program.TITLE.GeneralMaterialDesignation;
                textBoxParallelTitle.Text = Program.TITLE.ParallelTitle;
                textBoxInformationPertainingToTheTitle.Text = Program.TITLE.InformationPertainingToTheTitle;
                textBoxFirstInformationOnLiability.Text = Program.TITLE.FirstInformationOnLiability;
                textBoxFurtherInformationOnLiability.Text = Program.TITLE.FurtherInformationOnLiability;
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Program.HEADER = new Header(textBoxAuthor.Text, textBoxAuthorSign.Text);
            Program.TITLE = new Title(textBoxMainTitle.Text, textBoxGeneralMaterialDesignation.Text,
                textBoxParallelTitle.Text, textBoxInformationPertainingToTheTitle.Text,
                textBoxFirstInformationOnLiability.Text, textBoxFurtherInformationOnLiability.Text);
            Close();

            var addbook0 = new AddBook0();
            addbook0.textBoxAdditionalInformationAboutPublication.Text =
                Program.PUBLICATION.InformationOnThePublication;
            addbook0.textBoxFirstInformationOnLiabilityRelatingPublication.Text =
                Program.PUBLICATION.FirstInformationOnLiabilityRelatingPublication;
            addbook0.textBoxFirstInformationOnLiabilityRelatingToAdditionalInformationPublication.Text =
                Program.PUBLICATION.FirstInformationOnLiabilityRelatingToAdditionalInformationPublication;
            addbook0.textBoxFurtherInformationOnLiabilityRelatingPublication.Text =
                Program.PUBLICATION.FurtherInformationOnLiabilityRelatingPublication;
            addbook0.textBoxFurtherInformationOnLiabilityRelatingToAdditionalInformationPublication.Text = Program
                .PUBLICATION.FurtherInformationOnLiabilityRelatingToAdditionalInformationPublication;
            addbook0.textBoxInformationOnThePublication.Text = Program.PUBLICATION.InformationOnThePublication;
            addbook0.textBoxParallelInformationAboutThePublication.Text =
                Program.PUBLICATION.ParallelInformationAboutThePublication;
            addbook0.Show();
        }
    }
}