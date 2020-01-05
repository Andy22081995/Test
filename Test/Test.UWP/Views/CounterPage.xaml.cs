using MvvmCross.Platforms.Uap.Views;
using MvvmCross.ViewModels;
using Test.Core.ViewModels;

namespace Test.UWP.Views
{
    [MvxViewFor(typeof(CounterViewModel))]
    public sealed partial class CounterPage : MvxWindowsPage
    {
        public CounterPage()
        {
            InitializeComponent();
        }
    }
}
