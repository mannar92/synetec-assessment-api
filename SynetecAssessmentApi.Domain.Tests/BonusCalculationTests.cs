using SynetecAssessmentApi.Domain.AggregatesModel.BonusPoolAggregate;
using System;
using System.Linq;
using Xunit;

namespace SynetecAssessmentApi.Domain.Tests
{
    public class BonusCalculationTests
    {
        [Fact]
        public void CalculateTotalSalary()
        {
            //arrange
            decimal expectedTotalSalary = 654750m;
            decimal testProfit = 1000;
            decimal testBonusPercentage = 0.5m;

            //act
            MockData mockData = new MockData();
            BonusPool bonusPool = new BonusPool(testProfit, testBonusPercentage, mockData.MockEmployees.ToList());
            decimal actualTotalSalary = bonusPool.CalculateTotalSalary();

            //Assert
            Assert.Equal(expectedTotalSalary, actualTotalSalary);
        }

        [Fact]
        public void CalculateBonus_ThrowsException_IfEmployeeNotFound()
        {
            BonusPool bonusPool = null;

            MockData mockData = new MockData();

            decimal testProfit = 1000;
            decimal testBonusPercentage = 0.5m;

            int testEmployeeId = 999;

            bonusPool = new BonusPool(testProfit, testBonusPercentage, mockData.MockEmployees.ToList());

            Assert.Throws<Exception>(
                () => bonusPool.CalculateBonus(testEmployeeId)
            );
        }

        [Fact]
        public void CalculateBonus()
        {
            BonusPool bonusPool = null;

            MockData mockData = new MockData();

            decimal testProfit = 1000;
            decimal testBonusPercentage = 0.5m;

            bonusPool = new BonusPool(testProfit, testBonusPercentage, mockData.MockEmployees.ToList());

            int testEmployeeId_A = 1;
            decimal expectedBonus_A = 45.819015m;
            decimal actualBonus_A = bonusPool.CalculateBonus(testEmployeeId_A);
            Assert.Equal(expectedBonus_A, actualBonus_A, 6);

            int testEmployeeId_B = 2;
            decimal expectedBonus_B = 68.728522m;
            decimal actualBonus_B = bonusPool.CalculateBonus(testEmployeeId_B);
            Assert.Equal(expectedBonus_B, actualBonus_B, 6);

            int testEmployeeId_C = 3;
            decimal expectedBonus_C = 72.546774m;
            decimal actualBonus_C = bonusPool.CalculateBonus(testEmployeeId_C);
            Assert.Equal(expectedBonus_C, actualBonus_C, 6);

            int testEmployeeId_D = 4;
            decimal expectedBonus_D = 42.000764m;
            decimal actualBonus_D = bonusPool.CalculateBonus(testEmployeeId_D);
            Assert.Equal(expectedBonus_D, actualBonus_D, 6);

            int testEmployeeId_E = 5;
            decimal expectedBonus_E = 34.364261m;
            decimal actualBonus_E = bonusPool.CalculateBonus(testEmployeeId_E);
            Assert.Equal(expectedBonus_E, actualBonus_E, 6);
        }

    }
}
