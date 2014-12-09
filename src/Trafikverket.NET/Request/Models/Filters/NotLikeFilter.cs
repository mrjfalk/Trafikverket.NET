using System.Xml.Serialization;

namespace Trafikverket.NET
{
    /// <summary>
    /// Not like filter
    /// </summary>
    sealed public class NotLikeFilter : BaseFilter
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        internal NotLikeFilter()
            : base()
        {

        }

        /// <summary>
        /// Constructor. Name and value are both required.
        /// </summary>
        /// <param name="name">Name of attribute</param>
        /// <param name="value">Value to compare with</param>
        public NotLikeFilter(string name, string value)
            : base(name, value)
        {

        }
    }
}
