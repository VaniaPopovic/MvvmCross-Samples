using MvvmCross.IoC;
using MvvmCross.ViewModels;

namespace Collections.Core
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

            // register the appstart object
            RegisterCustomAppStart<AppStart>();
        }
    }
}