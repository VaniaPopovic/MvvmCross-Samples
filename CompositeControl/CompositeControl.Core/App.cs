using MvvmCross.IoC;
using MvvmCross.ViewModels;
using StarWarsSample.Core;

namespace CompositeControl.Core
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