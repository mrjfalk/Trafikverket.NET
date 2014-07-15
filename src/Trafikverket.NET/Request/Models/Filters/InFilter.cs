using System.Xml.Serialization;

namespace Trafikverket.Net
{
    /// <summary>
    /// In filter
    /// </summary>
    sealed public class InFilter : BaseFilter
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        private InFilter()
            : base()
        {

        }

        /// <summary>
        /// Constructor. Name and value are both required.
        /// </summary>
        /// <param name="name">Name of attribute</param>
        /// <param name="value">Value to compare with</param>
        public InFilter(string name, string value)
            : base(name, value)
        {

        }
    }
}
