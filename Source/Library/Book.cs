using System;

namespace Library
{
    internal struct Price
    {
        public int RUB { get; set; }
        public int COP { get; set; }
    }

    internal class Book
    {
        public Header header;
        public OutputData outputdata;
        public PhysicalCharacteristics physicalCharac;
        public Publication publication;
        public Series series;
        public StandardNumber standardNumber;
        public Title title;
    }

    internal class Header
    {
        public string Author;
        public string AuthorSign;

        public Header()
        {
            Author = "";
            AuthorSign = "";
        }

        public Header(string author, string authorSign)
        {
            Author = author;
            AuthorSign = authorSign;
        }

        public string GetSetAuthor
        {
            get
            {
                if (Author.Length <= 0) return "";
                return Author;
            }

            set => Author = value;
        }

        public string GetSetAuthorSign
        {
            get
            {
                if (AuthorSign.Length <= 0) return "";
                return AuthorSign;
            }

            set => AuthorSign = value;
        }

        internal Book Book
        {
            get { throw new NotImplementedException(); }

            set { }
        }
    }

    internal class Title
    {
        public string FirstInformationOnLiability;
        public string FurtherInformationOnLiability;
        public string GeneralMaterialDesignation;
        public string InformationPertainingToTheTitle;
        public string MainTitle;
        public string ParallelTitle;

        public Title()
        {
            MainTitle = "";
            GeneralMaterialDesignation = "";
            ParallelTitle = "";
            InformationPertainingToTheTitle = "";
            FirstInformationOnLiability = "";
            FurtherInformationOnLiability = "";
        }

        public Title(string MainTitle, string GeneralMaterialDesignation, string ParallelTitle,
            string InformationPertainingToTheTitle, string FirstInformationOnLiability,
            string FurtherInformationOnLiability)
        {
            this.MainTitle = MainTitle;
            this.GeneralMaterialDesignation = GeneralMaterialDesignation;
            this.ParallelTitle = ParallelTitle;
            this.InformationPertainingToTheTitle = InformationPertainingToTheTitle;
            this.FirstInformationOnLiability = FirstInformationOnLiability;
            this.FurtherInformationOnLiability = FurtherInformationOnLiability;
        }

        public string GetSetMainTitle
        {
            get
            {
                if (MainTitle.Length <= 0) return "";
                return MainTitle;
            }

            set => MainTitle = value;
        }

        public string GetSetGeneralMaterialDesignation
        {
            get
            {
                if (GeneralMaterialDesignation.Length <= 0)
                    return "";
                return GeneralMaterialDesignation;
            }

            set => GeneralMaterialDesignation = value;
        }

        public string GetSetParallelTitle
        {
            get
            {
                if (ParallelTitle.Length <= 0) return "";
                return ParallelTitle;
            }

            set => ParallelTitle = value;
        }

        public string GetSetInformationPertainingToTheTitle
        {
            get
            {
                if (InformationPertainingToTheTitle.Length <= 0)
                    return "";
                return InformationPertainingToTheTitle;
            }

            set => InformationPertainingToTheTitle = value;
        }

        public string GetSetFirstInformationOnLiability
        {
            get
            {
                if (FirstInformationOnLiability.Length <= 0)
                    return "";
                return FirstInformationOnLiability;
            }

            set => FirstInformationOnLiability = value;
        }

        public string GetSetFurtherInformationOnLiability
        {
            get
            {
                if (FurtherInformationOnLiability.Length <= 0)
                    return "";
                return FurtherInformationOnLiability;
            }

            set => FurtherInformationOnLiability = value;
        }

        internal Book Book
        {
            get { throw new NotImplementedException(); }

            set { }
        }
    }

    internal class Publication
    {
        public string AdditionalInformationAboutPublication;
        public string FirstInformationOnLiabilityRelatingPublication;
        public string FirstInformationOnLiabilityRelatingToAdditionalInformationPublication;
        public string FurtherInformationOnLiabilityRelatingPublication;
        public string FurtherInformationOnLiabilityRelatingToAdditionalInformationPublication;
        public string InformationOnThePublication;
        public string ParallelInformationAboutThePublication;

        public Publication()
        {
        }

        public Publication(string InformationOnThePublication, string ParallelInformationAboutThePublication,
            string FirstInformationOnLiabilityRelatingPublication,
            string FurtherInformationOnLiabilityRelatingPublication, string AdditionalInformationAboutPublication,
            string FirstInformationOnLiabilityRelatingToAdditionalInformationPublication,
            string FurtherInformationOnLiabilityRelatingToAdditionalInformationPublication)
        {
            this.InformationOnThePublication = InformationOnThePublication;
            this.ParallelInformationAboutThePublication = ParallelInformationAboutThePublication;
            this.FirstInformationOnLiabilityRelatingPublication = FirstInformationOnLiabilityRelatingPublication;
            this.FurtherInformationOnLiabilityRelatingPublication = FurtherInformationOnLiabilityRelatingPublication;
            this.AdditionalInformationAboutPublication = AdditionalInformationAboutPublication;
            this.FirstInformationOnLiabilityRelatingToAdditionalInformationPublication =
                FirstInformationOnLiabilityRelatingToAdditionalInformationPublication;
            this.FurtherInformationOnLiabilityRelatingToAdditionalInformationPublication =
                FurtherInformationOnLiabilityRelatingToAdditionalInformationPublication;
        }

        public string GetSetInformationOnThePublication
        {
            get
            {
                if (InformationOnThePublication.Length <= 0)
                    return "";
                return InformationOnThePublication;
            }

            set => InformationOnThePublication = value;
        }

        public string GetSetParallelInformationAboutThePublication
        {
            get
            {
                if (ParallelInformationAboutThePublication.Length <= 0)
                    return "";
                return ParallelInformationAboutThePublication;
            }

            set => ParallelInformationAboutThePublication = value;
        }

        public string GetSetFirstInformationOnLiabilityRelatingPublication
        {
            get
            {
                if (FirstInformationOnLiabilityRelatingPublication.Length <= 0)
                    return "";
                return FirstInformationOnLiabilityRelatingPublication;
            }

            set => FirstInformationOnLiabilityRelatingPublication = value;
        }

        public string GetSetFurtherInformationOnLiabilityRelatingPublication
        {
            get
            {
                if (FurtherInformationOnLiabilityRelatingPublication.Length <= 0)
                    return "";
                return FurtherInformationOnLiabilityRelatingPublication;
            }

            set => FurtherInformationOnLiabilityRelatingPublication = value;
        }

        public string GetSetAdditionalInformationAboutPublication
        {
            get
            {
                if (AdditionalInformationAboutPublication.Length <= 0)
                    return "";
                return AdditionalInformationAboutPublication;
            }

            set => AdditionalInformationAboutPublication = value;
        }

        public string GetSetFirstInformationOnLiabilityRelatingToAdditionalInformationPpublication
        {
            get
            {
                if (FirstInformationOnLiabilityRelatingToAdditionalInformationPublication.Length <= 0)
                    return "";
                return FirstInformationOnLiabilityRelatingToAdditionalInformationPublication;
            }

            set => FirstInformationOnLiabilityRelatingToAdditionalInformationPublication = value;
        }

        public string GetSetFurtherInformationOnLiabilityRelatingToAdditionalInformationPublication
        {
            get
            {
                if (FurtherInformationOnLiabilityRelatingToAdditionalInformationPublication.Length <= 0)
                    return "";
                return FurtherInformationOnLiabilityRelatingToAdditionalInformationPublication;
            }

            set => FurtherInformationOnLiabilityRelatingToAdditionalInformationPublication = value;
        }

        internal Book Book
        {
            get { throw new NotImplementedException(); }

            set { }
        }
    }

    internal class OutputData
    {
        public string DateManufacture;
        public string DatePublication;
        public string FirstPlacePublication;
        public string InformationAboutFunctionsPublisher;
        public string ManufacturerName;
        public string NamePublisherDistributor;
        public string PlaceManufacture;
        public string PlacePublication;
        public string SubsequentPlacePublication;

        public OutputData()
        {
        }

        public OutputData(string PlacePublication, string FirstPlacePublication, string SubsequentPlacePublication,
            string NamePublisherDistributor, string InformationAboutFunctionsPublisher,
            string DatePublication, string PlaceManufacture, string ManufacturerName, string DateManufacture)
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

        internal Book Book
        {
            get { throw new NotImplementedException(); }

            set { }
        }
    }

    internal class PhysicalCharacteristics
    {
        public string Dimensions;
        public string InformationAccompanyingMaterial;
        public string OtherInformationAboutPhysicalCharacteristics;
        public string SpecificDesignationMaterialAndVolume;

        public PhysicalCharacteristics()
        {
        }

        public PhysicalCharacteristics(string SpecificDesignationMaterialAndVolume,
            string OtherInformationAboutPhysicalCharacteristics,
            string Dimensions, string InformationAccompanyingMaterial)
        {
            this.SpecificDesignationMaterialAndVolume = SpecificDesignationMaterialAndVolume;
            this.OtherInformationAboutPhysicalCharacteristics = OtherInformationAboutPhysicalCharacteristics;
            this.Dimensions = Dimensions;
            this.InformationAccompanyingMaterial = InformationAccompanyingMaterial;
        }

        internal Book Book
        {
            get { throw new NotImplementedException(); }

            set { }
        }
    }

    internal class Series
    {
        public string FirstInformationAboutLiabilityRelatedSeries;
        public string InformationPertainingTitleSeries;
        public string ISSN;
        public string IssueNumberSeries;
        public string ParallelTitleSeries;
        public string SubsequentLiabilityInformationRelatingSeries;
        public string TitleSeries;

        public Series()
        {
        }

        public Series(string TitleSeries, string ParallelTitleSeries, string InformationPertainingTitleSeries,
            string FirstInformationAboutLiabilityRelatedSeries,
            string SubsequentLiabilityInformationRelatingSeries, string ISSN, string IssueNumberSeries)
        {
            this.TitleSeries = TitleSeries;
            this.ParallelTitleSeries = ParallelTitleSeries;
            this.InformationPertainingTitleSeries = InformationPertainingTitleSeries;
            this.FirstInformationAboutLiabilityRelatedSeries = FirstInformationAboutLiabilityRelatedSeries;
            this.SubsequentLiabilityInformationRelatingSeries = SubsequentLiabilityInformationRelatingSeries;
            this.ISSN = ISSN;
            this.IssueNumberSeries = IssueNumberSeries;
        }

        internal Book Book
        {
            get { throw new NotImplementedException(); }

            set { }
        }
    }

    internal class StandardNumber
    {
        public string BBK;
        public string ISBN;
        public Price Pric;
        public decimal Price;

        public StandardNumber()
        {
        }

        public StandardNumber(string ISBN, string BBK, Price Pric)
        {
            this.ISBN = ISBN;
            this.BBK = BBK;
            this.Pric = Pric;
            Price = (decimal) (Convert.ToDouble(Pric.RUB) + Convert.ToDouble(Pric.COP) / 100);
        }

        internal Book Book
        {
            get { throw new NotImplementedException(); }

            set { }
        }
    }
}