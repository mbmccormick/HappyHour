﻿using System;
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
        #region List Properties

        public static ObservableCollection<Item> Venues { get; set; }

        #endregion

        private bool isLoaded = false;

        private GeoCoordinateWatcher locationService = null;

        public MainPage()
        {
            InitializeComponent();

            Venues = new ObservableCollection<Item>();

            locationService = new GeoCoordinateWatcher(GeoPositionAccuracy.High);

            locationService.MovementThreshold = 500;
            locationService.PositionChanged += locationService_PositionChanged;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            locationService.Start();

            if (isLoaded == false)
                LoadData();
        }

        private void LoadData()
        {
            this.prgLoading.Visibility = System.Windows.Visibility.Visible;

            App.HappyHourClient.GetVenues((result) =>
            {
                SmartDispatcher.BeginInvoke(() =>
                {
                    Venues.Clear();

                    if (result.groups != null)
                    {
                        this.txtNeighborhood.Text = result.headerLocation.ToUpper();

                        List<Item> results = new List<Item>();

                        foreach (var group in result.groups)
                        {
                            foreach (var item in group.items)
                            {
                                results.Add(item);
                            }
                        }

                        int i = 1;
                        foreach (Item item in results.OrderBy(z => z.venue.location.distance))
                        {
                            item.Index = i;
                            i++;

                            Venues.Add(item);
                        }
                    }

                    isLoaded = true;

                    ToggleLoadingText();
                    ToggleEmptyText();

                    this.prgLoading.Visibility = System.Windows.Visibility.Collapsed;
                });

            }, locationService.Position.Location.Latitude, locationService.Position.Location.Longitude);
        }

        private void ToggleLoadingText()
        {
            this.txtLoading.Visibility = System.Windows.Visibility.Collapsed;
            this.lstVenues.Visibility = System.Windows.Visibility.Visible;
        }

        private void ToggleEmptyText()
        {
            if (Venues.Count == 0)
                this.txtEmpty.Visibility = System.Windows.Visibility.Visible;
            else
                this.txtEmpty.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void locationService_PositionChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        {
            isLoaded = false;

            LoadData();
        }
    }
}
