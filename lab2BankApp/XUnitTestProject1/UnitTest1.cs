using System;
using Xunit;
using static lab2BankApp.Program;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void BalanceTest()
        {
            Assert.Equal(100000, View(100000));
        }

        [Fact]
        public void TestingNewBalance()
        {
            Assert.NotEqual(100200, View(100000));
        }

        [Fact]
        public void TestingNewBalanceAfterWithdraw()
        {
            Assert.Equal(99500, Withdraw(100000, 500));
        }

        [Theory]
        [InlineData(100000, 500)]
        [InlineData(100, 50)]
        [InlineData(0, 80000)]

        public void TestingNewBalanceAfterDeposit(double balance, double amountNum)
        {
            double total = balance + amountNum;
            Assert.Equal(total, Deposit(balance, amountNum));

        }

    }
}
