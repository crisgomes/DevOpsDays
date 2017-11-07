using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

using Xamarin.Forms;

namespace DevOpsDays
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new DevOpsDays.MainPage();
            MobileCenter.Start("android=bea4db64-a728-421a-92af-caa6d2e2db87;" + "uwp=bea4db64-a728-421a-92af-caa6d2e2db87;" +
                   "ios=bea4db64-a728-421a-92af-caa6d2e2db87",
                   typeof(Analytics), typeof(Crashes));
        }

        protected override void OnStart()
        {
            // Handle when your app starts
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
