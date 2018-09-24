using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace IT15016508.DATA
{
    public class UserCompany
    {
        [JsonProperty(PropertyName = "name")]
        public string name { get; set; }

        [JsonProperty(PropertyName = "catchPhrase")]
        public string catchPhrase { get; set; }

        [JsonProperty(PropertyName = "bs")]
        public string bs { get; set; }
    }
}
