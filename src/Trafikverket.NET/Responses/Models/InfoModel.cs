using System.Xml.Serialization;

namespace Trafikverket.NET
{
    /// <summary>
    /// Represents info element in response.
    /// </summary>
    public class InfoModel
    {
        /// <summary>
        /// Get or set last modified data for the response
        /// </summary>
        [XmlElement("LASTMODIFIED")]
        public LastModifiedModel LastModified { get; set; }
    }
}
