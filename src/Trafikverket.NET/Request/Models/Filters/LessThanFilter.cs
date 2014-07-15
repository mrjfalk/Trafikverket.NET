using System.Xml.Serialization;

namespace Trafikverket.Net
{
    /// <summary>
    /// Less than filter
    /// </summary>
    sealed public class LessThanFilter : BaseFilter
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        private LessThanFilter()
            : base()
        {

        }

        /// <summary>
        /// Constructor. Name and value are both required.
        /// </summary>
        /// <param name="name">Name of attribute</param>
        /// <param name="value">Value to compare with</param>
        public LessThanFilter(string name, string value)
            : base(name, value)
        {

        }
    }
}
