using EstudosGerais.Adapter_Pattern.Interfaces;
using EstudosGerais.Adapter_Pattern.Model;
using Newtonsoft.Json;

namespace EstudosGerais.Adapter_Pattern
{
    public class LumiaJSONAdaptee : ILumiaJSONAdaptee
    {
        public string GetLumiaMobileSpecifications()
        {
            List<LumiaMobile> listLumia = new List<LumiaMobile>();
            listLumia.Add(new LumiaMobile{
                IdModel = "Lumia1",
                Height = "136.1mm",
                Width = "67.0mm",
                Weight = "9.0mm",
                Thickness = "147g"            
            });

            listLumia.Add(new LumiaMobile
            {
                IdModel = "Lumia2",
                Height = "136.1mm",
                Width = "67.0mm",
                Weight = "9.0mm",
                Thickness = "147g"
            });

            dynamic collectionLumiaMobile = new {
                Lumia = listLumia
            };

            return JsonConvert.SerializeObject(collectionLumiaMobile);
        }
    }
}
