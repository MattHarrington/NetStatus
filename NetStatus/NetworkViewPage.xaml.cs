using System;
using System.Collections.Generic;
using Connectivity.Plugin;
using System.Linq;
using Xamarin.Forms;

namespace NetStatus
{
    public partial class NetworkViewPage : ContentPage
    {
        public NetworkViewPage()
        {
            InitializeComponent();
        }

        public void UpdateNetworkInfo()
        {
            var connectionType = CrossConnectivity.Current.ConnectionTypes;
           // ConnectionDetails.Text = connectionType.ToString();


        }

        protected override void OnAppearing()
        {
//            base.OnAppearing();
            UpdateNetworkInfo();
            CrossConnectivity.Current.ConnectivityChanged += CrossConnectivity_Current_ConnectivityChanged;
        }

        void CrossConnectivity_Current_ConnectivityChanged (object sender, Connectivity.Plugin.Abstractions.ConnectivityChangedEventArgs e)
        {
            UpdateNetworkInfo();
        }

        protected override void OnDisappearing()
        {
//            base.OnDisappearing();
            CrossConnectivity.Current.ConnectivityChanged -= CrossConnectivity_Current_ConnectivityChanged;
        }
    }
}

