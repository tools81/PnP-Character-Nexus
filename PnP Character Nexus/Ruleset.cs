using System;
using System.Xml;
using System.Xml.Serialization;

namespace PnP_Character_Nexus
{
    [Serializable()]
    public class Ruleset
    {
        [XmlAttribute("Name")]
        public string Name { get; set; }
        [XmlAttribute("AppDirectory")]
        public string AppDirectory { get; set; }
        [XmlAttribute("DataDirectory")]
        public string DataDirectory { get; set; }
        [XmlAttribute("PrintTemplatePath")]
        public string PrintTemplatePath { get; set; }
        [XmlAttribute("Icon")]
        public string Icon { get; set; }
        [XmlAttribute("Logo")]
        public string Logo { get; set; }
        [XmlAttribute("Image")]
        public string Image { get; set; }
    }
}
