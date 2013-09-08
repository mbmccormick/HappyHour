namespace HappyHour.Service
{
    using HappyHour.Service.Models;
    using Nancy;
    using RestSharp;
    using System.Collections.Generic;

    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Get["/api/v1/venues"] = parameters =>
            {
                RestClient client = new RestClient("https://api.foursquare.com/v2");
                client.AddDefaultParameter("client_id", "VJDTI5JLMM1LL2Z0TP3XZQF515KKKQ5SHAAHVX2SBGBKCWE0");
                client.AddDefaultParameter("client_secret", "GQVAJXFFFSBXVTP2P2DGL2MR1NUQ0HOGKA3OKNGJSJ31MPIO");

                RestRequest request = new RestRequest("/venues/explore");
                request.AddParameter("ll", Request.Query.location);
                request.AddParameter("query", "happy hour");

                var response = client.Execute<Models.Response>(request);

                List<Venue> results = new List<Venue>();

                foreach (var group in response.Data.response.groups)
                {
                    foreach (var item in group.items)
                    {
                        results.Add(item.venue);
                    }
                }

                return Response.AsJson(results);
            };
        }
    }
}