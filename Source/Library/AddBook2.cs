using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library
{
    public partial class AddBook2 : Form
    {
        public AddBook2()
        {
            InitializeComponent();
            if ( Program.N == 1)
            {
                buttonSaveForm2.Visible = true ;
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

            Program.SERIES = new Series(textBoxTitleSeries.Text, textBoxParallelTitleSeries.Text, textBoxInformationPertainingTitleSeries.Text,
                textBoxFirstInformationAboutLiabilityRelatedSeries.Text,textBoxSubsequentLiabilityInformationRelatingSeries.Text,textBoxISSN.Text,
                textBoxIssueNumberSeries.Text);

            Program.STANDARDNUMBER = new StandardNumber(textBoxISBN.Text,textBoxBBK.Text,textBoxPrice.Text);

            this.Close();
            AddBook1 addbook1 = new AddBook1();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Program.SERIES = new Series(textBoxTitleSeries.Text, textBoxParallelTitleSeries.Text, textBoxInformationPertainingTitleSeries.Text,
                textBoxFirstInformationAboutLiabilityRelatedSeries.Text, textBoxSubsequentLiabilityInformationRelatingSeries.Text, textBoxISSN.Text,
                textBoxIssueNumberSeries.Text);

            Program.STANDARDNUMBER = new StandardNumber(textBoxISBN.Text, textBoxBBK.Text, textBoxPrice.Text);

            DataBaseClass DB = new DataBaseClass();
            if(DB.Insert())
            {
                MessageBox.Show("Успешно добавлено");
            }
            else
            {
                MessageBox.Show("Произошла ошибка при добавлении");
            }
            this.Close();
        }

        private void buttonSaveForm2_Click(object sender, EventArgs e)
        {

            Program.SERIES = new Series(textBoxTitleSeries.Text, textBoxParallelTitleSeries.Text, textBoxInformationPertainingTitleSeries.Text,
              textBoxFirstInformationAboutLiabilityRelatedSeries.Text, textBoxSubsequentLiabilityInformationRelatingSeries.Text, textBoxISSN.Text,
              textBoxIssueNumberSeries.Text);

            Program.STANDARDNUMBER = new StandardNumber(textBoxISBN.Text, textBoxBBK.Text, textBoxPrice.Text);

            DataBaseClass DB = new DataBaseClass();
            
           
            if (DB.Update(Program.currentID))
            {
                MessageBox.Show("Успешно обновлено");
            }
            else
            {
                MessageBox.Show("Произошла ошибка при обновлении");
            }

            this.Close();
        }
        
    }
}
