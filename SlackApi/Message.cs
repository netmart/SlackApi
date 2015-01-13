using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlackApi
{
    public class Message
    {
        public Message()
        {
            Attachments = new List<Attachment>();
            Parse = "full";
        }

        [JsonProperty("channel")]
        public string Channel { get; set; }
        [JsonProperty("username")]
        public string Username { get; set; }
        [JsonProperty("text")]
        public string Text { get; set; }
        [JsonProperty("token")]
        public string Token { get; set; }
        [JsonProperty("parse")]
        public string Parse { get; set; }
        [JsonProperty("link_names")]
        public string LinkNames { get; set; }
        [JsonProperty("unfurl_links")]
        public string UnfurlLinks { get; set; }
        [JsonProperty("unfurl_media")]
        public string UnfurlMedia { get; set; }
        [JsonProperty("icon_url")]
        public string IconUrl { get; set; }
        [JsonProperty("icon_emoji")]
        public string IconEmoji { get; set; }
        [JsonProperty("attachments")]
        public List<Attachment> Attachments { get; set; }
    }
}
