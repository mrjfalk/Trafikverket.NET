using System.Collections.Generic;
using System.Xml.Serialization;

namespace Trafikverket.NET
{
    /// <summary>
    /// Abstract base filter operator class
    /// </summary>
    public abstract class BaseOperator : FiltersBase
    {
        /// <summary>
        /// Get child filters
        /// </summary>
        [XmlElement("EQ", typeof(EqualsFilter))]
        [XmlElement("GT", typeof(GreaterThanFilter))]
        [XmlElement("GTE", typeof(GreaterThanOrEqualFilter))]
        [XmlElement("LT", typeof(LessThanFilter))]
        [XmlElement("LTE", typeof(LessThanOrEqualFilter))]
        [XmlElement("NE", typeof(NotEqualsFilter))]
        [XmlElement("LIKE", typeof(LikeFilter))]
        [XmlElement("NOTLIKE", typeof(NotLikeFilter))]
        [XmlElement("IN", typeof(InFilter))]
        [XmlElement("NOTIN", typeof(NotInFilter))]
        [XmlElement("WITHIN", typeof(WithinFilter))]
        [XmlElement("AND", typeof(AndFilterOperator))]
        [XmlElement("OR", typeof(OrFilterOperator))]
        public List<FiltersBase> ChildFilters { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        public BaseOperator()
        {
            ChildFilters = new List<FiltersBase>();
        }

        /// <summary>
        /// Constructor which takes a collection of child filters
        /// </summary>
        /// <param name="childFilters"></param>
        public BaseOperator(IEnumerable<FiltersBase> childFilters)
        {
            ChildFilters = new List<FiltersBase>();

            if(childFilters != null)
                ChildFilters.AddRange(childFilters);
        }
    }
}
