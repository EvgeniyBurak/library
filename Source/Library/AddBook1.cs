using System;
using System.Windows.Forms;

namespace Library
{
    public partial class AddBook1 : Form
    {
        public AddBook1()
        {
            InitializeComponent();
        }

        void button3_Click(object sender, EventArgs e)
        {
            Program.OUTPUTDATA = new OutputData(textBoxPlacePublication.Text, textBoxFirstPlacePublication.Text, textBoxSubsequentPlacePublication.Text,
                textBoxNamePublisherDistributor.Text, textBoxInformationAboutFunctionsPublisher.Text, textBoxDatePublication.Text,
                textBoxPlaceManufacture.Text, textBoxManufacturerName.Text, textBoxDateManufacture.Text);

            Program.PHCHARACTERISTICS = new PhysicalCharacteristics(textBoxSpecificDesignationMaterialAndVolume.Text, textBoxOtherInformationAboutPhysicalCharacteristics.Text,
                textBoxDimensions.Text, textBoxInformationAccompanyingMaterial.Text);
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

        void button1_Click(object sender, EventArgs e)
        {
            Program.OUTPUTDATA = new OutputData(textBoxPlacePublication.Text, textBoxFirstPlacePublication.Text, textBoxSubsequentPlacePublication.Text,
               textBoxNamePublisherDistributor.Text, textBoxInformationAboutFunctionsPublisher.Text, textBoxDatePublication.Text,
               textBoxPlaceManufacture.Text, textBoxManufacturerName.Text, textBoxDateManufacture.Text);

            Program.PHCHARACTERISTICS = new PhysicalCharacteristics(textBoxSpecificDesignationMaterialAndVolume.Text, textBoxOtherInformationAboutPhysicalCharacteristics.Text,
                textBoxDimensions.Text, textBoxInformationAccompanyingMaterial.Text);

            Close();
            var addbook2 = new AddBook2();
            addbook2.textBoxISBN.Text = Program.STANDARDNUMBER.ISBN;
            addbook2.textBoxBBK.Text = Program.STANDARDNUMBER.BBK;
            addbook2.textBoxRUB.Text = Program.STANDARDNUMBER.Pric.RUB.ToString();
            addbook2.textBoxCOP.Text = Program.STANDARDNUMBER.Pric.COP.ToString();

            addbook2.textBoxTitleSeries.Text = Program.SERIES.TitleSeries;
            addbook2.textBoxFirstInformationAboutLiabilityRelatedSeries.Text = Program.SERIES.FirstInformationAboutLiabilityRelatedSeries;
            addbook2.textBoxInformationPertainingTitleSeries.Text = Program.SERIES.InformationPertainingTitleSeries;
            addbook2.textBoxISSN.Text = Program.SERIES.ISSN;
            addbook2.textBoxIssueNumberSeries.Text = Program.SERIES.IssueNumberSeries;
            addbook2.textBoxParallelTitleSeries.Text = Program.SERIES.ParallelTitleSeries;
            addbook2.textBoxSubsequentLiabilityInformationRelatingSeries.Text = Program.SERIES.SubsequentLiabilityInformationRelatingSeries;

            addbook2.Show();
        }
    }
}