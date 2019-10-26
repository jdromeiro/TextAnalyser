using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Model;

namespace Domain.Services.Sort.Strategies
{
    internal class ByReversedOrderSortingStrategy : ISortingStrategy
    {
        public IList<Paragraph> Sort(IList<Paragraph> paragraphs)
        {
            return paragraphs.Reverse().ToList();
        }
    }
}
