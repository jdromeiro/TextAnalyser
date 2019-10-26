using System.Collections.Generic;
using Domain.Model;

namespace Domain.Services.Common
{
    internal interface IParagraphConverter
    {
        IEnumerable<Paragraph> ConvertToParagraphs(string text);

        string ConvertToString(IEnumerable<Paragraph> paragraphs);
    }
}
