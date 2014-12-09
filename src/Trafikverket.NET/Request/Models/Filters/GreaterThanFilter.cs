using System;
using System.Xml.Serialization;

namespace Trafikverket.NET
{
    /// <summary>
    /// Greater than filter
    /// </summary>
    sealed public class GreaterThanFilter : BaseFilter
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        internal GreaterThanFilter() : base()
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

		/// <summary>
		/// Constructor. Name and value are both required.
		/// </summary>
		/// <param name="name">Name of attribute</param>
		/// <param name="value">DateTime value to compare with</param>
		public GreaterThanFilter(string name, DateTime value)
			: base(name, value.TrainApiDateTimeFormat())
		{

		}
    }
}
