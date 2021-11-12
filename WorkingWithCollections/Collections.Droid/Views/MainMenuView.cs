using Android.App;
using Android.Content.PM;
using MvvmCross.Platforms.Android.Views;

namespace Collections.Droid.Views
{
    [Activity(Label = "Main Menu", ScreenOrientation = ScreenOrientation.Portrait, Theme = "@style/AppTheme")]
    public class MainMenuView : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.Page_MainMenuView);
        }
    }
}