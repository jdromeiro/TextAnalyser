using System.Collections.Generic;
using Domain.Model;

namespace Domain.Services.Common
{
    public interface IParagraphConverter
    {
        IList<Paragraph> ConvertToParagraphs(string text);

        string ConvertToString(IList<Paragraph> paragraphs);
    }
}
