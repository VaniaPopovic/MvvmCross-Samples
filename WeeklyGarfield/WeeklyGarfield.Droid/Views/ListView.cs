using Android.App;
using Android.OS;
using DailyDilbert.Droid;
using MvvmCross.Platforms.Android.Views;

namespace DailyGarfield.Droid.Views
{
    [Activity(Label = "View for ListViewModel", Theme = "@style/AppTheme")]
    public class ListView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.ListView);
        }
    }
}