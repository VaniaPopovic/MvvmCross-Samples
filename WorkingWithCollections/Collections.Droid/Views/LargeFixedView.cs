using Android.App;
using Android.Content.PM;
using MvvmCross.Platforms.Android.Views;

namespace Collections.Droid.Views
{
    [Activity(Label = "Large Fixed", ScreenOrientation = ScreenOrientation.Portrait, Theme = "@style/AppTheme")]
    public class LargeFixedView : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.Page_FixedView);
        }
    }
}