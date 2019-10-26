using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Model;

namespace Domain.Services.Sort.Strategies
{
    internal class ByReverseOrderStrategy : ISortingStrategy
    {
        public IEnumerable<Paragraph> Sort(IEnumerable<Paragraph> paragraphs)
        {
            paragraphs.Reverse();

            return paragraphs;
        }
    }
}
