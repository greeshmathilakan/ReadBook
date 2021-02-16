using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace ReadBooks.Tests
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp.Android.InstalledApp("com.lalorosas.readbooks").StartApp();
            }

            return ConfigureApp.iOS.AppBundle("Users/Greeshma.Thilakan/source/repos/CICDXam_ReadBook/ReadBooks.iOS/bin/iPhoneSimulator/Debug").StartApp();
        }
    }
}