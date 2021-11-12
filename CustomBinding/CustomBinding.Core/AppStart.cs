using CustomBinding.Core.ViewModels;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using System.Threading.Tasks;

namespace CustomBinding.Core
{
    public class AppStart : MvxAppStart
    {
        public AppStart(IMvxApplication app, IMvxNavigationService mvxNavigationService)
            : base(app, mvxNavigationService)
        {
        }

        //protected override Task NavigateToFirstViewModel(object hint = null)
        //{
        //    return NavigationService.Navigate<FirstViewModel>();
        //}
    }
}
