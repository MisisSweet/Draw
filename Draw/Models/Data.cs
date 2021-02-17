using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Draw.Models
{
    public class Data
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("operation")]
        public int Operation { get; set; }
        [JsonProperty("x")]
        public float X { get; set; }
        [JsonProperty("y")]
        public float Y { get; set; }

    }
}
