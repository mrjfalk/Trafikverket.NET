using System.Xml.Serialization;

namespace Trafikverket.NET
{
    /// <summary>
    /// Check if an attribute value is within a specific geometrical shape.
	/// See http://api.trafikinfo.trafikverket.se/API/TheRequest#geo
    /// </summary>
    sealed public class WithinFilter : BaseFilter
    {
		/// <summary>
		/// Get or set shape, valid values are "box", "polygon", or "center"
		/// </summary>
		[XmlAttribute("shape")]
		public string Shape { get; set; }

		/// <summary>
		/// Get or set radius
		/// </summary>
		[XmlAttribute("radius")]
		public string Radius { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        internal WithinFilter()
            : base()
        {

        }

        /// <summary>
        /// Constructor. Name, coordinates, and shape are both required.
        /// </summary>
		/// <param name="name">Name of attribute, should be either a SWEREF99TM or WGS84 coordinate value</param>
		/// <param name="coordinates">Coordinates for the shape. Can be both SWEREF99TM or WGS84, depending on which is choosen as attribute</param>
		/// <param name="shape">Shape</param>
		/// <param name="radius">Radius of shape (use with "center" shape)</param>
        public WithinFilter(string name, string coordinates, string shape, string radius = "")
			: base(name, coordinates)
        {
			Shape = shape;
			Radius = radius;
        }
    }
}
