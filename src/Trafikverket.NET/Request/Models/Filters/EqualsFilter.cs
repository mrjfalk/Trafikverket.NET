using System.Xml.Serialization;

namespace Trafikverket.Net
{
    /// <summary>
    /// Equals filter
    /// </summary>
    sealed public class EqualsFilter : BaseFilter
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        private EqualsFilter() : base()
        {

        }

        /// <summary>
        /// Constructor. Name and value are both required.
        /// </summary>
        /// <param name="name">Name of attribute</param>
        /// <param name="value">Value to compare with</param>
        public EqualsFilter(string name, string value)
            : base(name, value)
        {

        }
    }
}
