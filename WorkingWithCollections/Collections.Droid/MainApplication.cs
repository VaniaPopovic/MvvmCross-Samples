using System;
using Android.App;
using Android.Runtime;
using Collections.Core;
using MvvmCross.Platforms.Android.Views;

namespace Collections.Droid
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