using HappyHour.API.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace HappyHour.API
{
    public class ServiceClient
    {
        private string _serverAddress = null;

        public ServiceClient(string serverAddress)
        {
            _serverAddress = serverAddress;
        }

        public void GetVenues(Action<List<Item>> callback, double latitude, double longitude)
        {
            RestClient client = new RestClient("http://" + _serverAddress);

            RestRequest request = new RestRequest("/api/v1/venues", Method.GET);
            request.AddParameter("location", latitude + "," + longitude);

            client.ExecuteAsync<List<Item>>(request, (response) =>
            {
                callback(response.Data);
            });
        }
    }
}
