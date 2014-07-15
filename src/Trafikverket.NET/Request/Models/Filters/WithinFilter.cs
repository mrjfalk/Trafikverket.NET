using System.Xml.Serialization;

namespace Trafikverket.Net
{
    /// <summary>
    /// Within filter
    /// </summary>
    sealed public class WithinFilter : BaseFilter
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        private WithinFilter()
            : base()
        {

        }

        /// <summary>
        /// Constructor. Name and value are both required.
        /// </summary>
        /// <param name="name">Name of attribute</param>
        /// <param name="value">Value to compare with</param>
        public WithinFilter(string name, string value)
            : base(name, value)
        {

        }
    }
}
