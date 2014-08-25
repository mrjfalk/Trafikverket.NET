using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace Trafikverket.Net
{
    /// <summary>
    /// Representation of a request to the API
    /// </summary>
    [XmlRootAttribute("REQUEST")]
    public class TrafikverketApiRequest
    {
        /// <summary>
        /// Get or set authentication for the request
        /// </summary>
        [XmlElement("LOGIN")]
        public LoginModel Login { get; set; }

        /// <summary>
        /// Get or set queries in the request
        /// </summary>
        [XmlElement("QUERY")]
        public List<QueryModel> Queries { get; set; }

        private TrafikverketApiRequest()
        {
            Login = new LoginModel("");
            Queries = new List<QueryModel>();
        }

        /// <summary>
        /// Constructor. At least one query is mandatory
        /// </summary>
        /// <param name="authenticationKey">Authentication key</param>
        /// <param name="query">Queries to include in the request, must be atleast one</param>
        public TrafikverketApiRequest(string authenticationKey, params QueryModel[] queries)
        {
            Login = new LoginModel(authenticationKey);
            Queries = new List<QueryModel>();

            if(queries.Count() > 0)
                Queries.AddRange(queries);
            else
                throw new ArgumentException("At least one query must be included", "queries");
        }
    }
}
