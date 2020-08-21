using System;
namespace TestClassicMvvmCross.Core.Services
{
    public interface ICalculatorService
    {
        decimal TipAmount(decimal subTotal, double generosity);
    }
}
