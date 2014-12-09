using System.Xml.Serialization;

namespace Trafikverket.NET
{
	/// <summary>
	/// Model for login data
	/// </summary>
    public class LoginModel
    {
        [XmlAttribute("authenticationkey")]
        public string AuthenticationKey { get; set; }

        private LoginModel()
        {
            AuthenticationKey = "";
        }

        /// <summary>
        /// Constructor. Requires an authentication key
        /// </summary>
        /// <param name="authenticationKey">Authentication key</param>
        public LoginModel(string authenticationKey)
        {
            AuthenticationKey = authenticationKey;
        }
    }
}
