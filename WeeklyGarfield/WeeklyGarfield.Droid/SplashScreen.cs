using Android.App;
using DailyDilbert.Droid;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using MvvmCross.Platforms.Android.Views;


namespace DailyGarfield.Droid
{
    [MvxActivityPresentation]
    [Activity(Label = "Your App Name", MainLauncher = true, Icon = "@drawable/icon", Theme = "@style/Theme.Splash")]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}