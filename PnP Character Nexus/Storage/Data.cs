using PnP_Character_Nexus.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace PnP_Character_Nexus.Storage
{
    public class Data
    {
        public static readonly List<Ruleset> Rulesets = GetRulesets().Result;

        private static async Task<List<Ruleset>> GetRulesets()
        {
            List<Ruleset> rulesets = new List<Ruleset>();

            var sf = await Source.Folder.GetFileAsync("Ruleset.xml").AsTask().ConfigureAwait(false);

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
