using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Trafikverket.Net
{
    public class TrainAnnouncement
    {
        [XmlElement("ActivityId")]
        public string ActivityId { get; set; }

        [XmlElement("ActivityType")]
        public string ActivityType { get; set; }

        [XmlElement("Advertised")]
        public bool Advertised { get; set; }

        [XmlElement("AdvertisedTimeAtLocation")]
        public DateTime AdvertisedTimeAtLocation { get; set; }

        [XmlElement("AdvertisedTrainIdent")]
        public string AdvertisedTrainIdent { get; set; }

        [XmlElement("Booking")]
        public List<string> Booking { get; set; }

        [XmlElement("Canceled")]
        public bool Canceled { get; set; }

        [XmlElement("Deleted")]
        public bool Deleted { get; set; }

        [XmlElement("Deviation")]
        public List<string> Deviation { get; set; }

        [XmlElement("EstimatedTimeAtLocation")]
        public DateTime EstimatedTimeAtLocation { get; set; }

        [XmlElement("EstimatedTimeIsPreliminary")]
        public bool EstimatedTimeIsPreliminary { get; set; }

        [XmlElement("FromLocation")]
        public List<string> FromLocation { get; set; }

        [XmlElement("InformationOwner")]
        public string InformationOwner { get; set; }

        [XmlElement("LocationSignature")]
        public string LocationSignature { get; set; }

        [XmlElement("MobileWebLink")]
        public string MobileWebLink { get; set; }

        [XmlElement("ModifiedTime")]
        public DateTime Modified { get; set; }

        [XmlElement("OtherInformation")]
        public List<string> OtherInformation { get; set; }

        [XmlElement("ProductInformation")]
        public List<string> ProductInformation { get; set; }

        [XmlElement("ScheduledDepartureDateTime")]
        public DateTime ScheduledDeparture { get; set; }

        [XmlElement("Service")]
        public List<string> Service { get; set; }

        [XmlElement("TimeAtLocation")]
        public DateTimeOffset TimeAtLocation { get; set; }

        [XmlElement("ToLocation")]
        public List<string> ToLocation { get; set; }

        [XmlElement("TrackAtLocation")]
        public string TrackAtLocation { get; set; }

        [XmlElement("TrainComposition")]
        public List<string> TrainComposition { get; set; }

        [XmlElement("TypeOfTraffic")]
        public string TypeOfTraffic { get; set; }

        [XmlElement("WebLink")]
        public string WebLink { get; set; }
    }
}
