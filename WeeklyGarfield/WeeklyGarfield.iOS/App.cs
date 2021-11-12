using DailyGarfield.Touch.ViewModels;
using MvvmCross.IoC;
using MvvmCross.ViewModels;

namespace DailyGarfield.Touch
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<FirstViewModel>();
        }
    }
}