using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGR
{
    [Serializable]

    
    public class WriterImage
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public string url { get; set; }
        public string caption { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    [Serializable]
    public class WriterJson
    {
      
        [JsonProperty("url")]
        public string Url { get; set; }


        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("alternateName")]
        public string AlternateName { get; set; }        
        
        public WriterImage image { get; set; }   
        public string birthDate { get; set; }
        public string deathDate { get; set; }
        public string gender { get; set; }
        public string birthPlace { get; set; }
        public string jobTitle { get; set; }
    }
}
