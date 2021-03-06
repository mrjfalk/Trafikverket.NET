﻿using System;
using System.Xml.Serialization;

namespace Trafikverket.NET
{
    /// <summary>
    /// Less than or equal filter
    /// </summary>
    sealed public class LessThanOrEqualFilter : BaseFilter
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        internal LessThanOrEqualFilter()
            : base()
        {

        }

        /// <summary>
        /// Constructor. Name and value are both required.
        /// </summary>
        /// <param name="name">Name of attribute</param>
        /// <param name="value">Value to compare with</param>
        public LessThanOrEqualFilter(string name, string value)
            : base(name, value)
        {

        }

		/// <summary>
		/// Constructor. Name and value are both required.
		/// </summary>
		/// <param name="name">Name of attribute</param>
		/// <param name="value">DateTime value to compare with</param>
		public LessThanOrEqualFilter(string name, DateTime value)
			: base(name, value.TrainApiDateTimeFormat())
		{

		}
    }
}
