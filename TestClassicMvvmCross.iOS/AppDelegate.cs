using Foundation;
using MvvmCross.Platforms.Ios.Core;
using TestClassicMvvmCross.Core;
using UIKit;

namespace TestClassicMvvmCross.iOS
{
    [Register("AppDelegate")]
    public class AppDelegate : MvxApplicationDelegate<MvxIosSetup<App>, App>
    {
    }
}

