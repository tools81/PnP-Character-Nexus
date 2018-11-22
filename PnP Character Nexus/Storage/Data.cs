using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Windows.Storage;

namespace PnP_Character_Nexus.Storage
{
    public class Data
    {
        public static readonly List<Ruleset> Rulesets = new Lazy<Task<List<Ruleset>>>(async () => await GetRulesets()).Value.Result;

        private static async Task<List<Ruleset>> GetRulesets()
        {
            List<Ruleset> rulesets = new List<Ruleset>();

            var sf = await Source.Path.GetFileAsync("Ruleset.xml").AsTask().ConfigureAwait(false);

            //var sf = await StorageFile.GetFileFromPathAsync($@"{Source.Path}\\Ruleset.xml").AsTask().ConfigureAwait(false);

            using (var stream = await sf.OpenStreamForReadAsync().ConfigureAwait(false))
            {
                XmlReader reader = XmlReader.Create(stream);
                while (reader.ReadToFollowing("Ruleset"))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Ruleset));
                    var obj = serializer.Deserialize(reader);
                    if (obj is Ruleset)
                        rulesets.Add((Ruleset)obj);
                }
            }

            return rulesets;
        }
    }
}
