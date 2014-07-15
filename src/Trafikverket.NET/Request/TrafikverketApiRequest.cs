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
        /// Constructor. Authentication key and one query is mandatory
        /// </summary>
        /// <param name="authenticationKey">Authentication key</param>
        /// <param name="query">Query to include in the request</param>
        public TrafikverketApiRequest(string authenticationKey, QueryModel query)
        {
            Login = new LoginModel(authenticationKey);
            Queries = new List<QueryModel>();
            Queries.Add(query);
        }

        /// <summary>
        /// Constructor. Authentication key and atleast one query is mandatory
        /// </summary>
        /// <param name="authenticationKey">Authentication key</param>
        /// <param name="queries">Queries to include in the request</param>
        public TrafikverketApiRequest(string authenticationKey, IEnumerable<QueryModel> queries)
        {
            Login = new LoginModel(authenticationKey);
            Queries = new List<QueryModel>();

            if (queries != null && queries.Count() >= 1)
            {
                foreach (QueryModel query in queries)
                    Queries.Add(query);
            }
            else
            {
                throw new ArgumentException("At least one query must be included", "queries");
            }
        }
    }
}
