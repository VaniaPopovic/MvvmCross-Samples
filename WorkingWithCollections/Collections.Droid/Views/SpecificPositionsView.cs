using Android.App;
using Android.Content.PM;
using MvvmCross.Platforms.Android.Views;

namespace Collections.Droid.Views
{
    [Activity(Label = "Specific Positions", ScreenOrientation = ScreenOrientation.Portrait, Theme = "@style/AppTheme")]
    public class SpecificPositionsView : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.Page_SpecificPositions);
        }
    }
}