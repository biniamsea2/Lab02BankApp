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
        public void TestingDeposit()
        {
            Assert.Equal(100200, Deposit(100000, 200));
        }



    }
}
