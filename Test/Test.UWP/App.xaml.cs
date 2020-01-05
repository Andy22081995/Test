using MvvmCross.Platforms.Uap.Core;
using MvvmCross.Platforms.Uap.Views;

namespace Test.UWP
{

    public sealed partial class App
    {
        public App()
        {
            InitializeComponent();
        }
    }

    public abstract class CounterApp : MvxApplication<MvxWindowsSetup<Core.App>, Core.App>
    {
    }
}
