using System.Collections.Generic;
using Domain.Model;

namespace Domain.Services
{
    public interface ISortingStrategy
    {
        IEnumerable<Paragraph> Sort(IEnumerable<Paragraph> paragraphs);
    }
}
