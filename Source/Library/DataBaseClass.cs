using System;
using System.Data.SqlClient;

namespace Library
{
    internal class DataBaseClass
    {
        public bool Update(int iD)
        {
            using (var con = new SqlConnection(@"Data Source=YAUHENI-PK; Initial Catalog=Books;Integrated Security=True"))
            {
                try
                {
                    var sql = "UPDATE Book2 SET Author='" + Program.HEADER.Author +
                              "', AuthorSign='" + Program.HEADER.AuthorSign +
                              "', MainTitle='" + Program.TITLE.MainTitle +
                              "', GeneralMaterialDesignation='" + Program.TITLE.GeneralMaterialDesignation +
                              "', ParallelTitle='" + Program.TITLE.ParallelTitle +
                              "', InformationPertainingToTheTitle='" + Program.TITLE.InformationPertainingToTheTitle +
                              "', FirstInformationOnLiability='" + Program.TITLE.FirstInformationOnLiability +
                              "', FurtherInformationOnLiability='" + Program.TITLE.FurtherInformationOnLiability +
                              "', InformationOnThePublication='" + Program.PUBLICATION.InformationOnThePublication +
                              "', ParallelInformationAboutThePublication='" +
                              Program.PUBLICATION.ParallelInformationAboutThePublication +
                              "', FirstInformationOnLiabilityRelatingPublication='" +
                              Program.PUBLICATION.FirstInformationOnLiabilityRelatingPublication +
                              "', FurtherInformationOnLiabilityRelatingPublication='" +
                              Program.PUBLICATION.FurtherInformationOnLiabilityRelatingPublication +
                              "', AdditionalInformationAboutPublication='" +
                              Program.PUBLICATION.AdditionalInformationAboutPublication +
                              "', FirstInformationOnLiabilityRelatingToAdditionalInformationPublication='" +
                              Program.PUBLICATION
                                  .FirstInformationOnLiabilityRelatingToAdditionalInformationPublication +
                              "', FurtherInformationOnLiabilityRelatingToAdditionalInformationPublication='" +
                              Program.PUBLICATION
                                  .FurtherInformationOnLiabilityRelatingToAdditionalInformationPublication +
                              "', PlacePublication='" + Program.OUTPUTDATA.PlacePublication +
                              "', FirstPlacePublication='" + Program.OUTPUTDATA.FirstPlacePublication +
                              "', SubsequentPlacePublication='" + Program.OUTPUTDATA.SubsequentPlacePublication +
                              "', NamePublisherDistributor='" + Program.OUTPUTDATA.NamePublisherDistributor +
                              "', InformationAboutFunctionsPublisher='" +
                              Program.OUTPUTDATA.InformationAboutFunctionsPublisher +
                              "', DatePublication='" + Program.OUTPUTDATA.DatePublication +
                              "', PlaceManufacture='" + Program.OUTPUTDATA.PlaceManufacture +
                              "', ManufacturerName='" + Program.OUTPUTDATA.ManufacturerName +
                              "', DateManufacture='" + Program.OUTPUTDATA.DateManufacture +
                              "', SpecificDesignationMaterialAndVolume='" +
                              Program.PHCHARACTERISTICS.SpecificDesignationMaterialAndVolume +
                              "', OtherInformationAboutPhysicalCharacteristics='" + Program.PHCHARACTERISTICS
                                  .OtherInformationAboutPhysicalCharacteristics +
                              "', Dimensions='" + Program.PHCHARACTERISTICS.Dimensions +
                              "', InformationAccompanyingMaterial='" +
                              Program.PHCHARACTERISTICS.InformationAccompanyingMaterial +
                              "', TitleSeries='" + Program.SERIES.TitleSeries +
                              "', ParallelTitleSeries='" + Program.SERIES.ParallelTitleSeries +
                              "', InformationPertainingTitleSeries='" +
                              Program.SERIES.InformationPertainingTitleSeries +
                              "', FirstInformationAboutLiabilityRelatedSeries='" +
                              Program.SERIES.FirstInformationAboutLiabilityRelatedSeries +
                              "', SubsequentLiabilityInformationRelatingSeries='" +
                              Program.SERIES.SubsequentLiabilityInformationRelatingSeries +
                              "', ISSN='" + Program.SERIES.ISSN +
                              "', IssueNumberSeries='" + Program.SERIES.IssueNumberSeries +
                              "', ISBN='" + Program.STANDARDNUMBER.ISBN +
                              "', BBK='" + Program.STANDARDNUMBER.BBK +
                              "', Price=" + Program.STANDARDNUMBER.Price +
                              " WHERE id='" + iD + "';";

                    con.Open();
                    var cmd = new SqlCommand(sql, con);
                    // создаем параметры и добавляем их в коллекцию
                    SqlDataReader myReader2;
                    myReader2 = cmd.ExecuteReader();

                    while (myReader2.Read())
                    {
                    }

                    con.Close(); //Connection closed here  
                }
                catch (Exception ex)
                {
                    return false;
                }
            }

            return true;
        }

        public bool Delete(int id)
        {
            using (var con = new SqlConnection(@"Data Source=YAUHENI-PK; Initial Catalog=Books;Integrated Security=True"))
            {
                try
                {
                    var sql = "delete from book2 where id='" + id + "';";

                    con.Open();
                    var cmd = new SqlCommand(sql, con);
                    // создаем параметры и добавляем их в коллекцию

                    SqlDataReader MyReader2;
                    MyReader2 = cmd.ExecuteReader();

                    while (MyReader2.Read())
                    {
                    }

                    con.Close(); //Connection closed here  
                }
                catch (Exception ex)
                {
                    return false;
                }

                return true;
            }
        }

        public bool Insert()
        {
            using (var con = new SqlConnection(@"Data Source=YAUHENI-PK; Initial Catalog=Books;Integrated Security=True"))
            {
                try
                {
                    var sql =
                        "INSERT INTO Book2 (Author, AuthorSign, MainTitle, GeneralMaterialDesignation, ParallelTitle, " +
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
                        "@AddData);";

                    con.Open();
                    var cmd = new SqlCommand(sql, con);
                    // создаем параметры и добавляем их в коллекцию

                    cmd.Parameters.AddWithValue("@Author", Program.HEADER.Author);
                    cmd.Parameters.AddWithValue("@AuthorSign", Program.HEADER.AuthorSign);

                    cmd.Parameters.AddWithValue("@MainTitle", Program.TITLE.MainTitle);
                    cmd.Parameters.AddWithValue("@GeneralMaterialDesignation",
                        Program.TITLE.GeneralMaterialDesignation);
                    cmd.Parameters.AddWithValue("@ParallelTitle", Program.TITLE.ParallelTitle);
                    cmd.Parameters.AddWithValue("@InformationPertainingToTheTitle",
                        Program.TITLE.InformationPertainingToTheTitle);
                    cmd.Parameters.AddWithValue("@FirstInformationOnLiability",
                        Program.TITLE.FirstInformationOnLiability);
                    cmd.Parameters.AddWithValue("@FurtherInformationOnLiability",
                        Program.TITLE.FurtherInformationOnLiability);

                    cmd.Parameters.AddWithValue("@InformationOnThePublication",
                        Program.PUBLICATION.InformationOnThePublication);
                    cmd.Parameters.AddWithValue("@ParallelInformationAboutThePublication",
                        Program.PUBLICATION.ParallelInformationAboutThePublication);
                    cmd.Parameters.AddWithValue("@FirstInformationOnLiabilityRelatingPublication",
                        Program.PUBLICATION.FirstInformationOnLiabilityRelatingPublication);
                    cmd.Parameters.AddWithValue("@FurtherInformationOnLiabilityRelatingPublication",
                        Program.PUBLICATION.FurtherInformationOnLiabilityRelatingPublication);
                    cmd.Parameters.AddWithValue("@AdditionalInformationAboutPublication",
                        Program.PUBLICATION.AdditionalInformationAboutPublication);
                    cmd.Parameters.AddWithValue(
                        "@FirstInformationOnLiabilityRelatingToAdditionalInformationPublication",
                        Program.PUBLICATION.FirstInformationOnLiabilityRelatingToAdditionalInformationPublication);
                    cmd.Parameters.AddWithValue(
                        "@FurtherInformationOnLiabilityRelatingToAdditionalInformationPublication",
                        Program.PUBLICATION.FurtherInformationOnLiabilityRelatingToAdditionalInformationPublication);

                    cmd.Parameters.AddWithValue("@PlacePublication", Program.OUTPUTDATA.PlacePublication);
                    cmd.Parameters.AddWithValue("@FirstPlacePublication", Program.OUTPUTDATA.FirstPlacePublication);
                    cmd.Parameters.AddWithValue("@SubsequentPlacePublication",
                        Program.OUTPUTDATA.SubsequentPlacePublication);
                    cmd.Parameters.AddWithValue("@NamePublisherDistributor",
                        Program.OUTPUTDATA.NamePublisherDistributor);
                    cmd.Parameters.AddWithValue("@InformationAboutFunctionsPublisher",
                        Program.OUTPUTDATA.InformationAboutFunctionsPublisher);
                    cmd.Parameters.AddWithValue("@DatePublication", Program.OUTPUTDATA.DatePublication);
                    cmd.Parameters.AddWithValue("@PlaceManufacture", Program.OUTPUTDATA.PlaceManufacture);
                    cmd.Parameters.AddWithValue("@ManufacturerName", Program.OUTPUTDATA.ManufacturerName);
                    cmd.Parameters.AddWithValue("@DateManufacture", Program.OUTPUTDATA.DateManufacture);

                    cmd.Parameters.AddWithValue("@SpecificDesignationMaterialAndVolume",
                        Program.PHCHARACTERISTICS.SpecificDesignationMaterialAndVolume);
                    cmd.Parameters.AddWithValue("@OtherInformationAboutPhysicalCharacteristics",
                        Program.PHCHARACTERISTICS.OtherInformationAboutPhysicalCharacteristics);
                    cmd.Parameters.AddWithValue("@Dimensions", Program.PHCHARACTERISTICS.Dimensions);
                    cmd.Parameters.AddWithValue("@InformationAccompanyingMaterial",
                        Program.PHCHARACTERISTICS.InformationAccompanyingMaterial);

                    cmd.Parameters.AddWithValue("@TitleSeries", Program.SERIES.TitleSeries);
                    cmd.Parameters.AddWithValue("@ParallelTitleSeries", Program.SERIES.ParallelTitleSeries);
                    cmd.Parameters.AddWithValue("@InformationPertainingTitleSeries",
                        Program.SERIES.InformationPertainingTitleSeries);
                    cmd.Parameters.AddWithValue("@FirstInformationAboutLiabilityRelatedSeries",
                        Program.SERIES.FirstInformationAboutLiabilityRelatedSeries);
                    cmd.Parameters.AddWithValue("@SubsequentLiabilityInformationRelatingSeries",
                        Program.SERIES.SubsequentLiabilityInformationRelatingSeries);
                    cmd.Parameters.AddWithValue("@ISSN", Program.SERIES.ISSN);
                    cmd.Parameters.AddWithValue("@IssueNumberSeries", Program.SERIES.IssueNumberSeries);
                    var data = DateTime.Today.Day + "." + DateTime.Today.Month + "." + DateTime.Today.Year;
                    cmd.Parameters.AddWithValue("@ISBN", Program.STANDARDNUMBER.ISBN);
                    cmd.Parameters.AddWithValue("@BBK", Program.STANDARDNUMBER.BBK);
                    cmd.Parameters.AddWithValue("@Price", Program.STANDARDNUMBER.Price);
                    cmd.Parameters.AddWithValue("@AddData", data);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    return false;
                }

                return true;
            }
        }
    }
}