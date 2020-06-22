﻿using Newtonsoft.Json;
using System;

namespace Analogy.LogViewer.Github.Data_Types
{
    [Serializable]
    [JsonObject]
    public class GithubUser
    {
        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("avatar_url")]
        public string avatarUrl { get; set; }

        [JsonProperty("html_url")]
        public string HtmlUrl { get; set; }
    }
}