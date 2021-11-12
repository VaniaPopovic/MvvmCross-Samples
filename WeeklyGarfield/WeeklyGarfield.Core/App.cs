using MvvmCross.IoC;
using MvvmCross.ViewModels;
using StarWarsSample.Core;

namespace DailyGarfield.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

             RegisterCustomAppStart<AppStart>();
        }
    }
}