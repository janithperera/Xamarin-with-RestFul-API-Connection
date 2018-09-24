using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace IT15016508.DATA
{
    public class UserAddress
    {
        [JsonProperty(PropertyName = "street")]
        public string street { get; set; }

        [JsonProperty(PropertyName = "suite")]
        public string suite { get; set; }

        [JsonProperty(PropertyName = "city")]
        public string city { get; set; }

        [JsonProperty(PropertyName = "zipcode")]
        public string zipcode { get; set; }

        [JsonProperty(PropertyName = "geo")]
        public UserAddressGeo geo { get; set; }
    }
}
