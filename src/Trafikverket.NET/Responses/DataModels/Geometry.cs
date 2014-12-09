using System.Xml.Serialization;

namespace Trafikverket.NET
{
    public class Geometry
    {
        [XmlElement("SWEREF99TM")]
        public string SWEREF99TM_String { get; set; }

        [XmlElement("WGS84")]
        public string WGS84_String { get; set; }
    }
}
