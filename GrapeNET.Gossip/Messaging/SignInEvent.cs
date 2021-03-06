﻿using Newtonsoft.Json;
using System;

namespace NetMud.Gossip.Messaging
{
    [Serializable]
    public class SignInEvent
    {
        [JsonProperty("name")]
        public string PlayerName { get; set; }

        [JsonProperty("game")]
        public string GameName { get; set; }
    }
}
