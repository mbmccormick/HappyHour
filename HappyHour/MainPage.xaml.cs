using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Device.Location;
using HappyHour.Common;
using System.Collections.ObjectModel;
using HappyHour.API.Models;

namespace HappyHour
{
    public partial class MainPage : PhoneApplicationPage
    {
        public static ObservableCollection<Item> Venues { get; set; }
        private GeoCoordinateWatcher locationService = null;

        // Constructor
        public MainPage()
        {
            InitializeComponent();
            Venues = new ObservableCollection<Item>(); 

            locationService = new GeoCoordinateWatcher(GeoPositionAccuracy.High); 
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            locationService.Start(); 
        }

        private void LoadData()
        {
            App.HappyHourClient.GetVenues((result) =>
                {
                    SmartDispatcher.BeginInvoke(() =>
                    {
                        Venues.Clear();

                        foreach (Item i in result)
                        {
                            Venues.Add(i); 
                        }
                    });
                }, locationService.Position.Location.Latitude, locationService.Position.Location.Longitude);
        }
    }
}