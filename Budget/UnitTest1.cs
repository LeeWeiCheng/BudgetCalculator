using NUnit.Framework;
using System;

namespace Budget
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            //
        }

        [Test]
        public void whole_month()
        {
            var budgetCalculator = new BudgetCalculator();
            var startTime = new DateTime(2021, 1, 1);
            var endTime = new DateTime(2021,1,31);

            var amount = budgetCalculator.Query(startTime, endTime);

            Assert.AreEqual(31,amount);
        }
    }
}