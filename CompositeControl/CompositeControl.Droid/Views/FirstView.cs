using Android.App;
using Android.Content.PM;
using AndroidX.DrawerLayout.Widget;
using CompositeControl.Core.ViewModels;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using MvvmCross.Platforms.Android.Views;


namespace CompositeControl.Droid.Views
{
    [MvxActivityPresentation]
    [Activity(Label = "Star Wars",
        Theme = "@style/AppTheme",
        LaunchMode = LaunchMode.SingleTop,
        Name = "CompositeControl.Droid.FirstView"
        )]
    public class MainView : MvxActivity<FirstViewModel>
    {
        public DrawerLayout DrawerLayout { get; set; }

        protected override void OnCreate(Android.OS.Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FirstView);
        }
    }
}