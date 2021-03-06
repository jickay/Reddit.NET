﻿using Newtonsoft.Json;
using Reddit.Models.Converters;
using System;

namespace Reddit.Things
{
    [Serializable]
    public class LiveUpdate
    {
        [JsonProperty("body")]
        public string Body;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("mobile_embeds")]
        public object MobileEmbeds;  // TODO - Determine type.  --Kris

        [JsonProperty("author")]
        public string Author;

        [JsonProperty("embeds")]
        public object Embeds;  // TODO - Determine type.  --Kris

        [JsonProperty("created")]
        [JsonConverter(typeof(TimestampConvert))]
        public DateTime Created;

        [JsonProperty("created_utc")]
        [JsonConverter(typeof(TimestampConvert))]
        public DateTime CreatedUTC;

        [JsonProperty("body_html")]
        public string BodyHTML;

        [JsonProperty("stricken")]
        public bool Stricken;

        [JsonProperty("id")]
        public string Id;

        public string Fullname => "LiveUpdate_" + Id;
    }
}
