using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlackApi
{
    public class SlackApiClient
    {
        private string _WebhookUrl;

        public SlackApiClient(string WebhookUrl)
        {
            this._WebhookUrl = WebhookUrl;
        }
        private string Execute(RestRequest request)
        {
            var client = new RestClient(_WebhookUrl);
            var response = client.Execute(request);
            if (response.ErrorException != null)
            {
                throw new Exception(response.ErrorMessage,response.ErrorException);
            }
            return response.Content;
        }

        public bool SendMessage(Message MessageToSend)
        {
            var request = new RestRequest(Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.JsonSerializer = new CustomJsonSerializer();
            request.AddBody(MessageToSend);
            string SlackResponse = Execute(request);
            return SlackResponse == "ok" ? true : false;
        }
    }
}
