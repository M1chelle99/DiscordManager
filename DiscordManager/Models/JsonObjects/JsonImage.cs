﻿using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace DCM.Models.JsonObjects
{
    public class JsonImage
    {
        [JsonProperty("url")]
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}