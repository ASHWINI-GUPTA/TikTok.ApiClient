﻿using Newtonsoft.Json;

namespace TikTok.ApiClient.Entities
{
    public class AgentAdvertiser : IApiEntity
    {
        [JsonProperty("advertiser_id")]
        public string AdvertiserId { get; set; }

        [JsonProperty("advertiser_name")]
        public string AdvertiserName { get; set; }
    }
}
