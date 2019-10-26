using System.Collections.Generic;
using Domain.Model;

namespace Domain.Services
{
    public interface ISortingStrategy
    {
        IList<Paragraph> Sort(IList<Paragraph> paragraphs);
    }
}
