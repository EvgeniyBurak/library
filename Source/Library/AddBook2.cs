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

            using (SqlConnection con = new SqlConnection(@"Data Source=ЖЕНЯ-ПК; Initial Catalog=Books;Integrated Security=True"))
            {
                try
                {
                    string sql = "INSERT INTO Book2 (Author, AuthorSign, MainTitle, GeneralMaterialDesignation, ParallelTitle, " +
                        "InformationPertainingToTheTitle, FirstInformationOnLiability, FurtherInformationOnLiability, " +
                        "InformationOnThePublication, ParallelInformationAboutThePublication, FirstInformationOnLiabilityRelatingPublication, " +
                        "FurtherInformationOnLiabilityRelatingPublication, AdditionalInformationAboutPublication, " +
                        "FirstInformationOnLiabilityRelatingToAdditionalInformationPublication, FurtherInformationOnLiabilityRelatingToAdditionalInformationPublication, " +
                        "PlacePublication, " +
                        "FirstPlacePublication, " +
                        "SubsequentPlacePublication, " +
                        "NamePublisherDistributor, " +
                        "InformationAboutFunctionsPublisher, " +
                        "DatePublication, " +
                        "PlaceManufacture, " +
                        "ManufacturerName, " +
                        "DateManufacture, " +

                        "SpecificDesignationMaterialAndVolume, " +
                        "OtherInformationAboutPhysicalCharacteristics, " +
                        "Dimensions, " +
                        "InformationAccompanyingMaterial, " +

                        "TitleSeries, " +
                        "ParallelTitleSeries, " +
                        "InformationPertainingTitleSeries, " +
                        "FirstInformationAboutLiabilityRelatedSeries, " +
                        "SubsequentLiabilityInformationRelatingSeries, " +
                        "ISSN, " +
                        "IssueNumberSeries, " +

                        "ISBN, " +
                        "BBK, " +
                        "Price, " +
                        "AddData)" +


                    "VALUES (@Author, @AuthorSign, @MainTitle, @GeneralMaterialDesignation, @ParallelTitle, " +
                        "@InformationPertainingToTheTitle, @FirstInformationOnLiability, @FurtherInformationOnLiability, " +
                        "@InformationOnThePublication, @ParallelInformationAboutThePublication, @FirstInformationOnLiabilityRelatingPublication, " +
                        "@FurtherInformationOnLiabilityRelatingPublication, @AdditionalInformationAboutPublication, " +
                        "@FirstInformationOnLiabilityRelatingToAdditionalInformationPublication, @FurtherInformationOnLiabilityRelatingToAdditionalInformationPublication, " +
                        "@PlacePublication, " +
                        "@FirstPlacePublication, " +
                        "@SubsequentPlacePublication, " +
                        "@NamePublisherDistributor, " +
                        "@InformationAboutFunctionsPublisher, " +
                        "@DatePublication, " +
                        "@PlaceManufacture, " +
                        "@ManufacturerName, " +
                        "@DateManufacture, " +

                        "@SpecificDesignationMaterialAndVolume, " +
                        "@OtherInformationAboutPhysicalCharacteristics, " +
                        "@Dimensions, " +
                        "@InformationAccompanyingMaterial, " +

                        "@TitleSeries, " +
                        "@ParallelTitleSeries, " +
                        "@InformationPertainingTitleSeries, " +
                        "@FirstInformationAboutLiabilityRelatedSeries, " +
                        "@SubsequentLiabilityInformationRelatingSeries, " +
                        "@ISSN, " +
                        "@IssueNumberSeries, " +

                        "@ISBN, " +
                        "@BBK, " +
                        "@Price, " +
                        "@AddData);" ;

                    con.Open();
                    SqlCommand cmd = new SqlCommand(sql, con);
                    //создаем параметры и добавляем их в коллекцию
                  
                    cmd.Parameters.AddWithValue("@Author", Program.HEADER.Author);
                    cmd.Parameters.AddWithValue("@AuthorSign", Program.HEADER.AuthorSign);
              
                    cmd.Parameters.AddWithValue("@MainTitle", Program.TITLE.MainTitle);
                    cmd.Parameters.AddWithValue("@GeneralMaterialDesignation", Program.TITLE.GeneralMaterialDesignation);
                    cmd.Parameters.AddWithValue("@ParallelTitle", Program.TITLE.ParallelTitle);
                    cmd.Parameters.AddWithValue("@InformationPertainingToTheTitle", Program.TITLE.InformationPertainingToTheTitle);
                    cmd.Parameters.AddWithValue("@FirstInformationOnLiability", Program.TITLE.FirstInformationOnLiability);
                    cmd.Parameters.AddWithValue("@FurtherInformationOnLiability", Program.TITLE.FurtherInformationOnLiability);

                    cmd.Parameters.AddWithValue("@InformationOnThePublication", Program.PUBLICATION.InformationOnThePublication);
                    cmd.Parameters.AddWithValue("@ParallelInformationAboutThePublication", Program.PUBLICATION.ParallelInformationAboutThePublication);
                    cmd.Parameters.AddWithValue("@FirstInformationOnLiabilityRelatingPublication", Program.PUBLICATION.FirstInformationOnLiabilityRelatingPublication);
                    cmd.Parameters.AddWithValue("@FurtherInformationOnLiabilityRelatingPublication", Program.PUBLICATION.FurtherInformationOnLiabilityRelatingPublication);
                    cmd.Parameters.AddWithValue("@AdditionalInformationAboutPublication", Program.PUBLICATION.AdditionalInformationAboutPublication);
                    cmd.Parameters.AddWithValue("@FirstInformationOnLiabilityRelatingToAdditionalInformationPublication", Program.PUBLICATION.FirstInformationOnLiabilityRelatingToAdditionalInformationPublication);
                    cmd.Parameters.AddWithValue("@FurtherInformationOnLiabilityRelatingToAdditionalInformationPublication", Program.PUBLICATION.FurtherInformationOnLiabilityRelatingToAdditionalInformationPublication);

                    cmd.Parameters.AddWithValue("@PlacePublication", Program.OUTPUTDATA.PlacePublication);
                    cmd.Parameters.AddWithValue("@FirstPlacePublication", Program.OUTPUTDATA.FirstPlacePublication);
                    cmd.Parameters.AddWithValue("@SubsequentPlacePublication", Program.OUTPUTDATA.SubsequentPlacePublication);
                    cmd.Parameters.AddWithValue("@NamePublisherDistributor", Program.OUTPUTDATA.NamePublisherDistributor);
                    cmd.Parameters.AddWithValue("@InformationAboutFunctionsPublisher", Program.OUTPUTDATA.InformationAboutFunctionsPublisher);
                    cmd.Parameters.AddWithValue("@DatePublication", Program.OUTPUTDATA.DatePublication);
                    cmd.Parameters.AddWithValue("@PlaceManufacture", Program.OUTPUTDATA.PlaceManufacture);
                    cmd.Parameters.AddWithValue("@ManufacturerName", Program.OUTPUTDATA.ManufacturerName);
                    cmd.Parameters.AddWithValue("@DateManufacture", Program.OUTPUTDATA.DateManufacture);

                    cmd.Parameters.AddWithValue("@SpecificDesignationMaterialAndVolume", Program.PHCHARACTERISTICS.SpecificDesignationMaterialAndVolume);
                    cmd.Parameters.AddWithValue("@OtherInformationAboutPhysicalCharacteristics", Program.PHCHARACTERISTICS.OtherInformationAboutPhysicalCharacteristics);
                    cmd.Parameters.AddWithValue("@Dimensions", Program.PHCHARACTERISTICS.Dimensions);
                    cmd.Parameters.AddWithValue("@InformationAccompanyingMaterial", Program.PHCHARACTERISTICS.InformationAccompanyingMaterial);

                    cmd.Parameters.AddWithValue("@TitleSeries", Program.SERIES.TitleSeries);        
                    cmd.Parameters.AddWithValue("@ParallelTitleSeries", Program.SERIES.ParallelTitleSeries);
                    cmd.Parameters.AddWithValue("@InformationPertainingTitleSeries", Program.SERIES.InformationPertainingTitleSeries);
                    cmd.Parameters.AddWithValue("@FirstInformationAboutLiabilityRelatedSeries", Program.SERIES.FirstInformationAboutLiabilityRelatedSeries);
                    cmd.Parameters.AddWithValue("@SubsequentLiabilityInformationRelatingSeries", Program.SERIES.SubsequentLiabilityInformationRelatingSeries);
                    cmd.Parameters.AddWithValue("@ISSN", Program.SERIES.ISSN);
                    cmd.Parameters.AddWithValue("@IssueNumberSeries", Program.SERIES.IssueNumberSeries);

                    cmd.Parameters.AddWithValue("@ISBN", Program.STANDARDNUMBER.ISBN);
                    cmd.Parameters.AddWithValue("@BBK", Program.STANDARDNUMBER.BBK);
                    cmd.Parameters.AddWithValue("@Price", Program.STANDARDNUMBER.Price);
                    cmd.Parameters.AddWithValue("@AddData", DateTime.Today.ToString());

                   
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                MessageBox.Show("Успешно добавлено");
                
                this.Close();
            }




        }
    }
}
