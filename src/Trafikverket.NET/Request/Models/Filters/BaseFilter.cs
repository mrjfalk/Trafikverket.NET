using System.Xml.Serialization;

namespace Trafikverket.NET
{
    /// <summary>
    /// Abstract base filter class
    /// </summary>
    public abstract class BaseFilter : FiltersBase
    {
        /// <summary>
        /// Get or set name of attribute
        /// </summary>
        [XmlAttribute("name")]
        public string Name { get; set; }

        /// <summary>
        /// Get or set value to compare with
        /// </summary>
        [XmlAttribute("value")]
        public string Value { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        internal BaseFilter()
        {
            Name = "";
            Value = "";
        }

        /// <summary>
        /// Constructor. Name and value are both required.
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="value">Value</param>
        public BaseFilter(string name, string value)
        {
            Name = name;
            Value = value;
        }
    }
}
