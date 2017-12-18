using System;
using System.Windows.Forms;

namespace Library
{
    public partial class AddBook2 : Form
    {
        public AddBook2()
        {
            InitializeComponent();
            if (Program.N == 1)
            {
                buttonSaveForm2.Visible = true;
                button1.Visible = false;
            }
            else
            {
                buttonSaveForm2.Visible = false;
                button1.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.SERIES = new Series(textBoxTitleSeries.Text, textBoxParallelTitleSeries.Text,
                textBoxInformationPertainingTitleSeries.Text,
                textBoxFirstInformationAboutLiabilityRelatedSeries.Text,
                textBoxSubsequentLiabilityInformationRelatingSeries.Text, textBoxISSN.Text,
                textBoxIssueNumberSeries.Text);

            var price = new Price
            {
                RUB = Convert.ToInt32(textBoxRUB.Text),
                COP = Convert.ToInt32(textBoxCOP.Text)
            };

            Program.STANDARDNUMBER = new StandardNumber(textBoxISBN.Text, textBoxBBK.Text, price);

            Close();
            var addbook1 = new AddBook1();
            addbook1.textBoxPlacePublication.Text = Program.OUTPUTDATA.PlacePublication;
            addbook1.textBoxFirstPlacePublication.Text = Program.OUTPUTDATA.FirstPlacePublication;
            addbook1.textBoxSubsequentPlacePublication.Text = Program.OUTPUTDATA.SubsequentPlacePublication;
            addbook1.textBoxNamePublisherDistributor.Text = Program.OUTPUTDATA.NamePublisherDistributor;
            addbook1.textBoxInformationAboutFunctionsPublisher.Text =
                Program.OUTPUTDATA.InformationAboutFunctionsPublisher;
            addbook1.textBoxDatePublication.Text = Program.OUTPUTDATA.DatePublication;
            addbook1.textBoxPlaceManufacture.Text = Program.OUTPUTDATA.PlaceManufacture;
            addbook1.textBoxManufacturerName.Text = Program.OUTPUTDATA.ManufacturerName;
            addbook1.textBoxDateManufacture.Text = Program.OUTPUTDATA.DateManufacture;

            addbook1.textBoxSpecificDesignationMaterialAndVolume.Text =
                Program.PHCHARACTERISTICS.SpecificDesignationMaterialAndVolume;
            addbook1.textBoxOtherInformationAboutPhysicalCharacteristics.Text =
                Program.PHCHARACTERISTICS.OtherInformationAboutPhysicalCharacteristics;
            addbook1.textBoxDimensions.Text = Program.PHCHARACTERISTICS.Dimensions;
            addbook1.textBoxInformationAccompanyingMaterial.Text =
                Program.PHCHARACTERISTICS.InformationAccompanyingMaterial;

            addbook1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.SERIES = new Series(textBoxTitleSeries.Text, textBoxParallelTitleSeries.Text,
                textBoxInformationPertainingTitleSeries.Text,
                textBoxFirstInformationAboutLiabilityRelatedSeries.Text,
                textBoxSubsequentLiabilityInformationRelatingSeries.Text, textBoxISSN.Text,
                textBoxIssueNumberSeries.Text);

            var price = new Price
            {
                RUB = Convert.ToInt32(textBoxRUB.Text),
                COP = Convert.ToInt32(textBoxCOP.Text)
            };

            Program.STANDARDNUMBER = new StandardNumber(textBoxISBN.Text, textBoxBBK.Text, price);

            var DB = new DataBaseClass();
            if (DB.Insert())
                MessageBox.Show("Успешно добавлено");
            else
                MessageBox.Show("Произошла ошибка при добавлении");

            Close();
        }

        private void buttonSaveForm2_Click(object sender, EventArgs e)
        {
            Program.SERIES = new Series(textBoxTitleSeries.Text, textBoxParallelTitleSeries.Text,
                textBoxInformationPertainingTitleSeries.Text,
                textBoxFirstInformationAboutLiabilityRelatedSeries.Text,
                textBoxSubsequentLiabilityInformationRelatingSeries.Text, textBoxISSN.Text,
                textBoxIssueNumberSeries.Text);
            var price = new Price
            {
                RUB = Convert.ToInt32(textBoxRUB.Text),
                COP = Convert.ToInt32(textBoxCOP.Text)
            };
            Program.STANDARDNUMBER = new StandardNumber(textBoxISBN.Text, textBoxBBK.Text, price);

            var DB = new DataBaseClass();

            if (DB.Update(Program.currentID))
                MessageBox.Show("Успешно обновлено");
            else
                MessageBox.Show("Произошла ошибка при обновлении");

            Close();
        }
    }
}