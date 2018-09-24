using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace IT15016508.DATA
{
    public class UserAddressGeo
    {
        [JsonProperty(PropertyName = "lat")]
        public string lat { get; set; }
        [JsonProperty(PropertyName = "lng")]
        public string lng { get; set; }
    }
}
