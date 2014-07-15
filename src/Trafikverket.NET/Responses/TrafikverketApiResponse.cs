using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Trafikverket.Net
{
    /// <summary>
    /// Representation of an response from the API
    /// </summary>
    [XmlRootAttribute("RESPONSE")]
    public class TrafikverketApiResponse
    {
        /// <summary>
        /// Get or set the result of the request
        /// </summary>
        [XmlElement("RESULT")]
        public ResultModel Result { get; set; }

        /// <summary>
        /// If the request was successful or not
        /// </summary>
        [XmlIgnore]
        public bool Success { get; set; }
    }
}
