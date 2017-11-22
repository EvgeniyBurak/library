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
    public partial class AddBook1 : Form
    {
        public AddBook1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.OUTPUTDATA = new OutputData(textBoxPlacePublication.Text,textBoxFirstPlacePublication.Text,textBoxSubsequentPlacePublication.Text,
                textBoxNamePublisherDistributor.Text, textBoxInformationAboutFunctionsPublisher.Text,textBoxDatePublication.Text,
                textBoxPlaceManufacture.Text,textBoxManufacturerName.Text,textBoxDateManufacture.Text );

            Program.PHCHARACTERISTICS = new PhysicalCharacteristics(textBoxSpecificDesignationMaterialAndVolume.Text,textBoxOtherInformationAboutPhysicalCharacteristics.Text,
                textBoxDimensions.Text,textBoxInformationAccompanyingMaterial.Text);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Program.OUTPUTDATA = new OutputData(textBoxPlacePublication.Text, textBoxFirstPlacePublication.Text, textBoxSubsequentPlacePublication.Text,
               textBoxNamePublisherDistributor.Text, textBoxInformationAboutFunctionsPublisher.Text, textBoxDatePublication.Text,
               textBoxPlaceManufacture.Text, textBoxManufacturerName.Text, textBoxDateManufacture.Text);

            Program.PHCHARACTERISTICS = new PhysicalCharacteristics(textBoxSpecificDesignationMaterialAndVolume.Text, textBoxOtherInformationAboutPhysicalCharacteristics.Text,
                textBoxDimensions.Text, textBoxInformationAccompanyingMaterial.Text);

            this.Close();
            AddBook2 addbook2 = new AddBook2();
            addbook2.textBoxISBN.Text = Program.STANDARDNUMBER.ISBN;
            addbook2.textBoxBBK.Text = Program.STANDARDNUMBER.BBK;
            addbook2.textBoxPrice.Text = Program.STANDARDNUMBER.Price;


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
