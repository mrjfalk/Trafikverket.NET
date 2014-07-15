using System.Xml.Serialization;

namespace Trafikverket.Net
{
    /// <summary>
    /// Not equals filter
    /// </summary>
    sealed public class NotEqualsFilter : BaseFilter
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        private NotEqualsFilter()
            : base()
        {

        }

        /// <summary>
        /// Constructor. Name and value are both required.
        /// </summary>
        /// <param name="name">Name of attribute</param>
        /// <param name="value">Value to compare with</param>
        public NotEqualsFilter(string name, string value)
            : base(name, value)
        {

        }
    }
}
