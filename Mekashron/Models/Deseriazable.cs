using System.Xml.Serialization;

namespace Mekashron.Models
{
    public class Deseriazable
    {
        [XmlElement(Namespace = "")]
        public int EntityId { get; set; }
    }
}
