using SynetecAssessmentApi.Domain.AggregatesModel.BonusPoolAggregate;
using System;
using System.Linq;
using Xunit;

namespace SynetecAssessmentApi.Domain.Tests
{
    public class BonusPoolCreationTests
    {
        [Fact]
        public void BonusPool_ThrowsException_IfInvalidPercentage()
        {
            BonusPool bonusPool = null;

            MockData mockData = new MockData();

            // value set 1
            decimal testProfit = 1000;
            decimal testBonusPercentage = 1.5m;

            Assert.Throws<Exception>(
                () => bonusPool = new BonusPool(testProfit, testBonusPercentage, mockData.MockEmployees.ToList())
            );

            // value set 2
            testProfit = 1000;
            testBonusPercentage = -0.5m;

            Assert.Throws<Exception>(
                () => bonusPool = new BonusPool(testProfit, testBonusPercentage, mockData.MockEmployees.ToList())
            );

        }

        [Fact]
        public void BonusPool_ThrowsException_IfInvalidProfit()
        {
            BonusPool bonusPool = null;

            MockData mockData = new MockData();

            // value set 1
            decimal testProfit = 0;
            decimal testBonusPercentage = 0.5m;

            Assert.Throws<Exception>(
                () => bonusPool = new BonusPool(testProfit, testBonusPercentage, mockData.MockEmployees.ToList())
            );

            // value set 2
            testProfit = -500;
            testBonusPercentage = 0.5m;

            Assert.Throws<Exception>(
                () => bonusPool = new BonusPool(testProfit, testBonusPercentage, mockData.MockEmployees.ToList())
            );
        }

        [Fact]
        public void BonusPool_Created_IfValidValues()
        {
            MockData mockData = new MockData();

            decimal testProfit = 1000;
            decimal testBonusPercentage = 0.5m;

            BonusPool bonusPool = new BonusPool(testProfit, testBonusPercentage, mockData.MockEmployees.ToList());
        }
    }
}
