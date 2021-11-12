using Android.App;
using Android.OS;
using ApiExamples.Core.ViewModels;
using MvvmCross.Converters;
using MvvmCross.Platforms.Android.Views;

namespace ApiExamples.Droid.Views
{
    [Activity(Label = "Api examples", Theme = "@style/AppTheme")]
    public class FirstView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FirstView);
        }
    }

    [Activity(NoHistory = true, Theme = "@style/AppTheme")]
    public class DateTimeView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Test_Date);
        }
    }

    [Activity(NoHistory = true, Theme = "@style/AppTheme")]
    public class TimeView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Test_Time);
        }
    }

    [Activity(NoHistory = true, Theme = "@style/AppTheme")]
    public class SpinnerView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Test_Spinner);
        }
    }

    [Activity(NoHistory = true, Theme = "@style/AppTheme")]
    public class ListView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Test_List);
        }
    }

    [Activity(NoHistory = true, Theme = "@style/AppTheme")]
    public class TextView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Test_Text);
        }
    }

    [Activity(NoHistory = true, Theme = "@style/AppTheme")]
    public class SeekView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Test_Seek);
        }
    }

    [Activity(NoHistory = true, Theme = "@style/AppTheme")]
    public class ContainsSubView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Test_ContainsSub);
        }
    }

    [Activity(NoHistory = true, Theme = "@style/AppTheme")]
    public class ConvertThisView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Test_ConvertThis);
        }
    }

    [Activity(NoHistory = true, Theme = "@style/AppTheme")]
    public class ObservableCollectionView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Test_ObservableCollection);
        }
    }

    [Activity(NoHistory = true, Theme = "@style/AppTheme")]
    public class ObservableDictionaryView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Test_ObservableDictionary);
        }
    }

    [Activity(NoHistory = true, Theme = "@style/AppTheme")]
    public class WithErrorsView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Test_WithErrors);
        }
    }

    [Activity(NoHistory = true, Theme = "@style/AppTheme")]
    public class IfView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Test_If);
        }
    }

    [Activity(NoHistory = true, Theme = "@style/AppTheme")]
    public class MathsView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Test_Maths);
        }
    }

    [Activity(NoHistory = true, Theme = "@style/AppTheme")]
    public class RadioGroupView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Test_RadioGroup);
        }
    }

    public class ErrorExistsValueConverter : MvxValueConverter
    {
        public override object Convert(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return (value != null);
        }
    }

    [Activity(NoHistory = true, Theme = "@style/AppTheme")]
    public class RatingBarView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Test_RatingBar);
        }
    }

    [Activity(NoHistory = true, Theme = "@style/AppTheme")]
    public class CommandView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Test_Command);
        }
    }
}