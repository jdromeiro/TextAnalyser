using Domain.Model;
using Domain.Services.Statistics.Calculators;
using Xunit;

namespace Domain.Services.Tests
{
    public class StatisticCalculatorsTests
    {
        private readonly string testString = "Imagine there's no countries\r\n"
            + "-It isn't hard to do-\r\n"
            + "Nothing to kill or die for\r\n"
            + "-And no religion, too-";

        [Fact]
        public void HyphenCount_GenerateStatistics_Success()
        {
            // arrange
            var text = testString;

            var calculator = new HyphenCount();

            // act
            var statistic = calculator.GenerateStatistic(text);

            // assert
            Assert.Equal(StatisticType.NumberOfHyphens, statistic.Type);
            Assert.Equal(4, statistic.Value);
        }

        [Fact]
        public void SpaceCount_GenerateStatistics_Success()
        {
            // arrange
            var text = testString;

            var calculator = new SpaceCount();

            // act
            var statistic = calculator.GenerateStatistic(text);

            // assert
            Assert.Equal(StatisticType.NumberOfSpaces, statistic.Type);
            Assert.Equal(21, statistic.Value);
        }

        [Fact]
        public void WordCount_GenerateStatistics_Success()
        {
            // arrange
            var text = testString;

            var calculator = new WordCount();

            // act
            var statistic = calculator.GenerateStatistic(text);

            // assert
            Assert.Equal(StatisticType.NumberOfWords, statistic.Type);
            Assert.Equal(22, statistic.Value);
        }
    }
}
