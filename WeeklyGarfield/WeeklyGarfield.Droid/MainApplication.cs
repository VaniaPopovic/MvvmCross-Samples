using Android.App;
using Android.Runtime;
using DailyGarfield.Core;
using DailyGarfield.Droid;
using MvvmCross.Platforms.Android.Views;
using System;


namespace DailyDilbert.Droid
{
    [Application]
    public class MainApplication : MvxAndroidApplication<Setup, App>
    {
        public MainApplication()
        {
        }

        public MainApplication(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }
    }
}