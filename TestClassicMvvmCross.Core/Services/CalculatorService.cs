using System;
namespace TestClassicMvvmCross.Core.Services
{
    public class CalculatorService : ICalculatorService
    {

        public decimal TipAmount(decimal subTotal, double generosity)
        {
            return subTotal * (decimal)(generosity / 100);
        }
    }
}
