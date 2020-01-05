using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System;
using System.Threading.Tasks;
using Test.Core.Services;

namespace Test.Core.ViewModels
{
    public class CounterViewModel : MvxViewModel
    {
        private double _counter;
        
        public double Counter
        {
            get => _counter;
            set
            {
                _counter = value;
                RaisePropertyChanged(() => Counter);
            }
        }

        private double _increment;

        public double Increment
        {
            get => _increment;
            set
            {
                _increment = value;
                RaisePropertyChanged(() => Increment);
            }
        }

        private readonly ICounterService _counterService;
        
        #region Commands

        public MvxCommand IncreaseCommand =>
            new MvxCommand(Increase);

        public MvxCommand DecreaseCommand =>
            new MvxCommand(Decrease);

        public MvxCommand ResetCommand =>
            new MvxCommand(Reset);

        #endregion  

        public CounterViewModel(ICounterService counterService)
        {
            _counterService = counterService;
        }

        public override async Task Initialize()
        {
            _counter = 0d;
            _increment = 1d;

            await base.Initialize();
        }

        private void Increase()
        {
            Counter = _counterService.Increase(Counter, Increment);
        }

        private void Decrease()
        {
            Counter = _counterService.Decrease(Counter, Increment);
        }

        private void Reset()
        {
            Counter = _counterService.Reset();
        }
    }
}
