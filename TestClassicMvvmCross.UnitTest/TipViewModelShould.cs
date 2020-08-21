using System;
using System.Threading.Tasks;
using Moq;
using MvvmCross.Tests;
using NUnit.Framework;
using TestClassicMvvmCross.Core.Services;
using TestClassicMvvmCross.Core.ViewModels;

namespace TestClassicMvvmCross.UnitTest
{
    public class TipViewModelShould : MvxIoCSupportingTest
    {
        [Test]
        public async Task TestThatWhenSubTotalChangeTipUpdate()
        {
            //Arrange
            var calculatorService = new CalculatorService();
            //sut: System Under Test
            var sut = new TipViewModel(calculatorService);
            await sut.Initialize();
            sut.SubTotal = 200;
            Assert.That(sut.Tip, Is.EqualTo(20));
        }
    }
}
