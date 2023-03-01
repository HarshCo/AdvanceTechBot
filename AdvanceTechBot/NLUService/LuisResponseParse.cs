using Microsoft.Bot.Schema;
using Newtonsoft.Json.Linq;
using System;
using System.Security.Cryptography.Xml;

namespace AdvanceTechBot.NLUService
{
    [Serializable]

    public class LuisResponseParse

    {
        public string query { get; set; }

        public string alteredQuery { get; set; }

        public Topscoringintent topScoringIntent { get; set; }
        public Intent[] intents { get; set; }
        public Entity[] entities { get; set; }
    }
    [Serializable]

    public class Topscoringintent
    {
        public string intent { get; set; }


        public float score { get; set; }
    }


    [Serializable]
    public class Prediction
    {
        public string topIntent { get; set; }


        public Intent[] intents { get; set; }

        public Entity[] entities { get; set; }

    }

    [Serializable]
    public class Intent
    {
        public string intent { get; set; }
        public float score { get; set; }
    }
    [Serializable]
    public class Entity
    {
        public string entity { get; set; }
        public string type { get; set; }
        public int startIndex { get; set; }
        public int endIndex { get; set; }
        public Resolution resolution { get; set; }
    }

    [Serializable]



    public class Resolution
    {
        public Value[] values { get; set; }



        public string subtype { get; set; }



        public string value { get; set; }
    }

    [Serializable]

    public class Value
    {
        public string timex { get; set; }

        public string type { get; set; }



        public string start { get; set; }


        public string end { get; set; }
    }
}
