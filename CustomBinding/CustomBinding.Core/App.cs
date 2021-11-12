using MvvmCross.Core.ViewModels;
using MvvmCross.IoC;
using MvvmCross.Platform.IoC;
using MvvmCross.ViewModels;

namespace CustomBinding.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
               .EndingWith("Service")
               .AsInterfaces()
               .RegisterAsLazySingleton();

            CreatableTypes()
               .EndingWith("Client")
               .AsInterfaces()
               .RegisterAsLazySingleton();

            RegisterCustomAppStart<AppStart>();
        }
    }
}