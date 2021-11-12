using Android.App;
using Android.Content.PM;
using MvvmCross.Platforms.Android.Views;

namespace Collections.Droid.Views
{
    [Activity(Label = "Small Dynamic", ScreenOrientation = ScreenOrientation.Portrait, Theme = "@style/AppTheme")]
    public class SmallDynamicView : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.Page_DynamicView);
        }
    }
}