using System.Collections.Generic;
using System.Linq;
using Domain.Model;

namespace Domain.Services.Sort.Strategies
{
    internal class ByAlphabeticOrderSortingStrategy : ISortingStrategy
    {
        public IEnumerable<Paragraph> Sort(IEnumerable<Paragraph> paragraphs)
        {
            var sortedParagraphs = paragraphs.ToList();
            sortedParagraphs.Sort(new ParagraphComparer());

            return sortedParagraphs;
        }
    }
}
