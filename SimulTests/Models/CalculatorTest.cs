using Simul.Models;
using Xunit;

namespace SimulTests.Models
{
    public class CalculatorTest
    {
        public CalculatorTest()
        {

        }

        [Theory]
        [InlineData(0.5, 1.5)]
        [InlineData(4, 4.5)]
        [InlineData(8, 8.25)]
        [InlineData(20, 20.10)]
        [InlineData(150, 150.05)]
        public void CalculateSkillIncrement_DependingOnSkill_RightIncrement(decimal skillInput, decimal skillOutput)
        {
            var result = Calculator.CalculateSkillIncrement(skillInput);

            Assert.Equal(skillOutput, result);
        }

        [Theory]
        [InlineData(9, 10)]
        [InlineData(42, 42.5)]
        [InlineData(87, 87.25)]
        [InlineData(200, 200.10)]
        [InlineData(10543, 10543.05)]
        public void CalculateStrengthIncrement_DependingOnStrength_RightIncrement(decimal strengthInput, decimal strengthOutput)
        {
            var result = Calculator.CalculateStrengthIncrement(strengthInput);

            Assert.Equal(strengthOutput, result);
        }
    }
}
