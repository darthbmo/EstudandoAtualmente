using EstudosGerais.Adapter_Pattern.Interfaces;
using Newtonsoft.Json;
using System.Xml;

namespace EstudosGerais.Adapter_Pattern
{
    public class LumiaXMLAdapter : ILumiaXMLTarget
    {
        public XmlDocument GetLumiaMobileXMLSpecifications()
        {
            LumiaJSONAdaptee lumiaJsonAdaptee = new LumiaJSONAdaptee();
            string jsonLumia = lumiaJsonAdaptee.GetLumiaMobileSpecifications();
            var doc = JsonConvert.DeserializeXmlNode(jsonLumia, "Microsoft Lumia", true);

            return doc;
        }
    }
}
