using System;
using Connectivity.Plugin;
using Xamarin.Forms;

namespace NetStatus
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
//            if (CrossConnectivity.Current.IsConnected)
//            {
//                MainPage = new NetworkViewPage();
//            }
//            else
//            {
//                MainPage = new NoNetworkPage();
//            }
            MainPage = new NetworkViewPage();
        }

        protected override void OnStart()
        {
            CrossConnectivity.Current.ConnectivityChanged += CrossConnectivity_Current_ConnectivityChanged;
        }

        void CrossConnectivity_Current_ConnectivityChanged (object sender, Connectivity.Plugin.Abstractions.ConnectivityChangedEventArgs e)
        {
            if (e.IsConnected)
            {
                MainPage = new NetworkViewPage();
            }
            else
            {
                MainPage = new NoNetworkPage();
            }
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

