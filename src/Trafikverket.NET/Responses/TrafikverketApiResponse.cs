using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Trafikverket.NET
{
    /// <summary>
    /// Representation of an response from the API
    /// </summary>
    [XmlRootAttribute("RESPONSE")]
    public class TrafikverketApiResponse
    {
        /// <summary>
        /// Get or set the results of the request
        /// </summary>
        [XmlElement("RESULT")]
        public List<ResultModel> Results { get; set; }

        /// <summary>
        /// If the request was successful or not
        /// </summary>
        [XmlIgnore]
        public bool Success { get; set; }

        /// <summary>
        /// Get or set error message
        /// </summary>
        [XmlIgnore]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public TrafikverketApiResponse()
        {
            Results = new List<ResultModel>();
        }
    }
}
