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
        public void DepositTest()
        {
            Assert.Equal(500, View(100500));
        }



    }
}
