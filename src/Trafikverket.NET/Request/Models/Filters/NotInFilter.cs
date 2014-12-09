using System.Xml.Serialization;

namespace Trafikverket.NET
{
    /// <summary>
    /// Not in filter
    /// </summary>
    sealed public class NotInFilter : BaseFilter
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        internal NotInFilter()
            : base()
        {

        }

        /// <summary>
        /// Constructor. Name and value are both required.
        /// </summary>
        /// <param name="name">Name of attribute</param>
        /// <param name="value">Value to compare with</param>
        public NotInFilter(string name, string value)
            : base(name, value)
        {

        }
    }
}
