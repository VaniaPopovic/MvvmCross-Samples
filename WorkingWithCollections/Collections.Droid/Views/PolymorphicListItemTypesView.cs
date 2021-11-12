using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Views;
using Collections.Core.ViewModels.Samples.ListItems;
using MvvmCross.Platforms.Android.Views;
using MvvmCross.Platforms.Android.Binding.Views;
using MvvmCross.Platforms.Android.Binding.BindingContext;

namespace Collections.Droid.Views
{
    [Activity(Label = "Polymorphic Types", ScreenOrientation = ScreenOrientation.Portrait, Theme = "@style/AppTheme")]
    public class PolymorphicListItemTypesView : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.Page_PolymorphicView);
            var list = FindViewById<MvxListView>(Resource.Id.TheListView);
            list.Adapter = new CustomAdapter(this, (IMvxAndroidBindingContext) BindingContext);
        }

        public class CustomAdapter : MvxAdapter
        {
            public CustomAdapter(Context context, IMvxAndroidBindingContext bindingContext)
                : base(context, bindingContext)
            {
            }

            public override int GetItemViewType(int position)
            {
                var item = GetRawItem(position);
                if (item is Kitten)
                    return 0;
                return 1;
            }

            public override int ViewTypeCount
            {
                get { return 2; }
            }

            protected override View GetBindableView(View convertView, object dataContext, ViewGroup parent, int templateId)
            {
                if (dataContext is Kitten)
                    templateId = Resource.Layout.ListItem_Kitten;
                else if (dataContext is Dog)
                    templateId = Resource.Layout.ListItem_Dog;

				return base.GetBindableView(convertView, dataContext, parent, templateId);
            }
        }
    }
}