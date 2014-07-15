using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace Trafikverket.Net
{
    /// <summary>
    /// Model for a query
    /// </summary>
    public class QueryModel
    {
        /// <summary>
        /// Get or set type of object to return
        /// </summary>
        [XmlAttribute("objecttype")]
        public string ObjectType { get; set; }

        /// <summary>
        /// Get or set an id which is also returned in the response (Optional)
        /// </summary>
        [XmlAttribute("id")]
        public string Id { get; set; }

        /// <summary>
        /// Get or set if deleted objects should be included (Optional)
        /// </summary>
        [XmlIgnore]
        public bool? IncludeDeletedObjects { get; set; }

        /// <summary>
        /// DO NOT USE! Get or set if deleted objects should be included as string, this is only used for serialization.
        /// </summary>
        [XmlAttribute("includedeletedobjects")]
        public string IncludeDeletedObjects_String
        {
            get { return IncludeDeletedObjects.HasValue ? IncludeDeletedObjects.Value.ToString() : null; }
            set { IncludeDeletedObjects = !String.IsNullOrEmpty(value) ? XmlConvert.ToBoolean(value) : (bool?)null; }
        }

        /// <summary>
        /// Get or set max number of items to return (Optional)
        /// </summary>
        [XmlIgnore]
        public int? Limit { get; set; }

        /// <summary>
        /// DO NOT USE! Get or set max number of items to return
        /// </summary>
        [XmlAttribute("limit")]
        public string Limit_String
        {
            get { return Limit.HasValue ? Limit.Value.ToString() : null; }
            set { Limit = !String.IsNullOrEmpty(value) ? XmlConvert.ToInt32(value) : (int?)null; }
        }

        /// <summary>
        /// Get or set field to order result by. E.g. "SomeData.Name desc, SomeData.Description asc" (Optional)
        /// </summary>
        [XmlAttribute("orderby")]
        public string OrderBy { get; set; }

        /// <summary>
        /// Get or set offset of items returned (Optional)
        /// </summary>
        [XmlIgnore]
        public int? Offset { get; set; }

        /// <summary>
        /// DO NOT USE! Get or set offset of items returned
        /// </summary>
        [XmlAttribute("skip")]
        public string Offset_String
        {
            get { return Offset.HasValue ? Offset.Value.ToString() : null; }
            set { Offset = !String.IsNullOrEmpty(value) ? XmlConvert.ToInt32(value) : (int?)null; }
        }

        /// <summary>
        /// Get or set if last modified date should be included in response (Optional)
        /// </summary>
        [XmlIgnore]
        public bool? IncludeLastModified { get; set; }

        /// <summary>
        /// DO NOT USE! Get or set if last modified date should be included in response
        /// </summary>
        [XmlAttribute("lastmodified")]
        public string IncludeLastModified_String
        {
            get { return IncludeLastModified.HasValue ? IncludeLastModified.Value.ToString() : null; }
            set { IncludeLastModified = !String.IsNullOrEmpty(value) ? XmlConvert.ToBoolean(value) : (bool?)null; }
        }

        /// <summary>
        /// Filters to use in the request
        /// </summary>
        [XmlArray("FILTER")]
        [XmlArrayItem("EQ", typeof(EqualsFilter))]
        [XmlArrayItem("GT", typeof(GreaterThanFilter))]
        [XmlArrayItem("GTE", typeof(GreaterThanOrEqualFilter))]
        [XmlArrayItem("LT", typeof(LessThanFilter))]
        [XmlArrayItem("LTE", typeof(LessThanOrEqualFilter))]
        [XmlArrayItem("NE", typeof(NotEqualsFilter))]
        [XmlArrayItem("LIKE", typeof(LikeFilter))]
        [XmlArrayItem("NOTLIKE", typeof(NotLikeFilter))]
        [XmlArrayItem("IN", typeof(InFilter))]
        [XmlArrayItem("NOTIN", typeof(NotInFilter))]
        [XmlArrayItem("WITHIN", typeof(WithinFilter))]
        [XmlArrayItem("AND", typeof(AndFilterOperator))]
        [XmlArrayItem("OR", typeof(OrFilterOperator))]
        public List<FiltersBase> Filters { get; set; }

        /// <summary>
        /// List of field names to include
        /// </summary>
        [XmlElement("INCLUDE")]
        public List<string> IncludeFields { get; set; }

        /// <summary>
        /// List of field names to exclude
        /// </summary>
        [XmlElement("EXCLUDE")]
        public List<string> ExcludeFields { get; set; }

        private QueryModel()
        {
            Filters = new List<FiltersBase>();
            ObjectType = "";
        }

        /// <summary>
        /// Constructor. Object type is required
        /// </summary>
        /// <param name="objectType">Object type</param>
        public QueryModel(string objectType)
        {
            Filters = new List<FiltersBase>();
            ObjectType = objectType;
        }
    }
}
