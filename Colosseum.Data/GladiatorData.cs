using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Colosseum.Data
{
    public class GladiatorData
    {
        //Creates Custom Gladiator
        public static void SelectGladiatorByKeyInput(ConsoleKey key)
        {

        }

        //public static GladiatorTemplate SelectGladiator()
        //{
        //    var gladiatorBase = Gladiators.GladiatorData.BaseGladiators();

        //    var gladiator = (from g in gladiatorBase
        //                     where g.Key == key
        //                     select g).FirstOrDefault();

        //    return gladiator;
        //}

        //Creates a gladiator to the JSON file.
        public static void CreateGladiator(string name, int hp, int atk, int def, int ctd, ConsoleKey key)
        {
            using (var file = File.CreateText("Gladiators.json"))
            using (JsonTextWriter writer = new JsonTextWriter(file))
            {
                var gladiator = new GladiatorTemplate
                {
                    Name = name,
                    Hp = hp,
                    Def = def,
                    Ctd = ctd,
                    Key = key.ToString()
                };

                var serializedGladiators = JsonConvert.SerializeObject(gladiator);

                JObject jsonObject = new JObject { "Gladiators", new JArray { JObject.Parse(serializedGladiators) } };

                jsonObject.WriteTo(writer);






                //writeStream.Write(serializedGladiators);
                //writeStream.Close();
                //var writeStream = new WriteStream();

                //File.WriteAllText(@"Gladiators.json", serializedGladiators);
            }
        }
    }
}