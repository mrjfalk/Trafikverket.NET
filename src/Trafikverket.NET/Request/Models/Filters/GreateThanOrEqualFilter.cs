using System.Xml.Serialization;

namespace Trafikverket.Net
{
    /// <summary>
    /// Greater than or equal filter
    /// </summary>
    sealed public class GreaterThanOrEqualFilter : BaseFilter
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        private GreaterThanOrEqualFilter()
            : base()
        {

        }

        /// <summary>
        /// Constructor. Name and value are both required.
        /// </summary>
        /// <param name="name">Name of attribute</param>
        /// <param name="value">Value to compare with</param>
        public GreaterThanOrEqualFilter(string name, string value)
            : base(name, value)
        {

        }
    }
}
