using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace Trafikverket.Net
{
    /// <summary>
    /// Representation of a train station element
    /// </summary>
    public class TrainStation
    {
        /// <summary>
        /// Get or set if station is advertised in time table
        /// </summary>
        [XmlIgnore]
        public bool? Advertised { get; set; }

        /// <summary>
        /// Get or set string representation for serialization of Advertised
        /// </summary>
        [XmlElement("Advertised")]
        public string _Advertised_String
        {
            get { return Advertised.HasValue ? Advertised.Value.ToString() : null; }
            set { Advertised = !String.IsNullOrEmpty(value) ? XmlConvert.ToBoolean(value) : (bool?)null; }
        }

        /// <summary>
        /// Get or set if the advertised name
        /// </summary>
        [XmlElement("AdvertisedLocationName")]
        public string AdvertisedLocationName { get; set; }

        /// <summary>
        /// Get or set short advertised name
        /// </summary>
        [XmlElement("AdvertisedShortLocationName")]
        public string AdvertisedShortLocationName { get; set; }

        /// <summary>
        /// Get or set the code of the country where the station is located
        /// </summary>
        [XmlElement("CountryCode")]
        public string CountryCode { get; set; }

        /// <summary>
        /// Get or set list of county numbers for the station
        /// </summary>
        [XmlElement("CountyNo")]
        public List<int> CountyNumbers { get; set; }

        /// <summary>
        /// Get or set if the data post has been deleted
        /// </summary>
        [XmlIgnore]
        public bool? Deleted { get; set; }
        
        /// <summary>
        /// Get or set string representation of Deleted
        /// </summary>
        [XmlElement("Deleted")]
        public string _Deleted_String
        {
            get { return Deleted.HasValue ? Deleted.Value.ToString() : null; }
            set { Deleted = !String.IsNullOrEmpty(value) ? XmlConvert.ToBoolean(value) : (bool?)null; }
        }

        /// <summary>
        /// Get or set geolocation of the station
        /// </summary>
        [XmlElement("Geometry")]
        public Geometry Location { get; set; }

        /// <summary>
        /// Get or set information text for the station
        /// </summary>
        [XmlElement("LocationInformationText")]
        public string LocationInformationText { get; set; }

        /// <summary>
        /// Get or set unique location signature for the station, e.g. Cst
        /// </summary>
        [XmlElement("LocationSignature")]
        public string LocationSignature { get; set; }

        /// <summary>
        /// Get or set last time the data post was modified
        /// </summary>
        [XmlIgnore]
        public DateTimeOffset? ModifiedTime { get; set; }

        /// <summary>
        /// Get or set string representation for serialization of ModifiedTime
        /// </summary>
        [XmlElement("ModifiedTime")]
        public string _ModifiedTime_String
        {
            get { return ModifiedTime.HasValue ? ModifiedTime.Value.ToString() : null; }
            set { ModifiedTime = !String.IsNullOrEmpty(value) ? XmlConvert.ToDateTimeOffset(value) : (DateTimeOffset?)null; }
        }

        /// <summary>
        /// Get or set the platforms for the station
        /// </summary>
        [XmlElement("PlatformLine")]
        public List<string> PlatformLines { get; set; }

        /// <summary>
        /// Get or set if the station is prognosticated in the time table
        /// </summary>
        [XmlIgnore]
        public bool? Prognosticated { get; set; }

        /// <summary>
        /// Get or set string representation of Prognosticated
        /// </summary>
        [XmlElement("Prognosticated")]
        public string _Prognosticated_String
        {
            get { return Prognosticated.HasValue ? Prognosticated.Value.ToString() : null; }
            set { Prognosticated = !String.IsNullOrEmpty(value) ? XmlConvert.ToBoolean(value) : (bool?)null; }
        }
    }
}
