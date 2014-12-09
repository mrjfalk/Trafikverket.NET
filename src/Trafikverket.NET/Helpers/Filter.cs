using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trafikverket.NET;

namespace Trafikverket.NET
{
	/// <summary>
	/// A static filter helper class
	/// </summary>
    public static class Filter
    {
		/// <summary>
		/// Check if multiple conditions are all true (and operator)
		/// </summary>
		/// <param name="conditions">Conditions for the and filter to check if true</param>
		/// <returns>And filter</returns>
        public static AndFilterOperator And(params FiltersBase[] conditions)
        {
            return new AndFilterOperator(conditions);
        }

		/// <summary>
		/// Check if an attribute equals a specific value
		/// </summary>
		/// <param name="attribute">Attribute to check</param>
		/// <param name="value">Value to compare with</param>
		/// <returns>Equals filter</returns>
        public static EqualsFilter Equals(string attribute, string value)
        {
            return new EqualsFilter(attribute, value);
        }

		/// <summary>
		/// Check if an attribute value is greater than a specific value
		/// </summary>
		/// <param name="attribute">Attribute to check</param>
		/// <param name="value">Value to compare with</param>
		/// <returns>Greater than filter</returns>
        public static GreaterThanFilter GreaterThan(string attribute, string value)
        {
            return new GreaterThanFilter(attribute, value);
        }

		/// <summary>
		/// Check if an attribute value is greater than or equal to a specific value
		/// </summary>
		/// <param name="attribute">Attribute to check</param>
		/// <param name="value">Value to compare with</param>
		/// <returns>Greater than or equals filter</returns>
        public static GreaterThanOrEqualFilter GreaterThanOrEquals(string attribute, string value)
        {
            return new GreaterThanOrEqualFilter(attribute, value);
        }

		/// <summary>
		/// Check if a value is in a list of values for an attribute
		/// </summary>
		/// <param name="attribute">Attribute to check, should be an array type</param>
		/// <param name="value">Value to check if included in the list</param>
		/// <returns>In filter</returns>
        public static InFilter In(string attribute, string value)
        {
            return new InFilter(attribute, value);
        }

		/// <summary>
		/// Check if an attribute value is less than a specific value
		/// </summary>
		/// <param name="attribute">Attribute to check</param>
		/// <param name="value">Value to compare with</param>
		/// <returns>Less than filter</returns>
        public static LessThanFilter LessThan(string attribute, string value)
        {
            return new LessThanFilter(attribute, value);
        }

		/// <summary>
		/// Check if an attribute value is less than or equal to a specific value
		/// </summary>
		/// <param name="attribute">Attribute to check</param>
		/// <param name="value">Value to compare with</param>
		/// <returns>Less than or equals filter</returns>
        public static LessThanOrEqualFilter LessThanOrEquals(string attribute, string value)
        {
            return new LessThanOrEqualFilter(attribute, value);
        }

		/// <summary>
		/// Check if an attribute value matches a regular expression
		/// </summary>
		/// <param name="attribute">Attribute to check</param>
		/// <param name="regularExpression">Regular expression</param>
		/// <returns>Like filter</returns>
        public static LikeFilter Like(string attribute, string regularExpression)
        {
			return new LikeFilter(attribute, regularExpression);
        }

		/// <summary>
		/// Check if an attribute does not equal a specific value
		/// </summary>
		/// <param name="attribute">Attribute to check</param>
		/// <param name="value">Value to compare with</param>
		/// <returns>Equals filter</returns>
		public static NotEqualsFilter NotEquals(string attribute, string value)
        {
			return new NotEqualsFilter(attribute, value);
        }

		/// <summary>
		/// Check if a value is not in a list of values for an attribute
		/// </summary>
		/// <param name="attribute">Attribute to check, should be an array type</param>
		/// <param name="value">Value to check if not included in the list</param>
		/// <returns>In filter</returns>
        public static NotInFilter NotIn(string attribute, string value)
        {
            return new NotInFilter(attribute, value);
        }

		/// <summary>
		/// Check if an attribute value does not match a regular expression
		/// </summary>
		/// <param name="attribute">Attribute to check</param>
		/// <param name="regularExpression">Regular expression</param>
		/// <returns>Not like filter</returns>
		public static NotLikeFilter NotLike(string attribute, string regularExpression)
        {
			return new NotLikeFilter(attribute, regularExpression);
        }

		/// <summary>
		/// Check if atleast one of multiple conditions is true
		/// </summary>
		/// <param name="conditions">Conditions for the and filter to check if at least one is true</param>
		/// <returns>Or filter</returns>
        public static OrFilterOperator Or(params FiltersBase[] conditions)
        {
            return new OrFilterOperator(conditions);
        }

		/// <summary>
		/// Check if an attribute value is within a specific geometrical shape.
		/// See http://api.trafikinfo.trafikverket.se/API/TheRequest#geo
		/// </summary>
		/// <param name="attribute">Name of attribute, should be either a SWEREF99TM or WGS84 coordinate value</param>
		/// <param name="coordinates">Coordinates for the shape. Can be both SWEREF99TM or WGS84, depending on which is choosen as attribute</param>
		/// <param name="shape">Shape</param>
		/// <param name="radius">Radius of shape (use with "center" shape)</param>
        public static WithinFilter Within(string attribute, string coordinates, string shape, string radius = "")
        {
            return new WithinFilter(attribute, coordinates, shape, radius);
        }
    }
}
