using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Trafikverket.Net
{
    /// <summary>
    /// Class for interacting with the API
    /// </summary>
    public sealed class TrafikverketApi
    {
        /// <summary>
        /// Authentication key for the API
        /// </summary>
        private string authenticationKey;

        /// <summary>
        /// Base url for the API
        /// </summary>
        private const string apiBaseUrl = "http://api.trafikinfo.trafikverket.se/v1/data";

        /// <summary>
        /// Create a new instance of the API
        /// </summary>
        /// <param name="authenticationKey">Authentication key to use for requests</param>
        public TrafikverketApi(string authenticationKey)
        {
            this.authenticationKey = authenticationKey;
        }

        /// <summary>
        /// Send an API request with a single query.
        /// </summary>
        /// <param name="query">Query to include in request</param>
        /// <returns>Response from the API</returns>
        public async Task<TrafikverketApiResponse> SendApiRequestAsync(QueryModel query)
        {
            return await SendApiRequestAsync(new List<QueryModel>() { query });
        }

        /// <summary>
        /// Send an API request with a set of queries. Atleast one query must be included.
        /// </summary>
        /// <param name="queries">Queries to include in request. At least one.</param>
        /// <returns>Response from the API</returns>
        public async Task<TrafikverketApiResponse> SendApiRequestAsync(IEnumerable<QueryModel> queries)
        {
            // Create and serialize the request
            TrafikverketApiRequest request = new TrafikverketApiRequest(authenticationKey, queries);
            byte[] requestBytes = Encoding.UTF8.GetBytes(SerializeRequest(request));

            HttpWebRequest webRequest = null;
            string responseString = "";

            try
            {
                // Setup request
                webRequest = (HttpWebRequest)WebRequest.CreateHttp(CreateApiUri(false));
                webRequest.ContentType = "text/xml";
                webRequest.Method = "POST";
                webRequest.Headers["ContentLength"] = requestBytes.Length.ToString();
                webRequest.Headers["ContentEncoding"] = "UTF-8";
                webRequest.Headers["AcceptEncoding"] = "UTF-8";
                
                // Post data
                using (Stream requestStream = await Task.Factory.FromAsync(webRequest.BeginGetRequestStream, asyncResult => webRequest.EndGetRequestStream(asyncResult), null))
                {
                    await requestStream.WriteAsync(requestBytes, 0, requestBytes.Length);
                }

                // Get response
                HttpStatusCode statusCode;
                using (HttpWebResponse webResponse = (HttpWebResponse)await Task.Factory.FromAsync(webRequest.BeginGetResponse, asyncResult => webRequest.EndGetResponse(asyncResult), null))
                {
                    statusCode = webResponse.StatusCode;
                    using (StreamReader streamReader = new StreamReader(webResponse.GetResponseStream()))
                    {
                        responseString = await streamReader.ReadToEndAsync();
                    }
                }

                // Deserialize the data and set if the request was successful or not
                TrafikverketApiResponse responseObj = DeserializeXmlResponse(responseString);
                responseObj.Success = statusCode == HttpStatusCode.OK;
                return responseObj;
            }
            catch(WebException ex)
            {
                // Create a response with a custom error
                TrafikverketApiResponse response = new TrafikverketApiResponse() { Success = false };
                response.Result = new ResultModel();
                response.Result.Error = new ErrorModel()
                {
                    Source = "api-wrapper",
                    Message = "Failed to download the data"
                };

                return response;
            }
            catch (Exception ex)
            {
                throw new TrafikverketApiRequestException("Failed to send the request to the API", ex);
            }
        }

        /// <summary>
        /// Create URI for the request
        /// </summary>
        /// <param name="useJson">If JSON should be used for the response. If false XML will be used.</param>
        /// <returns>The URI</returns>
        private Uri CreateApiUri(bool useJson = false)
        {
            if (useJson)
                throw new NotImplementedException("Support for JSON not implemented yet.");

            return new Uri(string.Format("{0}.{1}", apiBaseUrl, useJson ? "json" : "xml"), UriKind.Absolute);
        }

        /// <summary>
        /// Serialize the request object
        /// </summary>
        /// <param name="request">The request</param>
        /// <returns>XML of the request as a string</returns>
        private string SerializeRequest(TrafikverketApiRequest request)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(TrafikverketApiRequest));

            // Clear namespaces
            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add("", "");

            // Set serialization settings
            XmlWriterSettings xmlSettings = new XmlWriterSettings()
            {
                Encoding = Encoding.UTF8,
                OmitXmlDeclaration = true,
                Indent = false
            };

            // Serialize the request object and return the string
            using(StringWriter stringWriter = new StringWriter())
            {
                using(XmlWriter xmlWriter = XmlWriter.Create(stringWriter, xmlSettings))
                {
                    xmlSerializer.Serialize(xmlWriter, request, namespaces);
                }

                string serializedData = stringWriter.ToString();
                return serializedData;
            }
        }

        /// <summary>
        /// Deserialize the response
        /// </summary>
        /// <param name="xml">XML for the response as a string</param>
        /// <returns>The deserialized response object</returns>
        private TrafikverketApiResponse DeserializeXmlResponse(string xml)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(TrafikverketApiResponse));

            using (StringReader stringReader = new StringReader(xml))
            {
                using (XmlReader xmlReader = XmlReader.Create(stringReader))
                {
                    return (TrafikverketApiResponse)xmlSerializer.Deserialize(xmlReader);
                }
            }
        }
    }
}
