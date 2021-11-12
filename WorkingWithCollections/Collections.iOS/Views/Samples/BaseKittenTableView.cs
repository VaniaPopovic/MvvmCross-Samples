using System.Collections.Generic;
using UIKit;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Views;
using MvvmCross.Platforms.Ios.Binding.Views;

namespace Collections.iOS
{
    public class BaseKittenTableView
        : MvxTableViewController
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var source = new TableSource(TableView)
            {
                UseAnimations = true,
                AddAnimation = UITableViewRowAnimation.Left,
                RemoveAnimation = UITableViewRowAnimation.Right
            };

            this.AddBindings(new Dictionary<object, string>
                {
                    {source, "ItemsSource Kittens"}
                });

            TableView.Source = source;
            TableView.RowHeight = 120f;
            TableView.ReloadData();
        }

        public class TableSource : MvxSimpleTableViewSource
        {
            public TableSource(UITableView tableView)
                : base(tableView, "KittenCell", "KittenCell")
            {
                tableView.SeparatorStyle = UITableViewCellSeparatorStyle.None;
            }
        }
    }
}