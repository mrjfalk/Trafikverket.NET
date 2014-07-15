using System.Xml.Serialization;

namespace Trafikverket.Net
{
    /// <summary>
    /// Greater than filter
    /// </summary>
    sealed public class GreaterThanFilter : BaseFilter
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        private GreaterThanFilter() : base()
        {

        }

        /// <summary>
        /// Constructor. Name and value are both required.
        /// </summary>
        /// <param name="name">Name of attribute</param>
        /// <param name="value">Value to compare with</param>
        public GreaterThanFilter(string name, string value)
            : base(name, value)
        {

        }
    }
}
