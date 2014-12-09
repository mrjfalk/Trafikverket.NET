using System.Xml.Serialization;

namespace Trafikverket.NET
{
    /// <summary>
    /// Represents an error element in the response
    /// </summary>
    public class ErrorModel
    {
        /// <summary>
        /// Get or set source of the error
        /// </summary>
        [XmlAttribute("source")]
        public string Source { get; set; }

        /// <summary>
        /// Get or set the error message
        /// </summary>
        [XmlText]
        public string Message { get; set; }
    }
}
