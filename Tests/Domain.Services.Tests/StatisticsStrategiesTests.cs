using Domain.Model;
using Domain.Services.Statistics.Strategies;
using Xunit;

namespace Domain.Services.Tests
{
    public class StatisticsStrategiesTests
    {
        private readonly string testString = "Imagine there's no countries\r\n"
            + "-It isn't hard to do-\r\n"
            + "Nothing to kill or die for\r\n"
            + "-And no religion, too-";

        [Fact]
        public void HyphenCountStrategy_GenerateStatistics_Success()
        {
            // arrange
            var text = testString;

            var hyphenCountStrategy = new HyphenCountStrategy();

            // act
            var statistic = hyphenCountStrategy.GenerateStatistic(text);

            // assert
            Assert.Equal(StatisticType.NumberOfHyphens, statistic.Type);
            Assert.Equal(4, statistic.Value);
        }

        [Fact]
        public void SpaceCountStrategy_GenerateStatistics_Success()
        {
            // arrange
            var text = testString;

            var spaceCountStrategy = new SpaceCountStrategy();

            // act
            var statistic = spaceCountStrategy.GenerateStatistic(text);

            // assert
            Assert.Equal(StatisticType.NumberOfSpaces, statistic.Type);
            Assert.Equal(21, statistic.Value);
        }

        [Fact]
        public void WordCountStrategy_GenerateStatistics_Success()
        {
            // arrange
            var text = testString;

            var wordCountStrategy = new WordCountStrategy();

            // act
            var statistic = wordCountStrategy.GenerateStatistic(text);

            // assert
            Assert.Equal(StatisticType.NumberOfWords, statistic.Type);
            Assert.Equal(22, statistic.Value);
        }
    }
}
