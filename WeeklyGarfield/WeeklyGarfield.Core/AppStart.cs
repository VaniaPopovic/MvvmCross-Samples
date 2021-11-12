using System.Threading.Tasks;
using DailyGarfield.Core.ViewModels;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace StarWarsSample.Core
{
    public class AppStart : MvxAppStart
    {
        public AppStart(IMvxApplication app, IMvxNavigationService mvxNavigationService)
            : base(app, mvxNavigationService)
        {
        }

        protected override Task NavigateToFirstViewModel(object hint = null)
        {
            return NavigationService.Navigate<ListViewModel>();
        }
    }
}
