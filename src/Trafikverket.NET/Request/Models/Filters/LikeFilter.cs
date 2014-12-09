using System.Xml.Serialization;

namespace Trafikverket.NET
{
    /// <summary>
    /// Like filter
    /// </summary>
    sealed public class LikeFilter : BaseFilter
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        internal LikeFilter()
            : base()
        {

        }

        /// <summary>
        /// Constructor. Name and value are both required.
        /// </summary>
        /// <param name="name">Name of attribute</param>
        /// <param name="value">Value to compare with</param>
        public LikeFilter(string name, string value)
            : base(name, value)
        {

        }
    }
}
