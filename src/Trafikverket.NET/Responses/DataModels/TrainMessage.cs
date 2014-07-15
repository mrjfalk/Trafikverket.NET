using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace Trafikverket.Net
{
    public class TrainMessage
    {
        /// <summary>
        /// Get or set affected locations
        /// </summary>
        [XmlElement("AffectedLocation")]
        public List<string> AffectedLocation { get; set; }
        
        /// <summary>
        /// Get or set county numbers
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
        /// Get or set the unique id for the event
        /// </summary>
        [XmlIgnore]
        public int? EventId { get; set; }

        /// <summary>
        /// Get or set string representation of EventId
        /// </summary>
        [XmlElement("EventId")]
        public string _EventId_String
        {
            get { return EventId.HasValue ? EventId.Value.ToString() : null; }
            set { EventId = !String.IsNullOrEmpty(value) ? XmlConvert.ToInt32(value) : (int?)null; }
        }

        /// <summary>
        /// Get or set information text
        /// </summary>
        [XmlElement("ExternalDescription")]
        public string ExternalDescription { get; set; }

        /// <summary>
        /// Get or set location of the event
        /// </summary>
        [XmlElement("Geometry")]
        public Geometry Location { get; set; }

        /// <summary>
        /// Get or set last time the message changed
        /// </summary>
        [XmlIgnore]
        public DateTimeOffset? LastUpdate { get; set; }

        /// <summary>
        /// Get or set string representation of last update
        /// </summary>
        [XmlElement("LastUpdateDateTime")]
        public string _LastUpdate_String
        {
            get { return LastUpdate.HasValue ? LastUpdate.Value.ToString() : null; }
            set { LastUpdate = !String.IsNullOrEmpty(value) ? XmlConvert.ToDateTimeOffset(value) : (DateTimeOffset?)null; }
        }

        /// <summary>
        /// Get or set last time the data post was modified
        /// </summary>
        [XmlIgnore]
        public DateTimeOffset? Modified { get; set; }

        /// <summary>
        /// Get or set string representation of Modified
        /// </summary>
        [XmlElement("ModifiedTime")]
        public string _Modified_String
        {
            get { return Modified.HasValue ? Modified.Value.ToString() : null; }
            set { Modified = !String.IsNullOrEmpty(value) ? XmlConvert.ToDateTimeOffset(value) : (DateTimeOffset?)null; }
        }

        /// <summary>
        /// Get or set the message reason
        /// </summary>
        [XmlElement("ReasonCodeText")]
        public string ReasonCodeText { get; set; }

        /// <summary>
        /// Get or set start time of the message
        /// </summary>
        [XmlIgnore]
        public DateTimeOffset? Start { get; set; }

        /// <summary>
        /// Get or set string representation of Start
        /// </summary>
        /// [XmlElement("StartDateTime")]
        public string _Start_String
        {
            get { return Start.HasValue ? Start.Value.ToString() : null; }
            set { Start = !String.IsNullOrEmpty(value) ? XmlConvert.ToDateTimeOffset(value) : (DateTimeOffset?)null; }
        }
    }
}
