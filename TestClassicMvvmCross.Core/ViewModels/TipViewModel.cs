using System;
using System.Threading.Tasks;
using MvvmCross.ViewModels;
using TestClassicMvvmCross.Core.Services;

namespace TestClassicMvvmCross.Core.ViewModels
{
    public class TipViewModel : MvxViewModel
    {
        private readonly ICalculatorService _calculatorServices;
        private decimal _subTotal;
        private int _generosity;
        private decimal _tip;

        public TipViewModel(ICalculatorService calculatorServices)
        {
            _calculatorServices = calculatorServices;
        }
        public decimal SubTotal
        {
            get => _subTotal;
            set
            {
                _subTotal = value;
                RaisePropertyChanged(() => SubTotal);
                Recalculate();
            }
        }

        public decimal Tip
        {
            get => _tip;
            set => SetProperty(ref _tip, value);
        }

        public int Generosity
        {
            get => _generosity;
            set
            {
                _generosity = value;
                RaisePropertyChanged(() => Generosity);
                Recalculate();
            }
        }

        public override async Task Initialize()
        {
            await base.Initialize();

            SubTotal = 100;
            Generosity = 10;
            Recalculate();
        }

        private void Recalculate()
        {
            Tip = _calculatorServices.TipAmount(SubTotal, Generosity);
        }
    }
}
