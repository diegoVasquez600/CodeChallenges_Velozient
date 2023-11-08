using System.Collections.Generic;
using System.Xml.Serialization;

namespace SmartVault.Library
{
    [XmlRoot(ElementName = "property")]
    public class Property
    {
        [XmlAttribute(AttributeName = "name")]
        public string? Name { get; set; }

        [XmlAttribute(AttributeName = "type")]
        public string? Type { get; set; }
    }

    [XmlRoot(ElementName = "propertyGroup")]
    public class PropertyGroup
    {
        [XmlElement(ElementName = "property")]
        public List<Property>? Property { get; set; }
    }

    [XmlRoot(ElementName = "businessObject")]
    public class BusinessObject
    {
        [XmlElement(ElementName = "propertyGroup")]
        public PropertyGroup? PropertyGroup { get; set; }

        [XmlElement(ElementName = "script")]
        public string? Script { get; set; }
    }
}
