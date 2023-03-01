using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using System.Linq;
using static System.Net.WebRequestMethods;
using static System.Formats.Asn1.AsnWriter;
using System.Security.Cryptography;

namespace AdvanceTechBot.NLUService
{
    public class LuisService
    {
        public static async Task<LuisResponseParse> ProcessUserInputAsync(string UserQuery)
        {
            try

            {

                string returnvalue = string.Empty;

                string escapedString = Uri.EscapeDataString(UserQuery);
                using (var client = new HttpClient())
                {
                    string uri = $"https://advancetechchatbot.cognitiveservices.azure.com/luis/prediction/v3.0/apps/bd25bad9-69e5-4c8e-acee-01a55b2db692/slots/production/predict?verbose=true&show-all-intents=true&log=true&subscription-key=47bb98d613bb4079a050b826f5ae7ff2&query={escapedString}";

                    var msg = await client.GetAsync(uri);


                    if (msg.IsSuccessStatusCode)

                    {

                        var jsonResponse = await msg.Content.ReadAsStringAsync();
                        var jsonData = JObject.Parse(JsonConvert.DeserializeObject(jsonResponse).ToString());

                        var query = jsonData["query"].ToString();

                        var allintents = jsonData["prediction"]["intents"].ToList();
                        var ent = jsonData["prediction"]["entities"].ToList();
 
                        Entity[] e = { };
                        var topintent = jsonData["prediction"]["topIntent"].ToString();

                        Topscoringintent topScoringIntent = new Topscoringintent();
                        List<Intent> intentList = new List<Intent>();

                        int count = 0;



                        foreach (var intents in allintents)
                        {
                            Intent i = new Intent();
                            i.intent = ((JProperty)intents).Name;
                            var k = JsonConvert.DeserializeObject<Dictionary<string, float>>((((JProperty)intents).First).ToString().Trim());

                            foreach (var item in k)
                            {
                                i.score = item.Value;
                            }
                            intentList.Add(i);

                            if (count == 0)
                            {
                                topScoringIntent.intent = i.intent;
                                topScoringIntent.score = i.score;
                            }
                            count++;
                        }
                            Intent[] arrtetents =intentList.ToArray();
                        LuisResponseParse luisResponse= new LuisResponseParse();

                        luisResponse.query =query;

                        luisResponse.alteredQuery = query;
                        luisResponse.intents = arrtetents;

                        if (ent.Count > 0)
                        {
                            List<Entity> le = new List<Entity>();
                            for (int i = 0; i < ent.Count - 1; i++)
                            {
                                if (((JProperty)ent[i]).Name.ToString().ToLower()!= "keywords")
                                {
                                    le.Add(new Entity {
                                        type = ((JProperty)ent[i]).Name.ToString(),
                                        entity= ((JProperty)ent[i]).Value.ToString()
                                    });

                                }
                            }
                            luisResponse.entities=le.ToArray();

                        }
                        else
                        {
                            luisResponse.entities = new Entity[] { };
                        }

                        luisResponse.topScoringIntent= topScoringIntent;
                        var data = luisResponse;
                        return data;
                        }
                    }
                return null;
            }

            catch (Exception ex)
            {

                return null;
            }
        }
    }
}
