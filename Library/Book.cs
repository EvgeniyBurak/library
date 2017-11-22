using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections; //Пространство имен где описаны интерфейсы для работы коллекций

namespace Library
{
    class Book
    {
        public Header header;
        public Title title;
        public Publication publication;
        public OutputData outputdata;
        public Series series;
        public PhysicalCharacteristics physicalCharac;
        public StandardNumber standardNumber;

        public Book() { }


    }


    class Header
    {
        
        public String Author;
        public String AuthorSign;

        public Header()
        {
            this.Author = "";
            this.AuthorSign = "";
        }
        public Header(String author, String authorSign)
        {
            this.Author = author;
            this.AuthorSign = authorSign;
        }

        public String GetSetAuthor
        {
            get
            {
                if (Author.Length <= 0)
                    return "";
                return Author;
            }

            set { Author = value; }
        }

        public String GetSetAuthorSign
        {
            get
            {
                if (AuthorSign.Length <= 0)
                    return "";
                return AuthorSign;
            }

            set { AuthorSign = value; }
        }

    }

    class Title
    {
        public String MainTitle;
        public String GeneralMaterialDesignation;
        public String ParallelTitle;
        public String InformationPertainingToTheTitle;
        public String FirstInformationOnLiability;
        public String FurtherInformationOnLiability;


        public Title()
        {
            this.MainTitle = "";
            this.GeneralMaterialDesignation = "";
            this.ParallelTitle = "";
            this.InformationPertainingToTheTitle = "";
            this.FirstInformationOnLiability = "";
            this.FurtherInformationOnLiability ="";

    }

    public Title(String MainTitle, String GeneralMaterialDesignation, String ParallelTitle, String InformationPertainingToTheTitle, String FirstInformationOnLiability, String FurtherInformationOnLiability)
        {
            this.MainTitle = MainTitle;
            this.GeneralMaterialDesignation = GeneralMaterialDesignation;
            this.ParallelTitle = ParallelTitle;
            this.InformationPertainingToTheTitle = InformationPertainingToTheTitle;
            this.FirstInformationOnLiability = FirstInformationOnLiability;
            this.FurtherInformationOnLiability = FurtherInformationOnLiability;
        }


        public String GetSetMainTitle
        {
            get
            {
                if (MainTitle.Length <= 0)
                    return "";
                return MainTitle;
            }

            set { MainTitle = value; }
        }
        public String GetSetGeneralMaterialDesignation
        {
            get
            {
                if (GeneralMaterialDesignation.Length <= 0)
                    return "";
                return GeneralMaterialDesignation;
            }

            set { GeneralMaterialDesignation = value; }
        }
        public String GetSetParallelTitle
        {
            get
            {
                if (ParallelTitle.Length <= 0)
                    return "";
                return ParallelTitle;
            }

            set { ParallelTitle = value; }
        }
        public String GetSetInformationPertainingToTheTitle
        {
            get
            {
                if (InformationPertainingToTheTitle.Length <= 0)
                    return "";
                return InformationPertainingToTheTitle;
            }

            set { InformationPertainingToTheTitle = value; }
        }
        public String GetSetFirstInformationOnLiability
        {
            get
            {
                if (FirstInformationOnLiability.Length <= 0)
                    return "";
                return FirstInformationOnLiability;
            }

            set { FirstInformationOnLiability = value; }
        }
        public String GetSetFurtherInformationOnLiability
        {
            get
            {
                if (FurtherInformationOnLiability.Length <= 0)
                    return "";
                return FurtherInformationOnLiability;
            }

            set { FurtherInformationOnLiability = value; }
        }


    }

    class Publication
    {

        public String InformationOnThePublication;
        public String ParallelInformationAboutThePublication;
        public String FirstInformationOnLiabilityRelatingPublication;
        public String FurtherInformationOnLiabilityRelatingPublication;
        public String AdditionalInformationAboutPublication;
        public String FirstInformationOnLiabilityRelatingToAdditionalInformationPublication;
        public String FurtherInformationOnLiabilityRelatingToAdditionalInformationPublication;

        public Publication() { }

        public Publication(String InformationOnThePublication, String ParallelInformationAboutThePublication, String FirstInformationOnLiabilityRelatingPublication, 
            String FurtherInformationOnLiabilityRelatingPublication, String AdditionalInformationAboutPublication, String FirstInformationOnLiabilityRelatingToAdditionalInformationPublication, String FurtherInformationOnLiabilityRelatingToAdditionalInformationPublication)
        {
            this.InformationOnThePublication = InformationOnThePublication;
            this.ParallelInformationAboutThePublication = ParallelInformationAboutThePublication;
            this.FirstInformationOnLiabilityRelatingPublication = FirstInformationOnLiabilityRelatingPublication;
            this.FurtherInformationOnLiabilityRelatingPublication = FurtherInformationOnLiabilityRelatingPublication;
            this.AdditionalInformationAboutPublication = AdditionalInformationAboutPublication;
            this.FirstInformationOnLiabilityRelatingToAdditionalInformationPublication = FirstInformationOnLiabilityRelatingToAdditionalInformationPublication;
            this.FurtherInformationOnLiabilityRelatingToAdditionalInformationPublication = FurtherInformationOnLiabilityRelatingToAdditionalInformationPublication;
        }


        public String GetSetInformationOnThePublication
        {
            get
            {
                if (InformationOnThePublication.Length <= 0)
                    return "";
                return InformationOnThePublication;
            }

            set { InformationOnThePublication = value; }
        }

        public String GetSetParallelInformationAboutThePublication
        {
            get
            {
                if (ParallelInformationAboutThePublication.Length <= 0)
                    return "";
                return ParallelInformationAboutThePublication;
            }

            set { ParallelInformationAboutThePublication = value; }
        }
        public String GetSetFirstInformationOnLiabilityRelatingPublication
        {
            get
            {
                if (FirstInformationOnLiabilityRelatingPublication.Length <= 0)
                    return "";
                return FirstInformationOnLiabilityRelatingPublication;
            }

            set { FirstInformationOnLiabilityRelatingPublication = value; }
        }
        public String GetSetFurtherInformationOnLiabilityRelatingPublication
        {
            get
            {
                if (FurtherInformationOnLiabilityRelatingPublication.Length <= 0)
                    return "";
                return FurtherInformationOnLiabilityRelatingPublication;
            }

            set { FurtherInformationOnLiabilityRelatingPublication = value; }
        }
        public String GetSetAdditionalInformationAboutPublication
        {
            get
            {
                if (AdditionalInformationAboutPublication.Length <= 0)
                    return "";
                return AdditionalInformationAboutPublication;
            }

            set { AdditionalInformationAboutPublication = value; }
        }
        public String GetSetFirstInformationOnLiabilityRelatingToAdditionalInformationPpublication
        {
            get
            {
                if (FirstInformationOnLiabilityRelatingToAdditionalInformationPublication.Length <= 0)
                    return "";
                return FirstInformationOnLiabilityRelatingToAdditionalInformationPublication;
            }

            set { FirstInformationOnLiabilityRelatingToAdditionalInformationPublication = value; }
        }
        public String GetSetFurtherInformationOnLiabilityRelatingToAdditionalInformationPublication
        {
            get
            {
                if (FurtherInformationOnLiabilityRelatingToAdditionalInformationPublication.Length <= 0)
                    return "";
                return FurtherInformationOnLiabilityRelatingToAdditionalInformationPublication;
            }

            set { FurtherInformationOnLiabilityRelatingToAdditionalInformationPublication = value; }
        }





    }

    class OutputData
    {

        public String PlacePublication;
        public String FirstPlacePublication;
        public String SubsequentPlacePublication;
        public String NamePublisherDistributor;
        public String InformationAboutFunctionsPublisher;
        public String DatePublication;
        public String PlaceManufacture;
        public String ManufacturerName;
        public String DateManufacture;

        public OutputData() { }
        public OutputData(String PlacePublication, String FirstPlacePublication, String SubsequentPlacePublication, String NamePublisherDistributor, String InformationAboutFunctionsPublisher,
            String DatePublication, String PlaceManufacture, String ManufacturerName, String DateManufacture)
        {
            this.PlacePublication = PlacePublication;
            this.FirstPlacePublication = FirstPlacePublication;
            this.SubsequentPlacePublication = SubsequentPlacePublication;
            this.NamePublisherDistributor = NamePublisherDistributor;
            this.InformationAboutFunctionsPublisher = InformationAboutFunctionsPublisher;
            this.DatePublication = DatePublication;
            this.PlaceManufacture = PlaceManufacture;
            this.ManufacturerName = ManufacturerName;
            this.DateManufacture = DateManufacture;
        }




    }


    class PhysicalCharacteristics
    {
        public String SpecificDesignationMaterialAndVolume;
        public String OtherInformationAboutPhysicalCharacteristics;
        public String Dimensions;
        public String InformationAccompanyingMaterial;

        public PhysicalCharacteristics() { }

        public PhysicalCharacteristics(String SpecificDesignationMaterialAndVolume, String OtherInformationAboutPhysicalCharacteristics,
            String Dimensions, String InformationAccompanyingMaterial)
        {

            this.SpecificDesignationMaterialAndVolume = SpecificDesignationMaterialAndVolume;
            this.OtherInformationAboutPhysicalCharacteristics = OtherInformationAboutPhysicalCharacteristics;
            this.Dimensions = Dimensions;
            this.InformationAccompanyingMaterial = InformationAccompanyingMaterial;
        }

    }

    class Series
    {
        public String TitleSeries;
        public String ParallelTitleSeries;
        public String InformationPertainingTitleSeries;
        public String FirstInformationAboutLiabilityRelatedSeries;
        public String SubsequentLiabilityInformationRelatingSeries;
        public String ISSN;
        public String IssueNumberSeries;

        public Series() { }
       
        public Series(String TitleSeries, String ParallelTitleSeries,String InformationPertainingTitleSeries, String FirstInformationAboutLiabilityRelatedSeries,
            String SubsequentLiabilityInformationRelatingSeries, String ISSN, String IssueNumberSeries)
        {
            this.TitleSeries = TitleSeries;
            this.ParallelTitleSeries = ParallelTitleSeries;
            this.InformationPertainingTitleSeries = InformationPertainingTitleSeries;
            this.FirstInformationAboutLiabilityRelatedSeries = FirstInformationAboutLiabilityRelatedSeries;
            this.SubsequentLiabilityInformationRelatingSeries = SubsequentLiabilityInformationRelatingSeries;
            this.ISSN = ISSN;
            this.IssueNumberSeries = IssueNumberSeries;
        }



    }

    class StandardNumber
    {
        public String ISBN;
        public String BBK;
        public String Price;

        public StandardNumber() { }

        public StandardNumber(String ISBN, String BBK, String Price)
        {
            this.ISBN = ISBN;
            this.BBK = BBK;
            this.Price = Price;
               
        }

    }




}
