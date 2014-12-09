using System;
using System.Xml;
using System.Xml.Serialization;

namespace Trafikverket.NET
{
    /// <summary>
    /// Represents last modified element in a response
    /// </summary>
    public class LastModifiedModel
    {
        /// <summary>
        /// Get or set last modification date of the data in the response.
        /// </summary>
        [XmlIgnore]
        public DateTimeOffset? LastModified { get; set; }

        /// <summary>
        /// DO NOT USE! String representation of LastModified, used for serialization.
        /// </summary>
        [XmlAttribute("datetime")]
        public string _LastModified_String
        {
            get { return LastModified.HasValue ? LastModified.Value.ToString() : null; }
            set { LastModified = !String.IsNullOrEmpty(value) ? XmlConvert.ToDateTimeOffset(value) : (DateTimeOffset?)null; }
        }
    }
}
