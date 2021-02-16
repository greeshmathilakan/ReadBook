using System;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ReadBooks
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override async void OnStart()
        {
            // Handle when your app starts
            AppCenter.Start("ios=4f1aae4f-f136-4dfc-9c74-6f76de782249;" +
                            "android=4bc26d8f-dd48-46ab-99f5-0594a4293797",
                            typeof(Analytics), typeof(Crashes));
            bool didAppCrashes = await Crashes.HasCrashedInLastSessionAsync();
            if (didAppCrashes)
            {
               await MainPage.DisplayAlert("Sorry", "It appears we had some issue when you last used the app. Apologies for the inconvenience.", "OK");
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
