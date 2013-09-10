using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using HappyHour.API.Models;
using HappyHour.Common;

namespace HappyHour
{
    public partial class VenuePage : PhoneApplicationPage
    {
        #region Databinding Properties

        public static Item CurrentVenue { get; set; }

        #endregion

        private bool isLoaded = false;

        public VenuePage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            SystemTray.ProgressIndicator = new ProgressIndicator();

            SystemTray.ProgressIndicator.IsIndeterminate = true;
            SystemTray.ProgressIndicator.IsVisible = false;

            if (isLoaded == false)
                LoadData();
        }

        private void LoadData()
        {
            string id;
            if (NavigationContext.QueryString.TryGetValue("id", out id))
            {
                SystemTray.ProgressIndicator.IsVisible = true;

                CurrentVenue = MainPage.Venues[Convert.ToInt32(id)];

                SmartDispatcher.BeginInvoke(() =>
                {
                    this.txtName.Text = CurrentVenue.venue.name.ToUpper();

                    isLoaded = true;

                    ToggleLoadingText();
                    ToggleEmptyText();

                    SystemTray.ProgressIndicator.IsVisible = false;
                });
            }
        }

        private void ToggleLoadingText()
        {
            SystemTray.ProgressIndicator.IsVisible = false;
        }

        private void ToggleEmptyText()
        {
            if (CurrentVenue == null)
                SystemTray.ProgressIndicator.IsVisible = true;
            else
                SystemTray.ProgressIndicator.IsVisible = false;
        }
    }
}