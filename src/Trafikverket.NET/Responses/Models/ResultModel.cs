using System.Collections.Generic;
using System.Xml.Serialization;

namespace Trafikverket.NET
{
    /// <summary>
    /// Represents a result element in the response from the api.
    /// </summary>
    public class ResultModel
    {
        /// <summary>
        /// Get or set train messages in the response, can be null if no train messages.
        /// </summary>
        [XmlElement("TrainMessage")]
        public List<TrainMessage> TrainMessages { get; set; }

        /// <summary>
        /// Get or set train stations in the response, can be null if no train stations.
        /// </summary>
        [XmlElement("TrainStation")]
        public List<TrainStation> TrainStations { get; set; }

        /// <summary>
        /// Get or set train announcements in the response, can be null if no train announcements.
        /// </summary>
        [XmlElement("TrainAnnouncement")]
        public List<TrainAnnouncement> TrainAnnouncements { get; set; }

        /// <summary>
        /// Get or set info element in the response, can be null if no info.
        /// </summary>
        [XmlElement("INFO")]
        public InfoModel Info { get; set; }

        /// <summary>
        /// Get or set error for the response, can be null if no error.
        /// </summary>
        [XmlElement("ERROR")]
        public ErrorModel Error { get; set; }
    }
}
