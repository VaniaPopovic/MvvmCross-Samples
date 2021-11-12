using System;
using Android.App;
using Android.Runtime;
using CompositeControl.Core;
using MvvmCross.Platforms.Android.Views;

namespace CompositeControl.Droid
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