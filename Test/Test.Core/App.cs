using MvvmCross.IoC;
using MvvmCross.ViewModels;
using Test.Core.ViewModels;

namespace Test.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<CounterViewModel>();
        }
    }
}
