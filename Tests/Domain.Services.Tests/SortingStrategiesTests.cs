using System.Collections.Generic;
using Domain.Model;
using Domain.Services.Sort.Strategies;
using FluentAssertions;
using Xunit;

namespace Domain.Services.Tests
{
    public class SortingStrategiesTests
    {
        [Fact]
        public void ByAlphabeticOrderSortingStrategy_GenerateStatistics_Success()
        {
            // arrange
            var paragraphs = this.GetUnsortedParagraphs();
            var expectedParagraphs = this.GetParagraphsByAlphabeticOrder();

            var strategy = new ByAlphabeticOrderSortingStrategy();

            // act
            var result = strategy.Sort(paragraphs);

            // assert
            result.Should().BeEquivalentTo(expectedParagraphs, options => options.WithStrictOrdering());
        }

        [Fact]
        public void ByReversedAlphabeticOrderSortingStrategy_GenerateStatistics_Success()
        {
            // arrange
            var paragraphs = this.GetUnsortedParagraphs();
            var expectedParagraphs = this.GetParagraphsByReversedAlphabeticOrder();

            var strategy = new ByReversedAlphabeticOrderSortingStrategy();

            // act
            var result = strategy.Sort(paragraphs);

            // assert
            result.Should().BeEquivalentTo(expectedParagraphs, options => options.WithStrictOrdering());
        }

        [Fact]
        public void ByReversedOrderSortingStrategy_GenerateStatistics_Success()
        {
            // arrange
            var paragraphs = this.GetUnsortedParagraphs();
            var expectedParagraphs = this.GetParagraphsByReversedOrder();

            var strategy = new ByReversedOrderSortingStrategy();

            // act
            var result = strategy.Sort(paragraphs);

            // assert
            result.Should().BeEquivalentTo(expectedParagraphs, options => options.WithStrictOrdering());
        }

        private List<Paragraph> GetParagraphsByAlphabeticOrder()
        {
            return new List<Paragraph>()
            {
                new Paragraph("And no religion, too"),
                new Paragraph("Imagine there's no countries"),
                new Paragraph("It isn't hard to do"),
                new Paragraph("Nothing to kill or die for"),
            };
        }

        private List<Paragraph> GetParagraphsByReversedAlphabeticOrder()
        {
            return new List<Paragraph>()
            {
                new Paragraph("Nothing to kill or die for"),
                new Paragraph("It isn't hard to do"),
                new Paragraph("Imagine there's no countries"),
                new Paragraph("And no religion, too")
            };
        }

        private List<Paragraph> GetParagraphsByReversedOrder()
        {
            return new List<Paragraph>()
            {
                new Paragraph("And no religion, too"),
                new Paragraph("Nothing to kill or die for"),
                new Paragraph("It isn't hard to do"),
                new Paragraph("Imagine there's no countries"),
            };
        }

        private List<Paragraph> GetUnsortedParagraphs()
        {
            return new List<Paragraph>()
            {
                new Paragraph("Imagine there's no countries"),
                new Paragraph("It isn't hard to do"),
                new Paragraph("Nothing to kill or die for"),
                new Paragraph("And no religion, too")
            };
        }
    }
}
