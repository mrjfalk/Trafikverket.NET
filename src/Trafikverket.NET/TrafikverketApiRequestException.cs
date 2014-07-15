using System;

namespace Trafikverket.Net
{
    /// <summary>
    /// Represents errors related to an request to the api.
    /// </summary>
    public class TrafikverketApiRequestException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the Trafikverket.Net.TrafikverketApiRequestException class.
        /// </summary>
        public TrafikverketApiRequestException()
        {

        }
        
        /// <summary>
        /// Initializes a new instance of the Trafikverket.Net.TrafikverketApiRequestException class with a specified error message.
        /// </summary>
        /// <param name="message">Error message</param>
        public TrafikverketApiRequestException(string message)
            : base(message)
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the Trafikverket.Net.TrafikverketApiRequestException class with a specified error message and a reference to an inner exception.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="innerException">Inner exception</param>
        public TrafikverketApiRequestException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
