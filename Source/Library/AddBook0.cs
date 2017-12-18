using System;
using System.Windows.Forms;

namespace Library
{
    public partial class AddBook0 : Form
    {
        public AddBook0()
        {
            InitializeComponent();
        }

        void button3_Click(object sender, EventArgs e)
        {
            Program.PUBLICATION = new Publication(textBoxInformationOnThePublication.Text, textBoxParallelInformationAboutThePublication.Text, textBoxFirstInformationOnLiabilityRelatingPublication.Text,
                textBoxFurtherInformationOnLiabilityRelatingPublication.Text, textBoxAdditionalInformationAboutPublication.Text, textBoxFirstInformationOnLiabilityRelatingToAdditionalInformationPublication.Text,
                textBoxFurtherInformationOnLiabilityRelatingToAdditionalInformationPublication.Text);
            Close();

            var addbook = new AddBook();

            addbook.textBoxAuthor.Text = Program.HEADER.Author.ToString();
            addbook.textBoxAuthorSign.Text = Program.HEADER.AuthorSign.ToString();
            addbook.textBoxMainTitle.Text = Program.TITLE.MainTitle.ToString();
            addbook.textBoxGeneralMaterialDesignation.Text = Program.TITLE.GeneralMaterialDesignation.ToString();
            addbook.textBoxParallelTitle.Text = Program.TITLE.ParallelTitle.ToString();
            addbook.textBoxInformationPertainingToTheTitle.Text = Program.TITLE.InformationPertainingToTheTitle.ToString();
            addbook.textBoxFirstInformationOnLiability.Text = Program.TITLE.FirstInformationOnLiability.ToString();
            addbook.textBoxFurtherInformationOnLiability.Text = Program.TITLE.FurtherInformationOnLiability.ToString();

            addbook.Show();
        }

        void button1_Click(object sender, EventArgs e)
        {
            Program.PUBLICATION = new Publication(textBoxInformationOnThePublication.Text, textBoxParallelInformationAboutThePublication.Text, textBoxFirstInformationOnLiabilityRelatingPublication.Text,
                textBoxFurtherInformationOnLiabilityRelatingPublication.Text, textBoxAdditionalInformationAboutPublication.Text, textBoxFirstInformationOnLiabilityRelatingToAdditionalInformationPublication.Text,
                textBoxFurtherInformationOnLiabilityRelatingToAdditionalInformationPublication.Text);
            Close();
            var addbook1 = new AddBook1();
            addbook1.textBoxPlacePublication.Text = Program.OUTPUTDATA.PlacePublication;
            addbook1.textBoxFirstPlacePublication.Text = Program.OUTPUTDATA.FirstPlacePublication;
            addbook1.textBoxSubsequentPlacePublication.Text = Program.OUTPUTDATA.SubsequentPlacePublication;
            addbook1.textBoxNamePublisherDistributor.Text = Program.OUTPUTDATA.NamePublisherDistributor;
            addbook1.textBoxInformationAboutFunctionsPublisher.Text = Program.OUTPUTDATA.InformationAboutFunctionsPublisher;
            addbook1.textBoxDatePublication.Text = Program.OUTPUTDATA.DatePublication;
            addbook1.textBoxPlaceManufacture.Text = Program.OUTPUTDATA.PlaceManufacture;
            addbook1.textBoxManufacturerName.Text = Program.OUTPUTDATA.ManufacturerName;
            addbook1.textBoxDateManufacture.Text = Program.OUTPUTDATA.DateManufacture;

            addbook1.textBoxSpecificDesignationMaterialAndVolume.Text = Program.PHCHARACTERISTICS.SpecificDesignationMaterialAndVolume;
            addbook1.textBoxOtherInformationAboutPhysicalCharacteristics.Text = Program.PHCHARACTERISTICS.OtherInformationAboutPhysicalCharacteristics;
            addbook1.textBoxDimensions.Text = Program.PHCHARACTERISTICS.Dimensions;
            addbook1.textBoxInformationAccompanyingMaterial.Text = Program.PHCHARACTERISTICS.InformationAccompanyingMaterial;

            addbook1.Show();
        }
    }
}