using PnP_Character_Nexus.Utility;
using System;
using System.Xml;
using System.Xml.Serialization;
using Windows.UI.Xaml.Media;

namespace PnP_Character_Nexus.Models
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

        [XmlIgnore]
        public ImageBrush IconSource => ConvertStringToImageSource.GetSourceFromPath(Icon).Result;
        [XmlIgnore]
        public ImageBrush LogoSource => ConvertStringToImageSource.GetSourceFromPath(Logo).Result;
        [XmlIgnore]
        public ImageBrush ImageSource => ConvertStringToImageSource.GetSourceFromPath(Image).Result;        
    }
}
