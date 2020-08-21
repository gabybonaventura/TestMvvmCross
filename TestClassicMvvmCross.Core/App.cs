using System;
using MvvmCross.IoC;
using MvvmCross.ViewModels;
using TestClassicMvvmCross.Core.ViewModels;

namespace TestClassicMvvmCross.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<TipViewModel>();
        }
    }
}
