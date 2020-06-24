/*using Breakfast;
using System;
using System.Threading;
using Util.Extensions;
using Xunit;


namespace BreakfastTest
{
    public class BreakfastTest
    {


        [Fact(DisplayName = "Test Object")]
        public void TestPouringCoffee()
        {

            var coffee = Breakfast.Breakfast.PourCoffee();
            Assert.True(typeof(Coffee) == coffee.GetType());

        }

        [Fact(DisplayName = "Test Temperature")]
        public void TestCoffeeTemperature()
        {
            var coffee = Breakfast.Breakfast.PourCoffee();
            Assert.Equal("Hot", coffee.Temperature);
            Thread.Sleep(500);
            Assert.Equal("Quite hot", coffee.Temperature);
            Thread.Sleep(500);
            Assert.Equal("Not so hot", coffee.Temperature);
            Thread.Sleep(500);
            Assert.Equal("Cold", coffee.Temperature);
        }

        [Fact]
        public void TestFryingEggsLength()
        {

            var eggs = Breakfast.Breakfast.FryEggs(2);
            Assert.Equal(2, eggs.Length);
            Assert.Equal("2 eggs", eggs.Print());
        }

        [Fact]
        public void TestFryingBaconLength()
        {
            var bacon = Breakfast.Breakfast.FryBacon(3);
            Assert.Equal(3, bacon.Length);
            Breakfast.Breakfast.EatBacon(ref bacon, 2);
            Assert.Single(bacon);
            //Assert.Equal(1, bacon.Length);
        }

        [Fact]
        public void TestToastingBreadLength()
        {
            var toasts = Breakfast.Breakfast.ToastBread(2);
            Assert.Equal(2, toasts.Length);
        }

        [Fact]
        public void TestApplyingToToast()
        {
            var toasts = Breakfast.Breakfast.ToastBread(2);

            Breakfast.Toast.ApplyButter(toasts[0]);
            Breakfast.Toast.ApplyJam(toasts[1]);

            Assert.False(toasts[0].JamApplied);
            Assert.False(toasts[1].ButterApplied);
            Assert.True(toasts[1].JamApplied);
            Assert.True(toasts[0].ButterApplied);
        }

    }
}
*/